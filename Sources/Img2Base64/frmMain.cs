using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Img2Base64.Properties;

namespace Img2Base64
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public string FType;
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (rbFile.Checked)
            {
                LoadImg();
            }
            else
            {
                try
                {
                    picPreview.LoadAsync(string.IsNullOrEmpty(txtUrl.Text).ToString());
                }
                catch
                {
                    LoadImg();
                }
            }
        }
        private void LoadImg()
        {
            if (imgOpen.ShowDialog() != DialogResult.OK) return;
            var path = imgOpen.FileName;
            var extension = Path.GetExtension(imgOpen.FileName);
            if (extension != null) FType = extension.ToLower();
            picPreview.LoadAsync(path);
        }

        private void Convert2Base64()
        {
            try
            {
                var tmpText = File.ReadAllBytes(picPreview.ImageLocation);
                var base64 = Convert.ToBase64String(tmpText);
                txtBase64raw.Text = base64;
                switch (FType)
                {
                    case ".gif":
                        // ReSharper disable once LocalizableElement
                        txtBase64prefix.Text = "data:image/gif;base64," + base64;
                        // ReSharper disable once LocalizableElement
                        txtBase64html5.Text = "<img src=\"data:image/gif;base64," + base64 + Resources.tag_closed;
                        break;
                    case ".png":
                        // ReSharper disable once LocalizableElement
                        txtBase64prefix.Text = "data:image/png;base64," + base64;
                        // ReSharper disable once LocalizableElement
                        txtBase64html5.Text = "<img src=\"data:image/png;base64," + base64 + Resources.tag_closed;
                        break;
                    case ".jpg":
                        // ReSharper disable once LocalizableElement
                        txtBase64prefix.Text = "data:image/jpeg;base64," + base64;
                        // ReSharper disable once LocalizableElement
                        txtBase64html5.Text = "<img src=\"data:image/jpeg;base64," + base64 + Resources.tag_closed;
                        break;
                    case ".jpeg":
                        // ReSharper disable once LocalizableElement
                        txtBase64prefix.Text = "data:image/jpeg;base64," + base64;
                        // ReSharper disable once LocalizableElement
                        txtBase64html5.Text = "<img src=\"data:image/jpeg;base64," + base64 + Resources.tag_closed;
                        break;
                }
            }
            catch
            {
                LoadImg();
            }

        }

        private void picPreview_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Convert2Base64();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBase64raw.Text) || !string.IsNullOrEmpty(txtBase64raw.Text))
            {
                Clipboard.SetText(txtBase64raw.Text);
            }
        }


        private void btnCopyPrefix_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBase64prefix.Text) || !string.IsNullOrEmpty(txtBase64prefix.Text))
            {
                Clipboard.SetText(txtBase64prefix.Text);
            }

        }

        private void btnCopyHtml5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBase64html5.Text) || !string.IsNullOrEmpty(txtBase64html5.Text))
            {
                Clipboard.SetText(txtBase64html5.Text);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmLicense = new FrmLicense();
            frmLicense.ShowDialog();
        }
    }
}
