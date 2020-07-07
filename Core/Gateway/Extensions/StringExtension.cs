using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FarDragi.DragiCordApi.Core.Gateway.Extensions
{
    internal static class StringExtension
    {
        internal static async Task<string> Decompress(this byte[] data)
        {
            using MemoryStream dataStream = new MemoryStream(data);
            using MemoryStream result = new MemoryStream();
            InflaterInputStream zip = new InflaterInputStream(dataStream);
            await zip.CopyToAsync(result);
            return Encoding.UTF8.GetString(result.ToArray());
        }
    }
}
