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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.imgOpen = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.rbUrl = new System.Windows.Forms.RadioButton();
            this.rbFile = new System.Windows.Forms.RadioButton();
            this.groupboxBase64 = new System.Windows.Forms.GroupBox();
            this.txtBase64html5 = new System.Windows.Forms.TextBox();
            this.txtBase64prefix = new System.Windows.Forms.TextBox();
            this.txtBase64raw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopyHtml5 = new System.Windows.Forms.Button();
            this.btnCopyPrefix = new System.Windows.Forms.Button();
            this.btnCopyRaw = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.groupboxBase64.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgOpen
            // 
            this.imgOpen.Filter = "PNG Image|*.png|GIF Animation|*.gif|JPEG Image|*.jpg|JPEG Image|*.jpeg";
            this.imgOpen.RestoreDirectory = true;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip.Size = new System.Drawing.Size(464, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenseToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.licenseToolStripMenuItem.Text = "License";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.licenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.picPreview);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtUrl);
            this.splitContainer1.Panel2.Controls.Add(this.rbUrl);
            this.splitContainer1.Panel2.Controls.Add(this.rbFile);
            this.splitContainer1.Panel2.Controls.Add(this.groupboxBase64);
            this.splitContainer1.Panel2.Controls.Add(this.btnLoad);
            this.splitContainer1.Size = new System.Drawing.Size(464, 417);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 15;
            // 
            // picPreview
            // 
            this.picPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPreview.Location = new System.Drawing.Point(0, 0);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(462, 208);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            this.picPreview.WaitOnLoad = true;
            this.picPreview.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.picPreview_LoadCompleted);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(221, 17);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.ReadOnly = true;
            this.txtUrl.Size = new System.Drawing.Size(230, 20);
            this.txtUrl.TabIndex = 24;
            this.txtUrl.Text = "This feature is not work propertly yet.. sorry!";
            // 
            // rbUrl
            // 
            this.rbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbUrl.AutoSize = true;
            this.rbUrl.Location = new System.Drawing.Point(165, 18);
            this.rbUrl.Name = "rbUrl";
            this.rbUrl.Size = new System.Drawing.Size(50, 17);
            this.rbUrl.TabIndex = 22;
            this.rbUrl.Text = "URL:";
            this.rbUrl.UseVisualStyleBackColor = true;
            // 
            // rbFile
            // 
            this.rbFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbFile.AutoSize = true;
            this.rbFile.Checked = true;
            this.rbFile.Location = new System.Drawing.Point(118, 18);
            this.rbFile.Name = "rbFile";
            this.rbFile.Size = new System.Drawing.Size(41, 17);
            this.rbFile.TabIndex = 23;
            this.rbFile.TabStop = true;
            this.rbFile.Text = "File";
            this.rbFile.UseVisualStyleBackColor = true;
            // 
            // groupboxBase64
            // 
            this.groupboxBase64.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupboxBase64.Controls.Add(this.txtBase64html5);
            this.groupboxBase64.Controls.Add(this.txtBase64prefix);
            this.groupboxBase64.Controls.Add(this.txtBase64raw);
            this.groupboxBase64.Controls.Add(this.label3);
            this.groupboxBase64.Controls.Add(this.label2);
            this.groupboxBase64.Controls.Add(this.label1);
            this.groupboxBase64.Controls.Add(this.btnCopyHtml5);
            this.groupboxBase64.Controls.Add(this.btnCopyPrefix);
            this.groupboxBase64.Controls.Add(this.btnCopyRaw);
            this.groupboxBase64.Location = new System.Drawing.Point(11, 44);
            this.groupboxBase64.Name = "groupboxBase64";
            this.groupboxBase64.Size = new System.Drawing.Size(440, 145);
            this.groupboxBase64.TabIndex = 21;
            this.groupboxBase64.TabStop = false;
            this.groupboxBase64.Text = "Base64:";
            // 
            // txtBase64html5
            // 
            this.txtBase64html5.Location = new System.Drawing.Point(6, 110);
            this.txtBase64html5.Name = "txtBase64html5";
            this.txtBase64html5.ReadOnly = true;
            this.txtBase64html5.Size = new System.Drawing.Size(321, 20);
            this.txtBase64html5.TabIndex = 4;
            // 
            // txtBase64prefix
            // 
            this.txtBase64prefix.Location = new System.Drawing.Point(6, 71);
            this.txtBase64prefix.Name = "txtBase64prefix";
            this.txtBase64prefix.ReadOnly = true;
            this.txtBase64prefix.Size = new System.Drawing.Size(321, 20);
            this.txtBase64prefix.TabIndex = 3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RAW:";
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
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoad.Location = new System.Drawing.Point(11, 15);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(101, 23);
            this.btnLoad.TabIndex = 20;
            this.btnLoad.Text = "&Load ";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(480, 480);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Img2Base64";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.groupboxBase64.ResumeLayout(false);
            this.groupboxBase64.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog imgOpen;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.RadioButton rbUrl;
        private System.Windows.Forms.RadioButton rbFile;
        private System.Windows.Forms.GroupBox groupboxBase64;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCopyHtml5;
        private System.Windows.Forms.Button btnCopyPrefix;
        private System.Windows.Forms.Button btnCopyRaw;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtBase64raw;
        private System.Windows.Forms.TextBox txtBase64html5;
        private System.Windows.Forms.TextBox txtBase64prefix;
    }
}

