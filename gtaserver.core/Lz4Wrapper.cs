using System;
using System.Runtime.InteropServices;
using System.Text;

namespace GTAServer {
    public static class LinuxLz4Wrapper
    {
        [DllImport("liblz4.so", EntryPoint="LZ4_compress_default")]
        public static extern int compress_default([In] byte[] source, [Out] byte[] dest, int sourceSize, int maxDestSize);

        [DllImport("liblz4.so", EntryPoint="LZ4_decompress_safe")]
        public static extern int decompress_safe([In] byte[] source, [Out] byte[] dest, int compressedSize, int maxDecompressedSize);
    }

    public static class WindowsLz4Wrapper 
    {
        [DllImport("liblz4.dll", EntryPoint="LZ4_compress_default")]
        public static extern int compress_default([In] byte[] source, [Out] byte[] dest, int sourceSize, int maxDestSize);

        [DllImport("liblz4.dll", EntryPoint="LZ4_decompress_safe")]
        public static extern int decompress_safe([In] byte[] source, [Out] byte[] dest, int compressedSize, int maxDecompressedSize);
    }
    public static class Lz4Wrapper {
        public static string CompressString(string source) {
            byte[] sourceByteArray = Encoding.ASCII.GetBytes(source);
            byte[] outArray = new byte[1024*1024];
            if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) {
                LinuxLz4Wrapper.compress_default(sourceByteArray, outArray, sourceByteArray.Length, outArray.Length);
            }
            else {
                WindowsLz4Wrapper.compress_default(sourceByteArray, outArray, sourceByteArray.Length, outArray.Length);
            }
            return Encoding.ASCII.GetString(outArray).Trim('\0');
        }
        public static string DecompressString(string source) {
            byte[] sourceByteArray = Encoding.ASCII.GetBytes(source);
            byte[] outArray = new byte[1024*1024];
            if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) {
                LinuxLz4Wrapper.decompress_safe(sourceByteArray, outArray, sourceByteArray.Length, outArray.Length);
            }
            else {
                WindowsLz4Wrapper.decompress_safe(sourceByteArray, outArray, sourceByteArray.Length, outArray.Length);
            }
            return Encoding.ASCII.GetString(outArray).Trim('\0');
        }
    }
}