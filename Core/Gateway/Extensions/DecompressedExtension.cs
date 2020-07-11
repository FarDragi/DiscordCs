using System.IO;
using System.IO.Compression;
using System.Text;

namespace FarDragi.DragiCordApi.Core.Gateway.Extensions
{
    public class DecompressedExtension
    {
        private readonly MemoryStream _compressed;
        private readonly DeflateStream _decompressor;

        public DecompressedExtension()
        {
            _compressed = new MemoryStream();
            _decompressor = new DeflateStream(_compressed, CompressionMode.Decompress);
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
            if (sufix == new byte[] { 0x00, 0x00, 0xff, 0xff })
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
