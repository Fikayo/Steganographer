using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace Stenographer.Application
{
    internal class Embedder
    {
        public EncryptResult Embed(Bitmap image, Encryptable message)
        {
            Bitmap result = new Bitmap(image);
            bool done = false;
            int pixelBitIndex = 0;

            ////do
            ////{
            for (int j = 0; j < image.Height && !done; j++)
            {
                for (int i = 0; i < image.Width && !done; i++)
                {
                    var pixel = image.GetPixel(i, j);

                    byte alpha = pixel.A;
                    byte red = pixel.R;
                    byte green = pixel.G;
                    byte blue = pixel.B;

                    var nextBit = message.NextBit;
                    Set(ref alpha, pixelBitIndex, nextBit);

                    nextBit = message.NextBit;
                    Set(ref red, pixelBitIndex, nextBit);

                    nextBit = message.NextBit;
                    Set(ref green, pixelBitIndex, nextBit);

                    nextBit = message.NextBit;
                    Set(ref blue, pixelBitIndex, nextBit);

                    Color embedded = Color.FromArgb(alpha, red, green, blue);
                    result.SetPixel(i, j, embedded);

                    if (message.EndOfStream)
                    {
                        done = true;
                    }
                }
            }
            ////} while (++pixelBitIndex < Encryptable.ByteLength && !message.EndOfStream);

            ////var ext = ImageFormat.Png.FileExtensionFromConverter();
            ////var resultHeader = EncryptionHeader.Create(FileType.Img, ext, 0);
            return new EncryptResult(result);
        }

        public void Set(ref byte aByte, int pos, bool value)
        {
            if (value)
            {
                //left-shift 1, then bitwise OR
                aByte = (byte)(aByte | (1 << pos));
            }
            else
            {
                //left-shift 1, then take complement, then bitwise AND
                aByte = (byte)(aByte & ~(1 << pos));
            }
        }
    }
}
