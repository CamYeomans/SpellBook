namespace Spellbook
{
    partial class spellbookMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(spellbookMenu));
            this.newChar = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.loadChar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.leftpageCharacterCreate = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.leftpageCharacterCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // newChar
            // 
            this.newChar.AutoSize = true;
            this.newChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newChar.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newChar.ForeColor = System.Drawing.Color.Black;
            this.newChar.Location = new System.Drawing.Point(217, 170);
            this.newChar.Name = "newChar";
            this.newChar.Padding = new System.Windows.Forms.Padding(15);
            this.newChar.Size = new System.Drawing.Size(349, 74);
            this.newChar.TabIndex = 1;
            this.newChar.Text = "Create a new character";
            this.newChar.UseVisualStyleBackColor = true;
            this.newChar.Click += new System.EventHandler(this.newChar_Click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(211, 85);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(348, 72);
            this.title.TabIndex = 0;
            this.title.Text = "Your Spellbook";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(217, 312);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(349, 44);
            this.exit.TabIndex = 2;
            this.exit.Text = "Quit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // loadChar
            // 
            this.loadChar.AutoSize = true;
            this.loadChar.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadChar.ForeColor = System.Drawing.Color.Black;
            this.loadChar.Location = new System.Drawing.Point(217, 256);
            this.loadChar.Name = "loadChar";
            this.loadChar.Size = new System.Drawing.Size(349, 44);
            this.loadChar.TabIndex = 3;
            this.loadChar.Text = "Load a character";
            this.loadChar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.loadChar);
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.title);
            this.panel2.Controls.Add(this.newChar);
            this.panel2.Location = new System.Drawing.Point(60, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 452);
            this.panel2.TabIndex = 1;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(60, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Visible = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // leftpageCharacterCreate
            // 
            this.leftpageCharacterCreate.BackColor = System.Drawing.Color.Transparent;
            this.leftpageCharacterCreate.Controls.Add(this.label1);
            this.leftpageCharacterCreate.Location = new System.Drawing.Point(12, 12);
            this.leftpageCharacterCreate.Margin = new System.Windows.Forms.Padding(20);
            this.leftpageCharacterCreate.Name = "leftpageCharacterCreate";
            this.leftpageCharacterCreate.Size = new System.Drawing.Size(382, 431);
            this.leftpageCharacterCreate.TabIndex = 3;
            this.leftpageCharacterCreate.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick a class";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // spellbookMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Spellbook.Properties.Resources.BookClosed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 455);
            this.Controls.Add(this.leftpageCharacterCreate);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "spellbookMenu";
            this.Text = "Spellbook";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.leftpageCharacterCreate.ResumeLayout(false);
            this.leftpageCharacterCreate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newChar;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button loadChar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel leftpageCharacterCreate;
        private System.Windows.Forms.Label label1;
    }
}

