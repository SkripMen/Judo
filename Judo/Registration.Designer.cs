namespace Judo
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.RegPanel = new System.Windows.Forms.Panel();
            this.ErrorText2 = new System.Windows.Forms.Label();
            this.LoginBut = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.RegistrationBut = new System.Windows.Forms.Button();
            this.ErrorText = new System.Windows.Forms.Label();
            this.PasswordRepeatInput = new System.Windows.Forms.TextBox();
            this.PasRepText = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.PasText = new System.Windows.Forms.Label();
            this.LoginInput = new System.Windows.Forms.TextBox();
            this.LoginText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseBut = new System.Windows.Forms.Label();
            this.RegText = new System.Windows.Forms.Label();
            this.RegPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegPanel
            // 
            this.RegPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.RegPanel.Controls.Add(this.ErrorText2);
            this.RegPanel.Controls.Add(this.LoginBut);
            this.RegPanel.Controls.Add(this.LoginLabel);
            this.RegPanel.Controls.Add(this.RegistrationBut);
            this.RegPanel.Controls.Add(this.ErrorText);
            this.RegPanel.Controls.Add(this.PasswordRepeatInput);
            this.RegPanel.Controls.Add(this.PasRepText);
            this.RegPanel.Controls.Add(this.PasswordInput);
            this.RegPanel.Controls.Add(this.PasText);
            this.RegPanel.Controls.Add(this.LoginInput);
            this.RegPanel.Controls.Add(this.LoginText);
            this.RegPanel.Controls.Add(this.panel2);
            this.RegPanel.Location = new System.Drawing.Point(0, 0);
            this.RegPanel.Name = "RegPanel";
            this.RegPanel.Size = new System.Drawing.Size(422, 387);
            this.RegPanel.TabIndex = 0;
            this.RegPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegPanel_MouseDown);
            this.RegPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegPanel_MouseMove);
            // 
            // ErrorText2
            // 
            this.ErrorText2.AutoSize = true;
            this.ErrorText2.Font = new System.Drawing.Font("Arial", 10F);
            this.ErrorText2.ForeColor = System.Drawing.Color.Red;
            this.ErrorText2.Location = new System.Drawing.Point(131, 262);
            this.ErrorText2.Name = "ErrorText2";
            this.ErrorText2.Size = new System.Drawing.Size(209, 16);
            this.ErrorText2.TabIndex = 11;
            this.ErrorText2.Text = "Такой пользователь уже есть!";
            // 
            // LoginBut
            // 
            this.LoginBut.AutoSize = true;
            this.LoginBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBut.Font = new System.Drawing.Font("Arial", 10F);
            this.LoginBut.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LoginBut.Location = new System.Drawing.Point(241, 340);
            this.LoginBut.Name = "LoginBut";
            this.LoginBut.Size = new System.Drawing.Size(48, 16);
            this.LoginBut.TabIndex = 10;
            this.LoginBut.Text = "Войти";
            this.LoginBut.Click += new System.EventHandler(this.LoginBut_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.LoginLabel.ForeColor = System.Drawing.Color.White;
            this.LoginLabel.Location = new System.Drawing.Point(111, 340);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(130, 16);
            this.LoginLabel.TabIndex = 9;
            this.LoginLabel.Text = "Уже есть аккаунт?";
            // 
            // RegistrationBut
            // 
            this.RegistrationBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrationBut.Font = new System.Drawing.Font("Arial", 14.25F);
            this.RegistrationBut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RegistrationBut.Location = new System.Drawing.Point(88, 305);
            this.RegistrationBut.Name = "RegistrationBut";
            this.RegistrationBut.Size = new System.Drawing.Size(230, 32);
            this.RegistrationBut.TabIndex = 8;
            this.RegistrationBut.Text = "Зарегистрироваться";
            this.RegistrationBut.UseVisualStyleBackColor = true;
            this.RegistrationBut.Click += new System.EventHandler(this.RegistrationBut_Click);
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.Font = new System.Drawing.Font("Arial", 10F);
            this.ErrorText.ForeColor = System.Drawing.Color.Red;
            this.ErrorText.Location = new System.Drawing.Point(131, 262);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(158, 16);
            this.ErrorText.TabIndex = 7;
            this.ErrorText.Text = "Пароли не совпадают!";
            // 
            // PasswordRepeatInput
            // 
            this.PasswordRepeatInput.Font = new System.Drawing.Font("Arial", 10F);
            this.PasswordRepeatInput.Location = new System.Drawing.Point(114, 232);
            this.PasswordRepeatInput.Name = "PasswordRepeatInput";
            this.PasswordRepeatInput.Size = new System.Drawing.Size(263, 23);
            this.PasswordRepeatInput.TabIndex = 6;
            // 
            // PasRepText
            // 
            this.PasRepText.AutoSize = true;
            this.PasRepText.Font = new System.Drawing.Font("Arial", 10F);
            this.PasRepText.ForeColor = System.Drawing.Color.White;
            this.PasRepText.Location = new System.Drawing.Point(30, 227);
            this.PasRepText.Name = "PasRepText";
            this.PasRepText.Size = new System.Drawing.Size(78, 32);
            this.PasRepText.TabIndex = 5;
            this.PasRepText.Text = "Повторите\r\nпароль:";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Font = new System.Drawing.Font("Arial", 10F);
            this.PasswordInput.Location = new System.Drawing.Point(114, 186);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(263, 23);
            this.PasswordInput.TabIndex = 4;
            // 
            // PasText
            // 
            this.PasText.AutoSize = true;
            this.PasText.Font = new System.Drawing.Font("Arial", 10F);
            this.PasText.ForeColor = System.Drawing.Color.White;
            this.PasText.Location = new System.Drawing.Point(30, 189);
            this.PasText.Name = "PasText";
            this.PasText.Size = new System.Drawing.Size(61, 16);
            this.PasText.TabIndex = 3;
            this.PasText.Text = "Пароль:";
            // 
            // LoginInput
            // 
            this.LoginInput.Font = new System.Drawing.Font("Arial", 10F);
            this.LoginInput.Location = new System.Drawing.Point(114, 142);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(263, 23);
            this.LoginInput.TabIndex = 2;
            // 
            // LoginText
            // 
            this.LoginText.AutoSize = true;
            this.LoginText.Font = new System.Drawing.Font("Arial", 10F);
            this.LoginText.ForeColor = System.Drawing.Color.White;
            this.LoginText.Location = new System.Drawing.Point(30, 145);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(50, 16);
            this.LoginText.TabIndex = 1;
            this.LoginText.Text = "Логин:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.CloseBut);
            this.panel2.Controls.Add(this.RegText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 100);
            this.panel2.TabIndex = 0;
            // 
            // CloseBut
            // 
            this.CloseBut.AutoSize = true;
            this.CloseBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBut.Font = new System.Drawing.Font("Arial", 10.25F);
            this.CloseBut.ForeColor = System.Drawing.Color.White;
            this.CloseBut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CloseBut.Location = new System.Drawing.Point(405, 0);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(16, 16);
            this.CloseBut.TabIndex = 2;
            this.CloseBut.Text = "X";
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // RegText
            // 
            this.RegText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegText.Font = new System.Drawing.Font("Arial", 32.25F);
            this.RegText.ForeColor = System.Drawing.Color.White;
            this.RegText.Location = new System.Drawing.Point(0, 0);
            this.RegText.Name = "RegText";
            this.RegText.Size = new System.Drawing.Size(422, 100);
            this.RegText.TabIndex = 3;
            this.RegText.Text = "Регистрация";
            this.RegText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegText_MouseDown);
            this.RegText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegText_MouseMove);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 385);
            this.Controls.Add(this.RegPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(420, 385);
            this.MinimumSize = new System.Drawing.Size(420, 385);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Judo | Регистрация";
            this.RegPanel.ResumeLayout(false);
            this.RegPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RegPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label RegText;
        private System.Windows.Forms.Label CloseBut;
        private System.Windows.Forms.Label LoginText;
        private System.Windows.Forms.TextBox PasswordRepeatInput;
        private System.Windows.Forms.Label PasRepText;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label PasText;
        private System.Windows.Forms.TextBox LoginInput;
        private System.Windows.Forms.Label ErrorText;
        private System.Windows.Forms.Button RegistrationBut;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label LoginBut;
        private System.Windows.Forms.Label ErrorText2;
    }
}