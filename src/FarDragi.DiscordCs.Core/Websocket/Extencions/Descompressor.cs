using System.IO;
using System.IO.Compression;
using System.Text;

namespace FarDragi.DiscordCs.Core.Websocket.Extencions
{
    public class Descompressor
    {
        private readonly MemoryStream compressed;
        private readonly DeflateStream decompressor;
        private readonly byte[] zlibSufix;

        public Descompressor()
        {
            compressed = new MemoryStream();
            decompressor = new DeflateStream(compressed, CompressionMode.Decompress);
            zlibSufix = new byte[] { 0x00, 0x00, 0xff, 0xff };
        }

        public bool TryDecompress(byte[] data, out string json)
        {
            if (data[0] == 0x78)
            {
                compressed.Write(data, 2, data.Length - 2);
            }
            else
            {
                compressed.Write(data, 0, data.Length);
            }

            compressed.Flush();
            compressed.Position = 0;

            byte[] sufix = data[^4..];
            if (sufix == zlibSufix)
            {
                json = null;
                return false;
            }

            using MemoryStream decompressed = new MemoryStream();

            try
            {
                decompressor.CopyTo(decompressed);
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
                compressed.Position = 0;
                compressed.SetLength(0);
            }
        }
    }
}
