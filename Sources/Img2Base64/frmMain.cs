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
            _fType = Path.GetExtension(imgOpen.FileName);
            picPreview.LoadAsync(path);
            
        }

        private void Convert2Base64()
        {
            try
            {
                var tmpText = File.ReadAllBytes(picPreview.ImageLocation);
                var base64 = Convert.ToBase64String(tmpText);
                txtBase64raw.Text = base64;
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
        //data:image/gif;base64,<...>
        //data:image/jpeg;base64,<...>
        //data:image/png;base64,<...>
        //<img src="data:image/TYPE;base64,<...>" >
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
    }
}
