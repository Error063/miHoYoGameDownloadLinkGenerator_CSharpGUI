namespace miHoYoGameDownload
{
    partial class Form2
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
            this.from = new System.Windows.Forms.Label();
            this.gameVersion_now = new System.Windows.Forms.Label();
            this.updateTo = new System.Windows.Forms.Label();
            this.versions_choice = new System.Windows.Forms.ComboBox();
            this.gameName_show = new System.Windows.Forms.Label();
            this.lookupButton = new System.Windows.Forms.Button();
            this.diffPackageLink_main_text = new System.Windows.Forms.Label();
            this.diffPackageLink_main = new System.Windows.Forms.TextBox();
            this.diffPackageLink_voices_text = new System.Windows.Forms.Label();
            this.diffPackageLink_voices = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Location = new System.Drawing.Point(502, 42);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(31, 21);
            this.from.TabIndex = 0;
            this.from.Text = "从";
            // 
            // gameVersion_now
            // 
            this.gameVersion_now.AutoSize = true;
            this.gameVersion_now.Location = new System.Drawing.Point(746, 42);
            this.gameVersion_now.Name = "gameVersion_now";
            this.gameVersion_now.Size = new System.Drawing.Size(65, 21);
            this.gameVersion_now.TabIndex = 1;
            this.gameVersion_now.Text = "0.0.0";
            // 
            // updateTo
            // 
            this.updateTo.AutoSize = true;
            this.updateTo.Location = new System.Drawing.Point(667, 42);
            this.updateTo.Name = "updateTo";
            this.updateTo.Size = new System.Drawing.Size(73, 21);
            this.updateTo.TabIndex = 2;
            this.updateTo.Text = "更新到";
            // 
            // versions_choice
            // 
            this.versions_choice.FormattingEnabled = true;
            this.versions_choice.Location = new System.Drawing.Point(550, 39);
            this.versions_choice.Name = "versions_choice";
            this.versions_choice.Size = new System.Drawing.Size(100, 29);
            this.versions_choice.TabIndex = 3;
            // 
            // gameName_show
            // 
            this.gameName_show.AutoSize = true;
            this.gameName_show.Location = new System.Drawing.Point(42, 42);
            this.gameName_show.Name = "gameName_show";
            this.gameName_show.Size = new System.Drawing.Size(98, 21);
            this.gameName_show.TabIndex = 4;
            this.gameName_show.Text = "gameName";
            // 
            // lookupButton
            // 
            this.lookupButton.Location = new System.Drawing.Point(864, 28);
            this.lookupButton.Name = "lookupButton";
            this.lookupButton.Size = new System.Drawing.Size(211, 85);
            this.lookupButton.TabIndex = 5;
            this.lookupButton.Text = "查询";
            this.lookupButton.UseVisualStyleBackColor = true;
            this.lookupButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // diffPackageLink_main_text
            // 
            this.diffPackageLink_main_text.AutoSize = true;
            this.diffPackageLink_main_text.Location = new System.Drawing.Point(35, 111);
            this.diffPackageLink_main_text.Name = "diffPackageLink_main_text";
            this.diffPackageLink_main_text.Size = new System.Drawing.Size(178, 21);
            this.diffPackageLink_main_text.TabIndex = 6;
            this.diffPackageLink_main_text.Text = "差分包本体链接：";
            // 
            // diffPackageLink_main
            // 
            this.diffPackageLink_main.Location = new System.Drawing.Point(39, 148);
            this.diffPackageLink_main.Name = "diffPackageLink_main";
            this.diffPackageLink_main.ReadOnly = true;
            this.diffPackageLink_main.Size = new System.Drawing.Size(1059, 31);
            this.diffPackageLink_main.TabIndex = 7;
            // 
            // diffPackageLink_voices_text
            // 
            this.diffPackageLink_voices_text.AutoSize = true;
            this.diffPackageLink_voices_text.Location = new System.Drawing.Point(35, 196);
            this.diffPackageLink_voices_text.Name = "diffPackageLink_voices_text";
            this.diffPackageLink_voices_text.Size = new System.Drawing.Size(220, 21);
            this.diffPackageLink_voices_text.TabIndex = 8;
            this.diffPackageLink_voices_text.Text = "语音包差分更新链接：";
            // 
            // diffPackageLink_voices
            // 
            this.diffPackageLink_voices.Location = new System.Drawing.Point(39, 233);
            this.diffPackageLink_voices.Name = "diffPackageLink_voices";
            this.diffPackageLink_voices.ReadOnly = true;
            this.diffPackageLink_voices.Size = new System.Drawing.Size(1059, 401);
            this.diffPackageLink_voices.TabIndex = 9;
            this.diffPackageLink_voices.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1140, 665);
            this.Controls.Add(this.diffPackageLink_voices);
            this.Controls.Add(this.diffPackageLink_voices_text);
            this.Controls.Add(this.diffPackageLink_main);
            this.Controls.Add(this.diffPackageLink_main_text);
            this.Controls.Add(this.lookupButton);
            this.Controls.Add(this.gameName_show);
            this.Controls.Add(this.versions_choice);
            this.Controls.Add(this.updateTo);
            this.Controls.Add(this.gameVersion_now);
            this.Controls.Add(this.from);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "差分包";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label from;
        private System.Windows.Forms.Label gameVersion_now;
        private System.Windows.Forms.Label updateTo;
        private System.Windows.Forms.ComboBox versions_choice;
        private System.Windows.Forms.Label gameName_show;
        private System.Windows.Forms.Button lookupButton;
        private System.Windows.Forms.Label diffPackageLink_main_text;
        private System.Windows.Forms.TextBox diffPackageLink_main;
        private System.Windows.Forms.Label diffPackageLink_voices_text;
        private System.Windows.Forms.RichTextBox diffPackageLink_voices;
    }
}