using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Stenographer.Application
{
    public class FileEncryption : Encryptable
    {
        public FileEncryption(string filepath)
            : base(Util.FileToByteArray(filepath), FileType.Fle, Path.GetExtension(filepath))
        {
        }
    }
}
