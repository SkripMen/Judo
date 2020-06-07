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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TatamiForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxLGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxSGroup = new System.Windows.Forms.ComboBox();
            this.TextPanel = new System.Windows.Forms.Label();
            this.CloseBut = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitBut = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Борец = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Вес = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ДР = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(83)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.SearchBox);
            this.panel1.Controls.Add(this.comboBoxLGroup);
            this.panel1.Controls.Add(this.comboBoxSGroup);
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
            // comboBoxLGroup
            // 
            this.comboBoxLGroup.FormattingEnabled = true;
            this.comboBoxLGroup.Items.AddRange(new object[] {
            "Девочки от 8 до 10",
            "Девочки от 10 до 12",
            "Мальчики от 8 до 10",
            "Мальчики от 10 до 12"});
            this.comboBoxLGroup.Location = new System.Drawing.Point(648, 44);
            this.comboBoxLGroup.Name = "comboBoxLGroup";
            this.comboBoxLGroup.Size = new System.Drawing.Size(140, 22);
            this.comboBoxLGroup.TabIndex = 7;
            this.comboBoxLGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxLGroup_SelectedIndexChanged);
            // 
            // comboBoxSGroup
            // 
            this.comboBoxSGroup.FormattingEnabled = true;
            this.comboBoxSGroup.Location = new System.Drawing.Point(648, 72);
            this.comboBoxSGroup.Name = "comboBoxSGroup";
            this.comboBoxSGroup.Size = new System.Drawing.Size(140, 22);
            this.comboBoxSGroup.TabIndex = 6;
            this.comboBoxSGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxSGroup_SelectedIndexChanged);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.ExitBut);
            this.panel2.Controls.Add(this.PrintButton);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 385);
            this.panel2.TabIndex = 1;
            // 
            // ExitBut
            // 
            this.ExitBut.Font = new System.Drawing.Font("Arial", 14.25F);
            this.ExitBut.ForeColor = System.Drawing.Color.Black;
            this.ExitBut.Location = new System.Drawing.Point(549, 334);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(242, 39);
            this.ExitBut.TabIndex = 8;
            this.ExitBut.Text = "Выйти";
            this.ExitBut.UseVisualStyleBackColor = true;
            this.ExitBut.Click += new System.EventHandler(this.ExitBut_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Font = new System.Drawing.Font("Arial", 14.25F);
            this.PrintButton.ForeColor = System.Drawing.Color.Black;
            this.PrintButton.Location = new System.Drawing.Point(12, 334);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(242, 39);
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
            this.dataGridView2.Size = new System.Drawing.Size(779, 313);
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
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(12, 74);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(181, 20);
            this.SearchBox.TabIndex = 8;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // TatamiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 485);
            this.MinimumSize = new System.Drawing.Size(800, 485);
            this.Name = "TatamiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TatamiForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).EndInit();
            this.panel2.ResumeLayout(false);
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
    }
}