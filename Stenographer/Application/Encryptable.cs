using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Stenographer.Application
{
    public abstract class Encryptable
    {
        public const int ByteLength = 8;

        protected List<byte> bytes;
        private int currentByteIndex;
        private int currentBitIndex;
        protected string fileExt;

        public Encryptable(object obj, FileType fileType, string fileExt)
            : this(Util.ObjectToByteArray(obj), fileType, fileExt)
        {
        }

        public Encryptable(byte[] bytes, FileType fileType, string fileExt)
        {
            if (fileExt.Length > EncryptionHeader.FileExtLength)
            {
                fileExt = fileExt.Substring(0, EncryptionHeader.FileExtLength);
            }

            fileExt = fileExt.Replace(".", string.Empty);
            this.GenerateHeader(bytes, fileType, fileExt);
        }

        public EncryptionHeader Header { get; private set; }

        public int Precision { get; set; }

        public bool EndOfStream
        {
            get
            {
                return this.currentByteIndex == this.bytes.Count && this.currentBitIndex == 0;
            }
        }

        public bool NextBit
        {
            get
            {
                var currentByte = this.bytes[this.currentByteIndex];
                var currentBit = (currentByte & (1 << this.currentBitIndex)) != 0;

                this.currentBitIndex++;
                if (this.currentBitIndex >= ByteLength)
                {
                    this.currentByteIndex++;
                    this.currentBitIndex = 0;
                }

                return currentBit;
            }
        }

        private void GenerateHeader(byte[] objBytes, FileType fileType, string fileExt)
        {
            this.Header = EncryptionHeader.Create(fileType, fileExt, objBytes.Length);
            
            this.bytes = new List<byte>();
            this.bytes.AddRange(this.Header.HeaderAsBytes);
            this.bytes.AddRange(objBytes);
        }
    }
}
