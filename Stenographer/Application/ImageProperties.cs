using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Stenographer.Application
{
    class ImageProperties
    {
        public ImageProperties(Image image)
        {
            this.Dimensions = image.Width + " x " + image.Height;
            this.SpaceAvailableInBytes = (image.Width * image.Height) / 2;
        }

        public string Dimensions { get; private set; }

        public long SpaceAvailableInBytes { get; private set; }
    }
}
