namespace Judo
{
    partial class TatamiForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TatamiForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SearchBut = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.TextPanel = new System.Windows.Forms.Label();
            this.CloseBut = new System.Windows.Forms.PictureBox();
            this.comboBoxLGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxSGroup = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitBut = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Борец = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Вес = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ДР = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.SearchPanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.TextPanel);
            this.panel1.Controls.Add(this.CloseBut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // SearchPanel
            // 
            this.SearchPanel.Location = new System.Drawing.Point(560, 72);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(208, 28);
            this.SearchPanel.TabIndex = 11;
            this.SearchPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SearchPanel_MouseDown);
            this.SearchPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SearchPanel_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.panel3.Controls.Add(this.SearchBut);
            this.panel3.Controls.Add(this.SearchBox);
            this.panel3.Location = new System.Drawing.Point(560, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 28);
            this.panel3.TabIndex = 10;
            // 
            // SearchBut
            // 
            this.SearchBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBut.Image = global::Judo.Properties.Resources.magnifier;
            this.SearchBut.Location = new System.Drawing.Point(214, 4);
            this.SearchBut.Name = "SearchBut";
            this.SearchBut.Size = new System.Drawing.Size(20, 20);
            this.SearchBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchBut.TabIndex = 9;
            this.SearchBut.TabStop = false;
            this.SearchBut.Click += new System.EventHandler(this.SearchBut_Click_1);
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(86)))));
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Font = new System.Drawing.Font("Arial", 12.25F);
            this.SearchBox.ForeColor = System.Drawing.Color.White;
            this.SearchBox.Location = new System.Drawing.Point(13, 4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(195, 19);
            this.SearchBox.TabIndex = 8;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // TextPanel
            // 
            this.TextPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(86)))));
            this.TextPanel.Font = new System.Drawing.Font("Arial", 32.25F);
            this.TextPanel.ForeColor = System.Drawing.Color.White;
            this.TextPanel.Location = new System.Drawing.Point(315, 28);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Size = new System.Drawing.Size(170, 44);
            this.TextPanel.TabIndex = 4;
            this.TextPanel.Text = "Татами";
            this.TextPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseBut
            // 
            this.CloseBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(86)))));
            this.CloseBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBut.Image = global::Judo.Properties.Resources.close;
            this.CloseBut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CloseBut.Location = new System.Drawing.Point(780, 0);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(20, 20);
            this.CloseBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBut.TabIndex = 5;
            this.CloseBut.TabStop = false;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // comboBoxLGroup
            // 
            this.comboBoxLGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(86)))));
            this.comboBoxLGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxLGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLGroup.ForeColor = System.Drawing.Color.White;
            this.comboBoxLGroup.FormattingEnabled = true;
            this.comboBoxLGroup.Items.AddRange(new object[] {
            "Девочки от 8 до 10",
            "Девочки от 10 до 12",
            "Мальчики от 8 до 10",
            "Мальчики от 10 до 12"});
            this.comboBoxLGroup.Location = new System.Drawing.Point(579, 59);
            this.comboBoxLGroup.Name = "comboBoxLGroup";
            this.comboBoxLGroup.Size = new System.Drawing.Size(212, 22);
            this.comboBoxLGroup.TabIndex = 7;
            this.comboBoxLGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxLGroup_SelectedIndexChanged);
            // 
            // comboBoxSGroup
            // 
            this.comboBoxSGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(86)))));
            this.comboBoxSGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSGroup.ForeColor = System.Drawing.Color.White;
            this.comboBoxSGroup.FormattingEnabled = true;
            this.comboBoxSGroup.Location = new System.Drawing.Point(579, 103);
            this.comboBoxSGroup.Name = "comboBoxSGroup";
            this.comboBoxSGroup.Size = new System.Drawing.Size(212, 22);
            this.comboBoxSGroup.TabIndex = 6;
            this.comboBoxSGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxSGroup_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ExitBut);
            this.panel2.Controls.Add(this.comboBoxSGroup);
            this.panel2.Controls.Add(this.comboBoxLGroup);
            this.panel2.Controls.Add(this.PrintButton);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 340);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.25F);
            this.label3.Location = new System.Drawing.Point(577, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Татами";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.25F);
            this.label2.Location = new System.Drawing.Point(577, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Пол/Возраст";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(579, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Сортировка";
            // 
            // ExitBut
            // 
            this.ExitBut.Font = new System.Drawing.Font("Arial", 14.25F);
            this.ExitBut.ForeColor = System.Drawing.Color.Black;
            this.ExitBut.Location = new System.Drawing.Point(582, 289);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(212, 39);
            this.ExitBut.TabIndex = 8;
            this.ExitBut.Text = "Выйти";
            this.ExitBut.UseVisualStyleBackColor = true;
            this.ExitBut.Click += new System.EventHandler(this.ExitBut_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Font = new System.Drawing.Font("Arial", 14.25F);
            this.PrintButton.ForeColor = System.Drawing.Color.Black;
            this.PrintButton.Location = new System.Drawing.Point(582, 244);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(212, 39);
            this.PrintButton.TabIndex = 7;
            this.PrintButton.Text = "Печать";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(86)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Борец,
            this.Вес,
            this.ДР});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.Black;
            this.dataGridView2.Location = new System.Drawing.Point(12, 15);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(561, 313);
            this.dataGridView2.TabIndex = 6;
            // 
            // Борец
            // 
            this.Борец.HeaderText = "Борец";
            this.Борец.Name = "Борец";
            this.Борец.ReadOnly = true;
            this.Борец.Width = 350;
            // 
            // Вес
            // 
            this.Вес.HeaderText = "Вес";
            this.Вес.Name = "Вес";
            this.Вес.ReadOnly = true;
            // 
            // ДР
            // 
            this.ДР.HeaderText = "Дата рождения";
            this.ДР.Name = "ДР";
            this.ДР.ReadOnly = true;
            this.ДР.Width = 110;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // timer
            // 
            this.timer.Interval = 5;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // TatamiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 440);
            this.MinimumSize = new System.Drawing.Size(800, 440);
            this.Name = "TatamiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TatamiForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox CloseBut;
        private System.Windows.Forms.Label TextPanel;
        private System.Windows.Forms.Button ExitBut;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBoxSGroup;
        private System.Windows.Forms.ComboBox comboBoxLGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Борец;
        private System.Windows.Forms.DataGridViewTextBoxColumn Вес;
        private System.Windows.Forms.DataGridViewTextBoxColumn ДР;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox SearchBut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}