using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace Stenographer.Application
{
    public class ImageEncryption : Encryptable
    {
        public ImageEncryption(string imagePath, string ext)
            : base(Util.ReadImage(imagePath), FileType.Img, ext)
        {
        }
    }
}
