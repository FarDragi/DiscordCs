using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Threading.Tasks;

namespace FarDragi.DragiCordApi.Core.Gateway.Extensions
{
    internal static class StringExtension
    {
        internal static async Task<JObject> Decompress(this byte[] data)
        {
            using MemoryStream decompressed = new MemoryStream();
            using MemoryStream compressed = new MemoryStream();
            using DeflateStream decompressor = new DeflateStream(compressed, CompressionMode.Decompress);

            compressed.Write(data, 2, data.Length - 2);
            compressed.SetLength(data.Length - 2);

            //if (data[0] == 0x78)
            //{
                
            //}
            //else
            //{
            //    compressed.Write(data, 0, data.Length);
            //    compressed.SetLength(data.Length);
            //}

            compressed.Position = 0;
            await decompressor.CopyToAsync(decompressed);
            decompressed.Position = 0;

            using StreamReader reader = new StreamReader(decompressed);
            using JsonTextReader textReader = new JsonTextReader(reader);

            return (JObject)JToken.ReadFrom(textReader);

            //MemoryStream memory = new MemoryStream(data);
            //MemoryStream result = new MemoryStream();
            //InflaterInputStream zip = new InflaterInputStream(memory);
            //await zip.CopyToAsync(result);
            //return Encoding.UTF8.GetString(result.ToArray());





            //ArraySegment<byte> compress = new ArraySegment<byte>(data);

            //MemoryStream memory = new MemoryStream();
            //DeflateStream deflate = new DeflateStream(memory, CompressionMode.Decompress);

            //if (compress.Array[0] == 0x78)
            //{
            //    memory.Write(compress.Array, compress.Offset + 2, compress.Count - 2);
            //}
            //else
            //{
            //    memory.Write(compress.Array, compress.Offset, compress.Count);
            //}

            //memory.Flush();
            //memory.Position = 0;

            //MemoryStream result = new MemoryStream();

            //await deflate.CopyToAsync(result);
            //return Encoding.UTF8.GetString(result.ToArray());
        }
    }
}
