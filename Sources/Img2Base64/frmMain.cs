using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
namespace Img2Base64
{
    public partial class FrmMain : Form {

        private string base64raw, base64html5, base64prefix;
        private static IReadOnlyDictionary<string, string> mimeTypes = new Dictionary<string, string> { { ".gif", "gif" }, { ".png", "png" }, { ".jpg", "jpeg" }, { ".jpeg", "jpeg" } };
        public FrmMain()
        {
            InitializeComponent();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (rbFile.Checked)
            {
                LoadImg();
            }
            //else
            //{
            //    try
            //    {
            //        picPreview.LoadAsync(string.IsNullOrEmpty(txtUrl.Text).ToString());
            //    }
            //    catch
            //    {
            //        LoadImg();
            //    }
            //}
        }
        private void LoadImg()
        {
            if (imgOpen.ShowDialog() != DialogResult.OK) return;
            var path = imgOpen.FileName;
            picPreview.LoadAsync(path);
            try
            {
                var base64 = Convert.ToBase64String(File.ReadAllBytes(path));
                base64raw = base64;
                string mime = null;
                if (!mimeTypes.TryGetValue(Path.GetExtension(picPreview.ImageLocation), out mime))
                    return;
                base64prefix = $"data:image/{mime};base64,{base64}";
                base64html5 = $"<img src=\"{base64prefix}\">";

                const int maxLength = 40;
                //txtBase64html5.Text = base64html5.Substring( 0,maxLength )+"...";
                //txtBase64prefix.Text = base64prefix.Substring(0, maxLength) + "...";
                //txtBase64raw.Text = base64raw.Substring(0, maxLength) + "...";
            }
            catch
            {
                LoadImg();
            }
        }
        private void btnCopy_Click(object sender, EventArgs e) => CopyNotEmptyText(base64raw);
        private void btnCopyPrefix_Click(object sender, EventArgs e) => CopyNotEmptyText(base64prefix);
        private void btnCopyHtml5_Click(object sender, EventArgs e) => CopyNotEmptyText(base64html5);

        private static void CopyNotEmptyText(string c)
        {
            if ( !string.IsNullOrWhiteSpace( c ) )
                Clipboard.SetText( c );
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using ( var frmAbout = new FrmAbout() ) frmAbout.ShowDialog();
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using ( var frmLicense = new FrmLicense() ) frmLicense.ShowDialog();
        }
    }
}
