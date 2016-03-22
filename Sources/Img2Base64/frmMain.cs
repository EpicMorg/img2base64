using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Img2Base64
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public string _fType;

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
            if (extension != null) _fType = extension.ToLower();
            picPreview.LoadAsync(path);
        }

        private void Convert2Base64()
        {
            try
            {
                var tmpText = File.ReadAllBytes(picPreview.ImageLocation);
                var base64 = Convert.ToBase64String(tmpText);
                txtBase64raw.Text = base64;
                //data:image/gif;base64,<...>
                //data:image/jpeg;base64,<...>
                //data:image/png;base64,<...>
                //<img src="data:image/TYPE;base64,<...>" >
                switch (_fType)
                {
                    case ".gif":
                        txtBase64prefix.Text = "data:image/gif;base64," + base64;
                        txtBase64html5.Text = "<img src=\"data:image/gif;base64," + base64 + "\">";
                        break;
                    case ".png":
                        txtBase64prefix.Text = "data:image/png;base64," + base64;
                        txtBase64html5.Text = "<img src=\"data:image/png;base64," + base64 + "\">";
                        break;
                    case ".jpg":
                        txtBase64prefix.Text = "data:image/jpeg;base64," + base64;
                        txtBase64html5.Text = "<img src=\"data:image/jpeg;base64," + base64 + "\">";
                        break;
                    case ".jpeg":
                        txtBase64prefix.Text = "data:image/jpeg;base64," + base64;
                        txtBase64html5.Text = "<img src=\"data:image/jpeg;base64," + base64 + "\">";
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
            MessageBox.Show("Pre-release version 0.0.0.1\r\nBy STAM, EpicMorg 2016");
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright EpicMorg 2016, Standart MIT License");
        }
    }
}
