namespace miHoYoGameDownload
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.generate = new System.Windows.Forms.Button();
            this.version_text = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.mianLink_text = new System.Windows.Forms.Label();
            this.mainLink = new System.Windows.Forms.TextBox();
            this.status_text = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.voiceLinks_text = new System.Windows.Forms.Label();
            this.voiceLinks = new System.Windows.Forms.RichTextBox();
            this.gameChooseBox = new System.Windows.Forms.ComboBox();
            this.diffsButton = new System.Windows.Forms.Button();
            this.getNextDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generate
            // 
            resources.ApplyResources(this.generate, "generate");
            this.generate.Name = "generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // version_text
            // 
            resources.ApplyResources(this.version_text, "version_text");
            this.version_text.Name = "version_text";
            // 
            // version
            // 
            resources.ApplyResources(this.version, "version");
            this.version.Name = "version";
            // 
            // mianLink_text
            // 
            resources.ApplyResources(this.mianLink_text, "mianLink_text");
            this.mianLink_text.Name = "mianLink_text";
            // 
            // mainLink
            // 
            resources.ApplyResources(this.mainLink, "mainLink");
            this.mainLink.Name = "mainLink";
            this.mainLink.ReadOnly = true;
            // 
            // status_text
            // 
            resources.ApplyResources(this.status_text, "status_text");
            this.status_text.Name = "status_text";
            // 
            // status
            // 
            resources.ApplyResources(this.status, "status");
            this.status.Name = "status";
            // 
            // voiceLinks_text
            // 
            resources.ApplyResources(this.voiceLinks_text, "voiceLinks_text");
            this.voiceLinks_text.Name = "voiceLinks_text";
            // 
            // voiceLinks
            // 
            resources.ApplyResources(this.voiceLinks, "voiceLinks");
            this.voiceLinks.Name = "voiceLinks";
            this.voiceLinks.ReadOnly = true;
            // 
            // gameChooseBox
            // 
            this.gameChooseBox.FormattingEnabled = true;
            this.gameChooseBox.Items.AddRange(new object[] {
            resources.GetString("gameChooseBox.Items"),
            resources.GetString("gameChooseBox.Items1"),
            resources.GetString("gameChooseBox.Items2"),
            resources.GetString("gameChooseBox.Items3"),
            resources.GetString("gameChooseBox.Items4"),
            resources.GetString("gameChooseBox.Items5"),
            resources.GetString("gameChooseBox.Items6")});
            resources.ApplyResources(this.gameChooseBox, "gameChooseBox");
            this.gameChooseBox.Name = "gameChooseBox";
            // 
            // diffsButton
            // 
            resources.ApplyResources(this.diffsButton, "diffsButton");
            this.diffsButton.Name = "diffsButton";
            this.diffsButton.UseVisualStyleBackColor = true;
            this.diffsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // getNextDownload
            // 
            resources.ApplyResources(this.getNextDownload, "getNextDownload");
            this.getNextDownload.Name = "getNextDownload";
            this.getNextDownload.UseVisualStyleBackColor = true;
            this.getNextDownload.Click += new System.EventHandler(this.getNextDownload_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.generate;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.getNextDownload);
            this.Controls.Add(this.diffsButton);
            this.Controls.Add(this.gameChooseBox);
            this.Controls.Add(this.voiceLinks);
            this.Controls.Add(this.voiceLinks_text);
            this.Controls.Add(this.status);
            this.Controls.Add(this.status_text);
            this.Controls.Add(this.mainLink);
            this.Controls.Add(this.mianLink_text);
            this.Controls.Add(this.version);
            this.Controls.Add(this.version_text);
            this.Controls.Add(this.generate);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label version_text;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label mianLink_text;
        private System.Windows.Forms.TextBox mainLink;
        private System.Windows.Forms.Label status_text;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label voiceLinks_text;
        private System.Windows.Forms.RichTextBox voiceLinks;
        private System.Windows.Forms.ComboBox gameChooseBox;
        private System.Windows.Forms.Button diffsButton;
        private System.Windows.Forms.Button getNextDownload;
    }
}

