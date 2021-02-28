using System.IO;
using System.IO.Compression;
using System.Text;

namespace FarDragi.DiscordCs.Gateway.Socket
{
    public class WebSocketDecompress
    {
        private readonly MemoryStream _compressed;
        private readonly DeflateStream _decompressor;
        private readonly byte[] _zLibSufix;

        public WebSocketDecompress()
        {
            _compressed = new MemoryStream();
            _decompressor = new DeflateStream(_compressed, CompressionMode.Decompress);
            _zLibSufix = new byte[4] { 0x00, 0x00, 0xff, 0xff };
        }

        public bool TryDecompress(byte[] data, out string json)
        {
            if (data[0] == 0x78)
            {
                _compressed.Write(data, 2, data.Length - 2);
            }
            else
            {
                _compressed.Write(data, 0, data.Length);
            }

            _compressed.Flush();
            _compressed.Position = 0;

            byte[] sufix = data[^4..];
            if (sufix == _zLibSufix)
            {
                json = null;
                return false;
            }

            using MemoryStream decompressed = new MemoryStream();

            try
            {
                _decompressor.CopyTo(decompressed);
                json = Encoding.UTF8.GetString(decompressed.ToArray());
                return true;
            }
            catch
            {
                json = null;
                return false;
            }
            finally
            {
                _compressed.Position = 0;
                _compressed.SetLength(0);
            }
        }
    }
}
