using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;

namespace Stenographer.Application
{
    public class EncryptResult
    {
        private Image image;
        public EncryptResult(byte[] bytes, EncryptionHeader header)
            : this(header)
        {
            this.Bytes = bytes;
        }

        public EncryptResult(Image image)
        {
            this.image = image;
            this.Bytes = Util.ObjectToByteArray(image);
            var ext = ImageFormat.Png.FileExtensionFromConverter();
            this.Header = EncryptionHeader.Create(FileType.Img, ext, 0);
        }

        private EncryptResult(EncryptionHeader header)
        {
            this.Header = header;
        }

        public EncryptionHeader Header { get; private set; }

        public byte[] Bytes { get; private set; }

        public void Save(string filepath)
        {
            string ext = this.Header.FileExt;
            if (this.Header.FileType == FileType.Str)
            {
                ext = "txt";
            }

            filepath = Path.ChangeExtension(filepath, ext);
            switch (this.Header.FileType)
            {
                case FileType.Str:
                    {
                        this.SaveString(filepath);
                        break;
                    }

                case FileType.Img:
                    {
                        this.SaveImage(filepath);
                        break;
                    }

                case FileType.Fle:
                    {
                        this.SaveFile(filepath);
                        break;
                    }

                default:
                    break;
            }
        }

        private void SaveString(string filepath)
        {
            var message = Util.GetString(this.Bytes);
            File.WriteAllText(filepath, message);
        }

        private void SaveImage(string filepath)
        {
            ////var image = this.Object as Image;
            ////image.Save(filepath);
            if (image != null)
            {
                image.Save(filepath);
                return;
            }

            using (var fs = new BinaryWriter(new FileStream(filepath, FileMode.Append, FileAccess.Write)))
            {
                fs.Write(this.Bytes);
            }
        }

        private void SaveFile(string filepath)
        {
            File.WriteAllBytes(filepath, this.Bytes);
            ////using (var memStream = new MemoryStream())
            ////using (var fileStream = File.OpenWrite(filepath))
            ////{
            ////    fileStream.Write(this.Bytes, 0, this.Bytes.Length);
            ////}
        }
    }
}
