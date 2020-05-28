namespace Judo
{
    partial class ChangeForm
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
            this.PasPanel = new System.Windows.Forms.Panel();
            this.ErrorText = new System.Windows.Forms.Label();
            this.BackBut = new System.Windows.Forms.Button();
            this.ChangeBut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PasNewRepBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasNewBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasOllBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextPanel = new System.Windows.Forms.Label();
            this.PasPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasPanel
            // 
            this.PasPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.PasPanel.Controls.Add(this.ErrorText);
            this.PasPanel.Controls.Add(this.BackBut);
            this.PasPanel.Controls.Add(this.ChangeBut);
            this.PasPanel.Controls.Add(this.label4);
            this.PasPanel.Controls.Add(this.PasNewRepBox);
            this.PasPanel.Controls.Add(this.label3);
            this.PasPanel.Controls.Add(this.PasNewBox);
            this.PasPanel.Controls.Add(this.label2);
            this.PasPanel.Controls.Add(this.PasOllBox);
            this.PasPanel.Controls.Add(this.panel2);
            this.PasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasPanel.Location = new System.Drawing.Point(0, 0);
            this.PasPanel.Name = "PasPanel";
            this.PasPanel.Size = new System.Drawing.Size(401, 387);
            this.PasPanel.TabIndex = 0;
            this.PasPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PasPanel_MouseDown);
            this.PasPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PasPanel_MouseMove);
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.Font = new System.Drawing.Font("Arial", 10F);
            this.ErrorText.ForeColor = System.Drawing.Color.Red;
            this.ErrorText.Location = new System.Drawing.Point(56, 298);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(153, 16);
            this.ErrorText.TabIndex = 9;
            this.ErrorText.Text = "Пароли не совпадают";
            this.ErrorText.Visible = false;
            // 
            // BackBut
            // 
            this.BackBut.Font = new System.Drawing.Font("Arial", 14.25F);
            this.BackBut.Location = new System.Drawing.Point(202, 328);
            this.BackBut.Name = "BackBut";
            this.BackBut.Size = new System.Drawing.Size(140, 30);
            this.BackBut.TabIndex = 8;
            this.BackBut.Text = "Отмена";
            this.BackBut.UseVisualStyleBackColor = true;
            this.BackBut.Click += new System.EventHandler(this.BackBut_Click);
            // 
            // ChangeBut
            // 
            this.ChangeBut.Font = new System.Drawing.Font("Arial", 14.25F);
            this.ChangeBut.Location = new System.Drawing.Point(55, 328);
            this.ChangeBut.Name = "ChangeBut";
            this.ChangeBut.Size = new System.Drawing.Size(140, 30);
            this.ChangeBut.TabIndex = 7;
            this.ChangeBut.Text = "Изменить";
            this.ChangeBut.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Повторите пароль";
            // 
            // PasNewRepBox
            // 
            this.PasNewRepBox.Font = new System.Drawing.Font("Arial", 16.25F);
            this.PasNewRepBox.ForeColor = System.Drawing.Color.White;
            this.PasNewRepBox.Location = new System.Drawing.Point(55, 259);
            this.PasNewRepBox.Name = "PasNewRepBox";
            this.PasNewRepBox.Size = new System.Drawing.Size(287, 32);
            this.PasNewRepBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Новый пароль";
            // 
            // PasNewBox
            // 
            this.PasNewBox.Font = new System.Drawing.Font("Arial", 16.25F);
            this.PasNewBox.ForeColor = System.Drawing.Color.White;
            this.PasNewBox.Location = new System.Drawing.Point(55, 203);
            this.PasNewBox.Name = "PasNewBox";
            this.PasNewBox.Size = new System.Drawing.Size(287, 32);
            this.PasNewBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Старый пароль";
            // 
            // PasOllBox
            // 
            this.PasOllBox.Font = new System.Drawing.Font("Arial", 16.25F);
            this.PasOllBox.ForeColor = System.Drawing.Color.White;
            this.PasOllBox.Location = new System.Drawing.Point(55, 147);
            this.PasOllBox.Name = "PasOllBox";
            this.PasOllBox.Size = new System.Drawing.Size(287, 32);
            this.PasOllBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.TextPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 100);
            this.panel2.TabIndex = 0;
            // 
            // TextPanel
            // 
            this.TextPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextPanel.Font = new System.Drawing.Font("Arial", 32.25F);
            this.TextPanel.ForeColor = System.Drawing.Color.White;
            this.TextPanel.Location = new System.Drawing.Point(0, 0);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Size = new System.Drawing.Size(401, 100);
            this.TextPanel.TabIndex = 0;
            this.TextPanel.Text = "Изменение пароля";
            this.TextPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TextPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextPanel_MouseDown);
            this.TextPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TextPanel_MouseMove);
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 387);
            this.Controls.Add(this.PasPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeForm";
            this.PasPanel.ResumeLayout(false);
            this.PasPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PasPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TextPanel;
        private System.Windows.Forms.TextBox PasOllBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasNewRepBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasNewBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BackBut;
        private System.Windows.Forms.Button ChangeBut;
        private System.Windows.Forms.Label ErrorText;
    }
}