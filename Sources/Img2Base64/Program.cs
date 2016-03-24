using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Img2Base64
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        private static string base64raw, base64html5, base64prefix;
        private static IReadOnlyDictionary<string, string> mimeTypes = new Dictionary<string, string> { { ".gif", "gif" }, { ".png", "png" }, { ".jpg", "jpeg" }, { ".jpeg", "jpeg" } };


        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length > 0)
            {
                foreach (var inputFile in args)
                {
                    var path = Path.GetDirectoryName(inputFile);
                    var newFile = Path.GetFileNameWithoutExtension(inputFile);
                    var base64 = Convert.ToBase64String(File.ReadAllBytes(inputFile));
                    base64raw = base64;
                    string mime = null;
                    if (!mimeTypes.TryGetValue(Path.GetExtension(inputFile), out mime))
                        return;
                    base64prefix = $"data:image/{mime};base64,{base64}";
                    base64html5 = $"<img src=\"{base64prefix}\">";
                    try
                    {
                        var outputFile = Path.Combine(path, newFile);
                        File.WriteAllText(outputFile + ".raw.base64.txt", base64raw, Encoding.UTF8);
                        File.WriteAllText(outputFile + ".prefix.base64.txt", base64prefix, Encoding.UTF8);
                        File.WriteAllText(outputFile + ".html5.base64.txt", base64html5, Encoding.UTF8);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
                Application.Exit();
            }
            else if (args.Length == 0)
            {
                Application.Run(new FrmMain());
            }
        }
    }
}
