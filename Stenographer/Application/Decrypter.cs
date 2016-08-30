using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Stenographer.Application
{
    public class Decrypter
    {
        public EncryptResult Decrypt(Bitmap image)
        {
            bool done = false;

            List<bool> bits = new List<bool>();
            List<byte> message = new List<byte>();
            List<byte> headerBytes = new List<byte>();
            EncryptionHeader header = null;
            for (int j = 0; j < image.Height && !done; j++)
            {
                for (int i = 0; i < image.Width && !done; i++)
                {
                    var pixel = image.GetPixel(i, j);

                    byte alpha = pixel.A;
                    byte red = pixel.R;
                    byte green = pixel.G;
                    byte blue = pixel.B;

                    bits.Add(Util.GetBit(alpha, 0));
                    bits.Add(Util.GetBit(red, 0));
                    bits.Add(Util.GetBit(green, 0));
                    bits.Add(Util.GetBit(blue, 0));

                    if (bits.Count >= 8)
                    {
                        byte _char = Util.GetByteLittelEndian(bits);
                        if (header == null)
                        {
                            headerBytes.Add(_char);
                        }
                        else
                        {
                            message.Add(_char);
                        }

                        bits.Clear();
                    }

                    if (header == null)
                    {
                        if (headerBytes.Count >= EncryptionHeader.HeaderLength)
                        {
                            header = EncryptionHeader.Parse(headerBytes.ToArray());
                        }
                    }
                    else
                    {
                        if (message.Count >= header.MessageLength)
                        {
                            done = true;
                        }
                    }
                }
            }

            return new EncryptResult(message.ToArray(), header);
        }

        public void GetEncryptionHeader(Bitmap image)
        {
        }


    }
}
