using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Stenographer
{
    internal static class Util
    {
        public static void Error(string errorMessage)
        {
            throw new Exception(errorMessage);
        }

        public static bool GetBit(byte charByte, int bitIndex)
        {
            return (charByte & (1 << bitIndex)) != 0;
        }

        public static byte GetByteLittelEndian(List<bool> bits)
        {
            var stringBits = string.Empty;
            for (int i = bits.Count - 1; i >= 0; i--)
            {
                stringBits += bits[i] ? "1" : "0";
            }

            var _byte = Convert.ToByte(stringBits, 2);
            return _byte;
        }

        public static byte GetByteBigEndian(List<bool> bits)
        {
            var stringBits = string.Empty;
            for (int i = 0; i < bits.Count; i++)
            {
                stringBits += bits[i] ? "1" : "0";
            }

            var _byte = Convert.ToByte(stringBits, 2);
            return _byte;
        }

        public static byte GetByte(char _char)
        {
            return Convert.ToByte(_char);
        }

        public static string GetBits(byte[] bytes)
        {
            var str = string.Empty;
            foreach (var b in bytes)
            {
                str += ConvertToBinaryString(b);
            }

            return str;
        }

        public static byte[] ConvertBinaryToBytes(string str)
        {
            List<bool> bits = new List<bool>();
            List<byte> bytes = new List<byte>();
            foreach (var c in str)
            {
                if (bits.Count >= 8)
                {
                    bytes.Add(GetByteBigEndian(bits));
                    bits.Clear();
                }

                bits.Add(c == '1');
            }

            return bytes.ToArray();
        }

        public static string ConvertToBinaryString(byte b)
        {
            string str = string.Empty;
            for (int i = 7; i >= 0; i--)
            {
                str += GetBit(b, i) ? "1" : "0";
            }

            return str;
        }

        public static char GetChar(List<bool> bits)
        {
            byte _byte = Util.GetByteLittelEndian(bits);
            var _char = Convert.ToChar(_byte);
            return _char;
        }

        public static char GetChar(byte b)
        {
            return Convert.ToChar(b);
        }

        public static long GetLong(byte[] bytes)
        {
            return BitConverter.ToInt64(bytes, 0);
        }

        public static byte[] GetBytes(long l)
        {
            return BitConverter.GetBytes(l);
        }

        public static byte[] GetBytes(string str)
        {
            return Encoding.ASCII.GetBytes(str);
        }

        public static byte[] GetBytes(int i)
        {
            return BitConverter.GetBytes(i);
        }

        public static string GetString(byte[] bytes)
        {
            return Encoding.ASCII.GetString(bytes);
        }

        public static byte[] ReadImage(string filePath)
        {
            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (BinaryReader br = new BinaryReader(fs))
            {
                return br.ReadBytes((int)fs.Length);
            }
        }

        public static byte[] FileToByteArray(string filepath)
        {
            // BLock copy if file is greater than 10 MB
            bool blockCopy = new FileInfo(filepath).Length >= 10000;
            if (blockCopy)
            {
                List<byte> bytes = new List<byte>();
                using (Stream file = File.OpenRead(filepath))
                {
                    byte[] buffer = new byte[4096];

                    while (true)
                    {
                        int bytesRead = file.Read(buffer, 0, buffer.Length);
                        if (bytesRead == 0) break;

                        bytes.AddRange(buffer);
                    }
                }

                return bytes.ToArray();
            }

            return File.ReadAllBytes(filepath);
        }

        public static byte[] ObjectToByteArray(Object obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        public static object ByteArrayToObject(byte[] arrBytes)
        {
            using (var memStream = new MemoryStream())
            {
                var binForm = new BinaryFormatter();
                memStream.Write(arrBytes, 0, arrBytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                var obj = binForm.Deserialize(memStream);
                return obj;
            }
        }

        public static string FileExtensionFromConverter(this ImageFormat format)
        {
            return "." + new ImageFormatConverter().ConvertToString(format).ToLower();
        }

        public static string ToFileSize(this int source)
        {
            return ToFileSize(Convert.ToInt64(source));
        }

        public static string ToFileSize(this long source)
        {
            const int byteConversion = 1024;
            double bytes = Convert.ToDouble(source);

            if (bytes >= Math.Pow(byteConversion, 3)) //GB Range
            {
                return string.Concat(Math.Round(bytes / Math.Pow(byteConversion, 3), 2), " GB");
            }
            else if (bytes >= Math.Pow(byteConversion, 2)) //MB Range
            {
                return string.Concat(Math.Round(bytes / Math.Pow(byteConversion, 2), 2), " MB");
            }
            else if (bytes >= byteConversion) //KB Range
            {
                return string.Concat(Math.Round(bytes / byteConversion, 2), " KB");
            }
            else //Bytes
            {
                return string.Concat(bytes, " Bytes");
            }
        }
    }
}
