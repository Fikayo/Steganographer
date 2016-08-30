using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stenographer.Application
{
    /// <summary>
    /// Represents the header to be used on encrypted images
    /// Header length = 57
    /// |Encrypted:True;FileType:xxx;Ext:----;Length:--------;0000|
    /// 
    /// First 14 words  : Encryption Signal
    /// Next 12 words   : Encrypted file type
    /// Next 8 words    : Encrypted file extension
    /// Next 15 words   : Message length
    /// Next 4 words    : Encryption footer
    /// 
    /// </summary>
    public class EncryptionHeader
    {
        public const string EncryptionSignal = "Encrypted:True";
        public const string HeaderFooter = "0000";
        public const char HeaderSeparator = ';';

        public const int HeaderLength = 57;
        public const int EncryptionSignalLength = 14;
        public const int FileTypeHeaderLength = 9;
        public const int FileTypeLength = 3;
        public const int FileExtHeaderLength = 4;
        public const int FileExtLength = 4;
        public const int MessageLengthHeaderLength = 7;
        public const int MessageLenLength = 8;
        public const int FooterLength = 4;

        private EncryptionHeader(FileType fileType, string fileExt, long messageLength)
        {
            this.FileType = fileType;
            this.FileExt = fileExt.Replace(".", string.Empty);
            this.MessageLength = messageLength;
            this.Init();
        }

        public string HeaderString { get; private set; }

        public byte[] HeaderAsBytes { get; private set; }

        public FileType FileType { get; private set; }

        public string FileExt { get; private set; }

        public long MessageLength { get; private set; }

        public static EncryptionHeader Create(FileType fileType, string fileExt, long messageLength)
        {
            return new EncryptionHeader(fileType, fileExt, messageLength);
        }

        public static byte[] GetHeader(FileType fileType, string fileExt, long messageLength)
        {
            var instance = new EncryptionHeader(fileType, fileExt, messageLength);
            return instance.HeaderAsBytes;
        }

        public static EncryptionHeader Parse(byte[] bytes)
        {
            int index = 0;
            string str = string.Empty;
            for (int i = 0; i < EncryptionSignalLength; i++)
            {
                str += Util.GetChar(bytes[i]);
                index = i;
            }

            if (str != EncryptionHeader.EncryptionSignal)
            {
                Util.Error("File doesn't not contain an encrypted message");
            }

            index++; // Skip separator
            index += EncryptionHeader.FileTypeHeaderLength + 1; // Jump to file type
            str = string.Empty;
            for (int i = index; i < index + EncryptionHeader.FileTypeLength; i++)
            {
                str += Util.GetChar(bytes[i]);
            }

            FileType fileType = (FileType)Enum.Parse(typeof(FileType), str);

            // Skip file type that was just read and file extension header
            index += EncryptionHeader.FileTypeLength + EncryptionHeader.FileExtHeaderLength + 1;

            var fileExt = string.Empty;
            for (int i = index; i < index + EncryptionHeader.FileExtLength; i++)
            {
                fileExt += Util.GetChar(bytes[i]);
            }
            
            // Skip file ext that was just read and message length header
            index += EncryptionHeader.FileExtLength + EncryptionHeader.MessageLengthHeaderLength + 1; 
            
            byte[] length = new byte[EncryptionHeader.MessageLenLength];
            for (int i = index, j = 0; i < index + EncryptionHeader.MessageLenLength; i++, j++)
            {
                length[j] = bytes[i];
            }

            long messageLength = Util.GetLong(length);

            return Create(fileType, fileExt, messageLength);
        }

        private void Init()
        {
            /// |Encrypted:True;FileType:xxx;Ext:----;Length:--------;0000|
            /* 
             * All headers are separated with semicolons "00111011"
             * The file header ends with 4 0's before the encryption begins
            */

            // First 14 words is encryption signal "Encrypted:True"

            // Next 12 words is File type "FileType:xxx"
            var fileT = string.Format("FileType:{0, -" + EncryptionHeader.FileTypeLength + "}", this.FileType);

            // Next 8 words is file ext
            var fileExt = string.Format("Ext:{0, -" + EncryptionHeader.FileExtLength + "}", this.FileExt);

            // Next 7 objBytes is encrypted length  in words header "MessageLength:-"
            var length = "Length:";

            var headerFront = string.Format("{1}{0}{2}{0}{3}{0}{4}", HeaderSeparator, EncryptionSignal, fileT, fileExt, length);
            byte[] fHeader = Util.GetBytes(headerFront);
            var mLength = Util.GetBytes(this.MessageLength);
            byte sep = Util.GetByte(EncryptionHeader.HeaderSeparator);
            var footer = Util.GetBytes(int.Parse(EncryptionHeader.HeaderFooter));

            var allBytes = new List<byte>();
            allBytes.AddRange(fHeader);
            allBytes.AddRange(mLength);
            allBytes.Add(sep);
            allBytes.AddRange(footer);

            this.HeaderAsBytes = allBytes.ToArray();
            this.HeaderString = string.Format("{0}{1}{2}{3}", headerFront, MessageLength, EncryptionHeader.HeaderSeparator, EncryptionHeader.HeaderFooter);
        }
    }
}
