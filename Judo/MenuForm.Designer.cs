namespace Judo
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            this.ChangePas = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.PictureBox();
            this.ViewBut = new System.Windows.Forms.Button();
            this.CreateTableBut = new System.Windows.Forms.Button();
            this.MembersBut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextPanel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.MainPanel.Controls.Add(this.SettingsPanel);
            this.MainPanel.Controls.Add(this.Settings);
            this.MainPanel.Controls.Add(this.ViewBut);
            this.MainPanel.Controls.Add(this.CreateTableBut);
            this.MainPanel.Controls.Add(this.MembersBut);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Location = new System.Drawing.Point(-2, -1);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(523, 366);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(86)))));
            this.SettingsPanel.Controls.Add(this.Exit);
            this.SettingsPanel.Controls.Add(this.ChangePas);
            this.SettingsPanel.Location = new System.Drawing.Point(338, 306);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(149, 51);
            this.SettingsPanel.TabIndex = 13;
            // 
            // Exit
            // 
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Exit.Font = new System.Drawing.Font("Arial", 12.25F);
            this.Exit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Exit.Location = new System.Drawing.Point(0, 26);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(149, 25);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Выход";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ChangePas
            // 
            this.ChangePas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePas.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChangePas.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ChangePas.Location = new System.Drawing.Point(0, 0);
            this.ChangePas.Name = "ChangePas";
            this.ChangePas.Size = new System.Drawing.Size(149, 23);
            this.ChangePas.TabIndex = 0;
            this.ChangePas.Text = "Изменить пароль";
            this.ChangePas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Settings
            // 
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.Image = global::Judo.Properties.Resources.settings;
            this.Settings.Location = new System.Drawing.Point(493, 332);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(25, 25);
            this.Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Settings.TabIndex = 12;
            this.Settings.TabStop = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // ViewBut
            // 
            this.ViewBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewBut.Font = new System.Drawing.Font("Arial", 14.25F);
            this.ViewBut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ViewBut.Location = new System.Drawing.Point(140, 268);
            this.ViewBut.Name = "ViewBut";
            this.ViewBut.Size = new System.Drawing.Size(230, 32);
            this.ViewBut.TabIndex = 11;
            this.ViewBut.Text = "Просмотр таблиц";
            this.ViewBut.UseVisualStyleBackColor = true;
            // 
            // CreateTableBut
            // 
            this.CreateTableBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateTableBut.Font = new System.Drawing.Font("Arial", 14.25F);
            this.CreateTableBut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CreateTableBut.Location = new System.Drawing.Point(140, 214);
            this.CreateTableBut.Name = "CreateTableBut";
            this.CreateTableBut.Size = new System.Drawing.Size(230, 32);
            this.CreateTableBut.TabIndex = 10;
            this.CreateTableBut.Text = "Создание таблиц";
            this.CreateTableBut.UseVisualStyleBackColor = true;
            // 
            // MembersBut
            // 
            this.MembersBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MembersBut.Font = new System.Drawing.Font("Arial", 14.25F);
            this.MembersBut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MembersBut.Location = new System.Drawing.Point(140, 162);
            this.MembersBut.Name = "MembersBut";
            this.MembersBut.Size = new System.Drawing.Size(230, 32);
            this.MembersBut.TabIndex = 9;
            this.MembersBut.Text = "Участники";
            this.MembersBut.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.TextPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 100);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Arial", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(507, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Judo.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(162, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TextPanel
            // 
            this.TextPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(86)))));
            this.TextPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextPanel.Font = new System.Drawing.Font("Arial", 32.25F);
            this.TextPanel.ForeColor = System.Drawing.Color.White;
            this.TextPanel.Location = new System.Drawing.Point(0, 0);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Size = new System.Drawing.Size(523, 100);
            this.TextPanel.TabIndex = 0;
            this.TextPanel.Text = "    Judo";
            this.TextPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TextPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextPanel_MouseDown);
            this.TextPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TextPanel_MouseMove);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 360);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(521, 360);
            this.MinimumSize = new System.Drawing.Size(521, 360);
            this.Name = "MenuForm";
            this.Text = "Judo | Меню";
            this.MainPanel.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TextPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Settings;
        private System.Windows.Forms.Button ViewBut;
        private System.Windows.Forms.Button CreateTableBut;
        private System.Windows.Forms.Button MembersBut;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Label ChangePas;
        private System.Windows.Forms.Label Exit;
    }
}