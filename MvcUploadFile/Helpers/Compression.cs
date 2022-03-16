using System.IO;
using System.IO.Compression;

namespace MvcUploadFile.Helpers
{
    public class Compression
    {
        public byte[] Compress(byte[] dataToCompress)
        {
            using var ms = new MemoryStream();
            using (var gzipStream = new GZipStream(ms, CompressionLevel.Optimal, false))
            {
                gzipStream.Write(dataToCompress);
            }

            return ms.ToArray();
        }

        public byte[] Decompress(byte[] compressedData)
        {
            using var ms = new MemoryStream();
            using (var compressedStream = new MemoryStream(compressedData))
            using (var gzipStream = new GZipStream(compressedStream, CompressionMode.Decompress, false))
            {
                gzipStream.CopyTo(ms);
            }
            return ms.ToArray();
        }

    }
}
