using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GTACoOp
{
    public static class Lz4
    {
        [DllImport("liblz4.dll", EntryPoint = "LZ4_compress_default")]
        private static extern int compress_default([In] byte[] source, [Out] byte[] dest, int sourceSize, int maxDestSize);
        [DllImport("liblz4.dll", EntryPoint = "LZ4_decompress_safe")]
        private static extern int decompress_safe([In] byte[] source, [Out] byte[] dest, int compressedSize, int maxDecompressedSize);

        public static byte[] CompressString(byte[] source)
        {
            return Encoding.ASCII.GetBytes(CompressString(Encoding.ASCII.GetString(source)));
        }
        public static string CompressString(string source)
        {
            var sourceByteArray = Encoding.ASCII.GetBytes(source);
            var outArray = new byte[1024 * 1024];
            compress_default(sourceByteArray, outArray, sourceByteArray.Length, outArray.Length);
            return Encoding.ASCII.GetString(outArray).Trim('\0');
        }
        public static byte[] DecompressString(byte[] source)
        {
            return Encoding.ASCII.GetBytes(DecompressString(Encoding.ASCII.GetString(source)));
        }
        public static string DecompressString(string source)
        {
            var sourceByteArray = Encoding.ASCII.GetBytes(source);
            var outArray = new byte[1024 * 1024];
            decompress_safe(sourceByteArray, outArray, sourceByteArray.Length, outArray.Length);
            return Encoding.ASCII.GetString(outArray).Trim('\0');
        }
    }
}
