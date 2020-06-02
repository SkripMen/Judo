namespace Judo
{
    partial class MembersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembersForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BackBut = new System.Windows.Forms.Button();
            this.ImportBut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SearchBut = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.TextPanel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Имя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фамилия = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Год = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Клуб = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Место_проживания = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Вес = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BackBut);
            this.panel1.Controls.Add(this.ImportBut);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 555);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(276, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BackBut
            // 
            this.BackBut.Font = new System.Drawing.Font("Arial", 14.25F);
            this.BackBut.Location = new System.Drawing.Point(541, 507);
            this.BackBut.Name = "BackBut";
            this.BackBut.Size = new System.Drawing.Size(249, 36);
            this.BackBut.TabIndex = 3;
            this.BackBut.Text = "Сохранить и выйти";
            this.BackBut.UseVisualStyleBackColor = true;
            this.BackBut.Click += new System.EventHandler(this.BackBut_Click);
            // 
            // ImportBut
            // 
            this.ImportBut.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImportBut.Location = new System.Drawing.Point(11, 507);
            this.ImportBut.Name = "ImportBut";
            this.ImportBut.Size = new System.Drawing.Size(249, 36);
            this.ImportBut.TabIndex = 2;
            this.ImportBut.Text = "Импорт участников";
            this.ImportBut.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.CloseBox);
            this.panel2.Controls.Add(this.SearchPanel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.TextPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 0;
            // 
            // CloseBox
            // 
            this.CloseBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBox.Image = global::Judo.Properties.Resources.close;
            this.CloseBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CloseBox.Location = new System.Drawing.Point(780, 0);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(20, 20);
            this.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBox.TabIndex = 7;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // SearchPanel
            // 
            this.SearchPanel.Location = new System.Drawing.Point(497, 73);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(272, 28);
            this.SearchPanel.TabIndex = 6;
            this.SearchPanel.Visible = false;
            this.SearchPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SearchPanel_MouseDown);
            this.SearchPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SearchPanel_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.panel3.Controls.Add(this.SearchBut);
            this.panel3.Controls.Add(this.SearchBox);
            this.panel3.Location = new System.Drawing.Point(509, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 33);
            this.panel3.TabIndex = 5;
            // 
            // SearchBut
            // 
            this.SearchBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBut.Image = global::Judo.Properties.Resources.magnifier;
            this.SearchBut.Location = new System.Drawing.Point(263, 5);
            this.SearchBut.Name = "SearchBut";
            this.SearchBut.Size = new System.Drawing.Size(20, 20);
            this.SearchBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchBut.TabIndex = 5;
            this.SearchBut.TabStop = false;
            this.SearchBut.Click += new System.EventHandler(this.SearchBut_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(86)))));
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBox.Location = new System.Drawing.Point(12, 6);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(247, 19);
            this.SearchBox.TabIndex = 4;
            // 
            // TextPanel
            // 
            this.TextPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextPanel.Font = new System.Drawing.Font("Arial", 32.25F);
            this.TextPanel.ForeColor = System.Drawing.Color.White;
            this.TextPanel.Location = new System.Drawing.Point(0, 0);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Size = new System.Drawing.Size(800, 100);
            this.TextPanel.TabIndex = 0;
            this.TextPanel.Text = "Участники";
            this.TextPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TextPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextPanel_MouseDown);
            this.TextPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TextPanel_MouseMove);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Имя,
            this.Фамилия,
            this.Год,
            this.Клуб,
            this.Место_проживания,
            this.Вес});
            this.dataGridView1.Location = new System.Drawing.Point(11, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(779, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // Имя
            // 
            this.Имя.HeaderText = "Имя";
            this.Имя.Name = "Имя";
            // 
            // Фамилия
            // 
            this.Фамилия.HeaderText = "Фамилия";
            this.Фамилия.Name = "Фамилия";
            // 
            // Год
            // 
            this.Год.HeaderText = "Год";
            this.Год.Name = "Год";
            // 
            // Клуб
            // 
            this.Клуб.HeaderText = "Клуб";
            this.Клуб.Name = "Клуб";
            // 
            // Место_проживания
            // 
            this.Место_проживания.HeaderText = "Место проживания";
            this.Место_проживания.Name = "Место_проживания";
            // 
            // Вес
            // 
            this.Вес.HeaderText = "Вес";
            this.Вес.Name = "Вес";
            // 
            // MembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MembersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Judo | Участники";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TextPanel;
        private System.Windows.Forms.Button BackBut;
        private System.Windows.Forms.Button ImportBut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.PictureBox SearchBut;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.PictureBox CloseBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Имя;
        private System.Windows.Forms.DataGridViewTextBoxColumn Фамилия;
        private System.Windows.Forms.DataGridViewTextBoxColumn Год;
        private System.Windows.Forms.DataGridViewTextBoxColumn Клуб;
        private System.Windows.Forms.DataGridViewTextBoxColumn Место_проживания;
        private System.Windows.Forms.DataGridViewTextBoxColumn Вес;
    }
}