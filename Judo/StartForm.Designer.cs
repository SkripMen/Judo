namespace Judo
{
    partial class StartForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBut = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.ErrorText = new System.Windows.Forms.Label();
            this.RegisterBut = new System.Windows.Forms.Label();
            this.LoginBut = new System.Windows.Forms.Button();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ErrorText3 = new System.Windows.Forms.Label();
            this.LoginButt = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.RegistrationBut = new System.Windows.Forms.Button();
            this.ErrorText2 = new System.Windows.Forms.Label();
            this.PasswordRepeatInput = new System.Windows.Forms.TextBox();
            this.PasRepText = new System.Windows.Forms.Label();
            this.PasInput = new System.Windows.Forms.TextBox();
            this.PasText = new System.Windows.Forms.Label();
            this.LoginInput = new System.Windows.Forms.TextBox();
            this.LoginText = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).BeginInit();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.CloseBut);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 100);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // CloseBut
            // 
            this.CloseBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBut.Image = global::Judo.Properties.Resources.close;
            this.CloseBut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CloseBut.Location = new System.Drawing.Point(400, 0);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(20, 20);
            this.CloseBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBut.TabIndex = 3;
            this.CloseBut.TabStop = false;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial", 32.25F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(70, 26);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(281, 49);
            this.Title.TabIndex = 0;
            this.Title.Text = "Авторизация";
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.LoginPanel.Controls.Add(this.ErrorText);
            this.LoginPanel.Controls.Add(this.RegisterBut);
            this.LoginPanel.Controls.Add(this.LoginBut);
            this.LoginPanel.Controls.Add(this.PasswordInput);
            this.LoginPanel.Controls.Add(this.pictureBox2);
            this.LoginPanel.Controls.Add(this.UserInput);
            this.LoginPanel.Controls.Add(this.pictureBox1);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoginPanel.Location = new System.Drawing.Point(0, 100);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(420, 340);
            this.LoginPanel.TabIndex = 1;
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.Font = new System.Drawing.Font("Arial", 10F);
            this.ErrorText.ForeColor = System.Drawing.Color.Red;
            this.ErrorText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ErrorText.Location = new System.Drawing.Point(112, 193);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(195, 16);
            this.ErrorText.TabIndex = 14;
            this.ErrorText.Text = "Неверный логин или пароль";
            this.ErrorText.Visible = false;
            // 
            // RegisterBut
            // 
            this.RegisterBut.AutoSize = true;
            this.RegisterBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterBut.Font = new System.Drawing.Font("Arial", 10F);
            this.RegisterBut.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RegisterBut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RegisterBut.Location = new System.Drawing.Point(140, 279);
            this.RegisterBut.Name = "RegisterBut";
            this.RegisterBut.Size = new System.Drawing.Size(144, 16);
            this.RegisterBut.TabIndex = 13;
            this.RegisterBut.Text = "Зарегистрироваться";
            this.RegisterBut.Click += new System.EventHandler(this.RegisterBut_Click);
            // 
            // LoginBut
            // 
            this.LoginBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBut.Font = new System.Drawing.Font("Arial", 14.25F);
            this.LoginBut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LoginBut.Location = new System.Drawing.Point(96, 244);
            this.LoginBut.Name = "LoginBut";
            this.LoginBut.Size = new System.Drawing.Size(230, 32);
            this.LoginBut.TabIndex = 12;
            this.LoginBut.Text = "Войти";
            this.LoginBut.UseVisualStyleBackColor = true;
            this.LoginBut.Click += new System.EventHandler(this.LoginBut_Click);
            // 
            // PasswordInput
            // 
            this.PasswordInput.Font = new System.Drawing.Font("Arial", 16.25F);
            this.PasswordInput.Location = new System.Drawing.Point(112, 158);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(267, 32);
            this.PasswordInput.TabIndex = 11;
            this.PasswordInput.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Judo.Properties.Resources._lock;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(42, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // UserInput
            // 
            this.UserInput.Font = new System.Drawing.Font("Arial", 16.25F);
            this.UserInput.Location = new System.Drawing.Point(112, 63);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(267, 32);
            this.UserInput.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Judo.Properties.Resources.user;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(42, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.ErrorText3);
            this.panel2.Controls.Add(this.LoginButt);
            this.panel2.Controls.Add(this.LoginLabel);
            this.panel2.Controls.Add(this.RegistrationBut);
            this.panel2.Controls.Add(this.ErrorText2);
            this.panel2.Controls.Add(this.PasswordRepeatInput);
            this.panel2.Controls.Add(this.PasRepText);
            this.panel2.Controls.Add(this.PasInput);
            this.panel2.Controls.Add(this.PasText);
            this.panel2.Controls.Add(this.LoginInput);
            this.panel2.Controls.Add(this.LoginText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(420, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 340);
            this.panel2.TabIndex = 2;
            // 
            // ErrorText3
            // 
            this.ErrorText3.AutoSize = true;
            this.ErrorText3.Font = new System.Drawing.Font("Arial", 10F);
            this.ErrorText3.ForeColor = System.Drawing.Color.Red;
            this.ErrorText3.Location = new System.Drawing.Point(133, 184);
            this.ErrorText3.Name = "ErrorText3";
            this.ErrorText3.Size = new System.Drawing.Size(209, 16);
            this.ErrorText3.TabIndex = 22;
            this.ErrorText3.Text = "Такой пользователь уже есть!";
            // 
            // LoginButt
            // 
            this.LoginButt.AutoSize = true;
            this.LoginButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButt.Font = new System.Drawing.Font("Arial", 10F);
            this.LoginButt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LoginButt.Location = new System.Drawing.Point(243, 261);
            this.LoginButt.Name = "LoginButt";
            this.LoginButt.Size = new System.Drawing.Size(48, 16);
            this.LoginButt.TabIndex = 21;
            this.LoginButt.Text = "Войти";
            this.LoginButt.Click += new System.EventHandler(this.LoginButt_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.LoginLabel.ForeColor = System.Drawing.Color.White;
            this.LoginLabel.Location = new System.Drawing.Point(113, 261);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(130, 16);
            this.LoginLabel.TabIndex = 20;
            this.LoginLabel.Text = "Уже есть аккаунт?";
            // 
            // RegistrationBut
            // 
            this.RegistrationBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrationBut.Font = new System.Drawing.Font("Arial", 14.25F);
            this.RegistrationBut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RegistrationBut.Location = new System.Drawing.Point(90, 226);
            this.RegistrationBut.Name = "RegistrationBut";
            this.RegistrationBut.Size = new System.Drawing.Size(230, 32);
            this.RegistrationBut.TabIndex = 19;
            this.RegistrationBut.Text = "Зарегистрироваться";
            this.RegistrationBut.UseVisualStyleBackColor = true;
            this.RegistrationBut.Click += new System.EventHandler(this.RegistrationBut_Click);
            // 
            // ErrorText2
            // 
            this.ErrorText2.AutoSize = true;
            this.ErrorText2.Font = new System.Drawing.Font("Arial", 10F);
            this.ErrorText2.ForeColor = System.Drawing.Color.Red;
            this.ErrorText2.Location = new System.Drawing.Point(133, 183);
            this.ErrorText2.Name = "ErrorText2";
            this.ErrorText2.Size = new System.Drawing.Size(158, 16);
            this.ErrorText2.TabIndex = 18;
            this.ErrorText2.Text = "Пароли не совпадают!";
            // 
            // PasswordRepeatInput
            // 
            this.PasswordRepeatInput.Font = new System.Drawing.Font("Arial", 10F);
            this.PasswordRepeatInput.Location = new System.Drawing.Point(116, 153);
            this.PasswordRepeatInput.Name = "PasswordRepeatInput";
            this.PasswordRepeatInput.Size = new System.Drawing.Size(263, 23);
            this.PasswordRepeatInput.TabIndex = 17;
            // 
            // PasRepText
            // 
            this.PasRepText.AutoSize = true;
            this.PasRepText.Font = new System.Drawing.Font("Arial", 10F);
            this.PasRepText.ForeColor = System.Drawing.Color.White;
            this.PasRepText.Location = new System.Drawing.Point(32, 148);
            this.PasRepText.Name = "PasRepText";
            this.PasRepText.Size = new System.Drawing.Size(78, 32);
            this.PasRepText.TabIndex = 16;
            this.PasRepText.Text = "Повторите\r\nпароль:";
            // 
            // PasInput
            // 
            this.PasInput.Font = new System.Drawing.Font("Arial", 10F);
            this.PasInput.Location = new System.Drawing.Point(116, 107);
            this.PasInput.Name = "PasInput";
            this.PasInput.Size = new System.Drawing.Size(263, 23);
            this.PasInput.TabIndex = 15;
            // 
            // PasText
            // 
            this.PasText.AutoSize = true;
            this.PasText.Font = new System.Drawing.Font("Arial", 10F);
            this.PasText.ForeColor = System.Drawing.Color.White;
            this.PasText.Location = new System.Drawing.Point(32, 110);
            this.PasText.Name = "PasText";
            this.PasText.Size = new System.Drawing.Size(61, 16);
            this.PasText.TabIndex = 14;
            this.PasText.Text = "Пароль:";
            // 
            // LoginInput
            // 
            this.LoginInput.Font = new System.Drawing.Font("Arial", 10F);
            this.LoginInput.Location = new System.Drawing.Point(116, 63);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(263, 23);
            this.LoginInput.TabIndex = 13;
            // 
            // LoginText
            // 
            this.LoginText.AutoSize = true;
            this.LoginText.Font = new System.Drawing.Font("Arial", 10F);
            this.LoginText.ForeColor = System.Drawing.Color.White;
            this.LoginText.Location = new System.Drawing.Point(32, 66);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(50, 16);
            this.LoginText.TabIndex = 12;
            this.LoginText.Text = "Логин:";
            // 
            // timer
            // 
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 440);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(420, 440);
            this.MinimumSize = new System.Drawing.Size(420, 440);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Judo | Авторизация";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox CloseBut;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ErrorText;
        private System.Windows.Forms.Label RegisterBut;
        private System.Windows.Forms.Button LoginBut;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ErrorText3;
        private System.Windows.Forms.Label LoginButt;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button RegistrationBut;
        private System.Windows.Forms.Label ErrorText2;
        private System.Windows.Forms.TextBox PasswordRepeatInput;
        private System.Windows.Forms.Label PasRepText;
        private System.Windows.Forms.TextBox PasInput;
        private System.Windows.Forms.Label PasText;
        private System.Windows.Forms.TextBox LoginInput;
        private System.Windows.Forms.Label LoginText;
        private System.Windows.Forms.Timer timer;
    }
}