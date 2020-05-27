namespace Judo
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ErrorText = new System.Windows.Forms.Label();
            this.RegisterBut = new System.Windows.Forms.Label();
            this.LoginBut = new System.Windows.Forms.Button();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextPanel = new System.Windows.Forms.Panel();
            this.CloseBut = new System.Windows.Forms.Label();
            this.LoginText = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TextPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.MainPanel.Controls.Add(this.ErrorText);
            this.MainPanel.Controls.Add(this.RegisterBut);
            this.MainPanel.Controls.Add(this.LoginBut);
            this.MainPanel.Controls.Add(this.PasswordInput);
            this.MainPanel.Controls.Add(this.pictureBox2);
            this.MainPanel.Controls.Add(this.UserInput);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.TextPanel);
            resources.ApplyResources(this.MainPanel, "MainPanel");
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // ErrorText
            // 
            resources.ApplyResources(this.ErrorText, "ErrorText");
            this.ErrorText.ForeColor = System.Drawing.Color.Red;
            this.ErrorText.Name = "ErrorText";
            // 
            // RegisterBut
            // 
            resources.ApplyResources(this.RegisterBut, "RegisterBut");
            this.RegisterBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterBut.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RegisterBut.Name = "RegisterBut";
            this.RegisterBut.Click += new System.EventHandler(this.RegisterBut_Click);
            // 
            // LoginBut
            // 
            this.LoginBut.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.LoginBut, "LoginBut");
            this.LoginBut.Name = "LoginBut";
            this.LoginBut.UseVisualStyleBackColor = true;
            this.LoginBut.Click += new System.EventHandler(this.LoginBut_Click);
            // 
            // PasswordInput
            // 
            resources.ApplyResources(this.PasswordInput, "PasswordInput");
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Judo.Properties.Resources._lock;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // UserInput
            // 
            resources.ApplyResources(this.UserInput, "UserInput");
            this.UserInput.Name = "UserInput";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Judo.Properties.Resources.user;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // TextPanel
            // 
            this.TextPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(86)))));
            this.TextPanel.Controls.Add(this.CloseBut);
            this.TextPanel.Controls.Add(this.LoginText);
            resources.ApplyResources(this.TextPanel, "TextPanel");
            this.TextPanel.Name = "TextPanel";
            // 
            // CloseBut
            // 
            resources.ApplyResources(this.CloseBut, "CloseBut");
            this.CloseBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBut.ForeColor = System.Drawing.Color.White;
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // LoginText
            // 
            resources.ApplyResources(this.LoginText, "LoginText");
            this.LoginText.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginText.Name = "LoginText";
            this.LoginText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginText_MouseDown);
            this.LoginText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginText_MouseMove);
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TextPanel.ResumeLayout(false);
            this.TextPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel TextPanel;
        private System.Windows.Forms.Label LoginText;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label RegisterBut;
        private System.Windows.Forms.Button LoginBut;
        private System.Windows.Forms.Label CloseBut;
        private System.Windows.Forms.Label ErrorText;
    }
}