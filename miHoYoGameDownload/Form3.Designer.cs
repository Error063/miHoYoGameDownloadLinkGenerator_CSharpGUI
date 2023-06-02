namespace miHoYoGameDownload
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameName = new System.Windows.Forms.Label();
            this.preDownloadVersion = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.voiceLinks = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mainLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.diffPackageLink_voices = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.diffPackageLink_main = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.versions_choice = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameName
            // 
            this.gameName.AutoSize = true;
            this.gameName.Location = new System.Drawing.Point(39, 32);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(98, 21);
            this.gameName.TabIndex = 0;
            this.gameName.Text = "gameName";
            // 
            // preDownloadVersion
            // 
            this.preDownloadVersion.AutoSize = true;
            this.preDownloadVersion.Location = new System.Drawing.Point(441, 32);
            this.preDownloadVersion.Name = "preDownloadVersion";
            this.preDownloadVersion.Size = new System.Drawing.Size(136, 21);
            this.preDownloadVersion.TabIndex = 1;
            this.preDownloadVersion.Text = "预更新版本：";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(583, 32);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(65, 21);
            this.version.TabIndex = 2;
            this.version.Text = "0.0.0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.voiceLinks);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mainLink);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 689);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "完整包";
            // 
            // voiceLinks
            // 
            this.voiceLinks.Location = new System.Drawing.Point(29, 177);
            this.voiceLinks.Name = "voiceLinks";
            this.voiceLinks.ReadOnly = true;
            this.voiceLinks.Size = new System.Drawing.Size(593, 483);
            this.voiceLinks.TabIndex = 3;
            this.voiceLinks.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "语音包链接";
            // 
            // mainLink
            // 
            this.mainLink.Location = new System.Drawing.Point(26, 83);
            this.mainLink.Name = "mainLink";
            this.mainLink.ReadOnly = true;
            this.mainLink.Size = new System.Drawing.Size(596, 31);
            this.mainLink.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "游戏本体文件链接：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.diffPackageLink_voices);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.diffPackageLink_main);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.versions_choice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(723, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 747);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "差分包";
            // 
            // diffPackageLink_voices
            // 
            this.diffPackageLink_voices.Location = new System.Drawing.Point(40, 236);
            this.diffPackageLink_voices.Name = "diffPackageLink_voices";
            this.diffPackageLink_voices.ReadOnly = true;
            this.diffPackageLink_voices.Size = new System.Drawing.Size(578, 482);
            this.diffPackageLink_voices.TabIndex = 7;
            this.diffPackageLink_voices.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "语音包差分更新链接：";
            // 
            // diffPackageLink_main
            // 
            this.diffPackageLink_main.Location = new System.Drawing.Point(37, 136);
            this.diffPackageLink_main.Name = "diffPackageLink_main";
            this.diffPackageLink_main.ReadOnly = true;
            this.diffPackageLink_main.Size = new System.Drawing.Size(582, 31);
            this.diffPackageLink_main.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "差分包本体链接：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "更新";
            // 
            // versions_choice
            // 
            this.versions_choice.FormattingEnabled = true;
            this.versions_choice.Location = new System.Drawing.Point(70, 48);
            this.versions_choice.Name = "versions_choice";
            this.versions_choice.Size = new System.Drawing.Size(121, 29);
            this.versions_choice.TabIndex = 1;
            this.versions_choice.SelectedIndexChanged += new System.EventHandler(this.versions_choice_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "从";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 804);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.version);
            this.Controls.Add(this.preDownloadVersion);
            this.Controls.Add(this.gameName);
            this.Name = "Form3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "预更新";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.Label preDownloadVersion;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox mainLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox voiceLinks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox versions_choice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox diffPackageLink_main;
        private System.Windows.Forms.RichTextBox diffPackageLink_voices;
        private System.Windows.Forms.Label label6;
    }
}