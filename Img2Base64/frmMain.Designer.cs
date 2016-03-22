namespace Img2Base64
{
    partial class FrmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.imgOpen = new System.Windows.Forms.OpenFileDialog();
            this.groupboxBase64 = new System.Windows.Forms.GroupBox();
            this.txtBase64raw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBase64html5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBase64prefix = new System.Windows.Forms.TextBox();
            this.btnCopyHtml5 = new System.Windows.Forms.Button();
            this.btnCopyPrefix = new System.Windows.Forms.Button();
            this.btnCopyRaw = new System.Windows.Forms.Button();
            this.rbFile = new System.Windows.Forms.RadioButton();
            this.rbUrl = new System.Windows.Forms.RadioButton();
            this.txtUrl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.groupboxBase64.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPreview
            // 
            this.picPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Location = new System.Drawing.Point(12, 12);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(440, 237);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            this.picPreview.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.picPreview_LoadCompleted);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoad.Location = new System.Drawing.Point(12, 255);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(101, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "&Load ";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // imgOpen
            // 
            this.imgOpen.Filter = "PNG Image|*.png|GIF Animation|*.gif|JPEG Image|*.jpg|JPEG Image|*.jpeg";
            this.imgOpen.RestoreDirectory = true;
            // 
            // groupboxBase64
            // 
            this.groupboxBase64.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupboxBase64.Controls.Add(this.txtBase64raw);
            this.groupboxBase64.Controls.Add(this.label3);
            this.groupboxBase64.Controls.Add(this.label2);
            this.groupboxBase64.Controls.Add(this.txtBase64html5);
            this.groupboxBase64.Controls.Add(this.label1);
            this.groupboxBase64.Controls.Add(this.txtBase64prefix);
            this.groupboxBase64.Controls.Add(this.btnCopyHtml5);
            this.groupboxBase64.Controls.Add(this.btnCopyPrefix);
            this.groupboxBase64.Controls.Add(this.btnCopyRaw);
            this.groupboxBase64.Location = new System.Drawing.Point(12, 284);
            this.groupboxBase64.Name = "groupboxBase64";
            this.groupboxBase64.Size = new System.Drawing.Size(440, 145);
            this.groupboxBase64.TabIndex = 2;
            this.groupboxBase64.TabStop = false;
            this.groupboxBase64.Text = "Base64:";
            // 
            // txtBase64raw
            // 
            this.txtBase64raw.Location = new System.Drawing.Point(6, 32);
            this.txtBase64raw.Name = "txtBase64raw";
            this.txtBase64raw.ReadOnly = true;
            this.txtBase64raw.Size = new System.Drawing.Size(321, 20);
            this.txtBase64raw.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "&HTML5:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "With &Prefix:";
            // 
            // txtBase64html5
            // 
            this.txtBase64html5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBase64html5.Location = new System.Drawing.Point(6, 110);
            this.txtBase64html5.Name = "txtBase64html5";
            this.txtBase64html5.ReadOnly = true;
            this.txtBase64html5.Size = new System.Drawing.Size(321, 20);
            this.txtBase64html5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RAW:";
            // 
            // txtBase64prefix
            // 
            this.txtBase64prefix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBase64prefix.Location = new System.Drawing.Point(6, 71);
            this.txtBase64prefix.Name = "txtBase64prefix";
            this.txtBase64prefix.ReadOnly = true;
            this.txtBase64prefix.Size = new System.Drawing.Size(321, 20);
            this.txtBase64prefix.TabIndex = 0;
            // 
            // btnCopyHtml5
            // 
            this.btnCopyHtml5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyHtml5.Location = new System.Drawing.Point(333, 108);
            this.btnCopyHtml5.Name = "btnCopyHtml5";
            this.btnCopyHtml5.Size = new System.Drawing.Size(101, 23);
            this.btnCopyHtml5.TabIndex = 1;
            this.btnCopyHtml5.Text = "Copy";
            this.btnCopyHtml5.UseVisualStyleBackColor = true;
            this.btnCopyHtml5.Click += new System.EventHandler(this.btnCopyHtml5_Click);
            // 
            // btnCopyPrefix
            // 
            this.btnCopyPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyPrefix.Location = new System.Drawing.Point(333, 69);
            this.btnCopyPrefix.Name = "btnCopyPrefix";
            this.btnCopyPrefix.Size = new System.Drawing.Size(101, 23);
            this.btnCopyPrefix.TabIndex = 1;
            this.btnCopyPrefix.Text = "Copy";
            this.btnCopyPrefix.UseVisualStyleBackColor = true;
            this.btnCopyPrefix.Click += new System.EventHandler(this.btnCopyPrefix_Click);
            // 
            // btnCopyRaw
            // 
            this.btnCopyRaw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyRaw.Location = new System.Drawing.Point(333, 30);
            this.btnCopyRaw.Name = "btnCopyRaw";
            this.btnCopyRaw.Size = new System.Drawing.Size(101, 23);
            this.btnCopyRaw.TabIndex = 1;
            this.btnCopyRaw.Text = "Copy";
            this.btnCopyRaw.UseVisualStyleBackColor = true;
            this.btnCopyRaw.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // rbFile
            // 
            this.rbFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbFile.AutoSize = true;
            this.rbFile.Checked = true;
            this.rbFile.Location = new System.Drawing.Point(119, 258);
            this.rbFile.Name = "rbFile";
            this.rbFile.Size = new System.Drawing.Size(41, 17);
            this.rbFile.TabIndex = 3;
            this.rbFile.TabStop = true;
            this.rbFile.Text = "File";
            this.rbFile.UseVisualStyleBackColor = true;
            // 
            // rbUrl
            // 
            this.rbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbUrl.AutoSize = true;
            this.rbUrl.Location = new System.Drawing.Point(166, 258);
            this.rbUrl.Name = "rbUrl";
            this.rbUrl.Size = new System.Drawing.Size(50, 17);
            this.rbUrl.TabIndex = 3;
            this.rbUrl.Text = "URL:";
            this.rbUrl.UseVisualStyleBackColor = true;
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(222, 257);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(230, 20);
            this.txtUrl.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.rbUrl);
            this.Controls.Add(this.rbFile);
            this.Controls.Add(this.groupboxBase64);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(480, 480);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "img2Base64 converter by stam";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.groupboxBase64.ResumeLayout(false);
            this.groupboxBase64.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog imgOpen;
        private System.Windows.Forms.GroupBox groupboxBase64;
        private System.Windows.Forms.Button btnCopyRaw;
        private System.Windows.Forms.RadioButton rbFile;
        private System.Windows.Forms.RadioButton rbUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBase64html5;
        private System.Windows.Forms.TextBox txtBase64prefix;
        private System.Windows.Forms.Button btnCopyHtml5;
        private System.Windows.Forms.Button btnCopyPrefix;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtBase64raw;
    }
}

