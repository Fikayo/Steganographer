using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using Stenographer.Presentation;
using MainApplication = System.Windows.Forms.Application;
namespace Stenographer
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            MainApplication.EnableVisualStyles();
            MainApplication.SetCompatibleTextRenderingDefault(false);
            MainApplication.Run(new MainForm());

            ////StringBuilder message = new StringBuilder();

            ////string info = "Encrypted:True;FileType:Str;Ext:    ;Length:00000040;0000";
            ////message.AppendLine(info);
            ////var ascibytes = Encoding.ASCII.GetBytes(info);
            ////var bits = Util.GetBits(ascibytes);
            ////var convertedBytes = Util.ConvertBinaryToBytes(bits);
            ////System.Windows.Forms.Clipboard.SetText(bits);
            ////message.AppendLine();
            ////message.AppendLine(string.Join(", ", ascibytes));
            ////message.AppendLine(bits);
            ////message.AppendLine(string.Join(", ", convertedBytes));
            ////message.AppendLine();
            ////message.AppendLine(Encoding.ASCII.GetString((byte[])ascibytes.Clone()));
            ////////message.AppendLine(Util.ByteArrayToObject(ascibytes).ToString());

            ////foreach (var b in ascibytes)
            ////{
            ////    message.Append(Util.GetChar(b));
            ////}

            ////System.Windows.Forms.MessageBox.Show(message.ToString());
            ////string pictures = @"C:\Users\owner\Pictures";
            ////string filename = Path.Combine(pictures, "pic.jpg");
            ////Bitmap b = new Bitmap(filename);

            ////filename = Path.Combine(pictures,"reveal_mine.png");
            ////Bitmap encrypt = new Bitmap(filename);
            ////Encryptable encryptable = new Encryptable(encrypt, FileType.Img);

            ////Embedder embedder = new Embedder();
            ////var result = embedder.Embed(b, encryptable);
            ////result.Save(@"C:\Users\owner\Documents\Visual Studio 2012\Projects\Stenographer\Stenographer\Outputs\EnctypedTest2.jpg");

            ////Decrypter dec = new Decrypter();
            ////var decrypted = dec.Decrypt(result);
            ////decrypted.Save(@"C:\Users\owner\Documents\Visual Studio 2012\Projects\Stenographer\Stenographer\Outputs");
        }
    }
}
