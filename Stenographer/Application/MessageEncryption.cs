using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stenographer.Application
{
    public class MessageEncryption : Encryptable
    {
        public MessageEncryption(string message)
            : base(Util.GetBytes(message), FileType.Str, string.Empty)
        {
        }
    }
}
