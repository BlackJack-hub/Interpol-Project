namespace Interpol.Forms
{
    partial class AdvancedSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedSearch));
            this.mainPanelSearch = new System.Windows.Forms.Panel();
            this.pictureInfo = new System.Windows.Forms.PictureBox();
            this.pictureData = new System.Windows.Forms.PictureBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textGroup = new System.Windows.Forms.TextBox();
            this.comboBoxWanted = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textCrime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.textNickname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanelSearch
            // 
            this.mainPanelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(111)))), ((int)(((byte)(161)))));
            this.mainPanelSearch.Controls.Add(this.pictureInfo);
            this.mainPanelSearch.Controls.Add(this.pictureData);
            this.mainPanelSearch.Controls.Add(this.buttonFind);
            this.mainPanelSearch.Controls.Add(this.label9);
            this.mainPanelSearch.Controls.Add(this.textGroup);
            this.mainPanelSearch.Controls.Add(this.comboBoxWanted);
            this.mainPanelSearch.Controls.Add(this.label8);
            this.mainPanelSearch.Controls.Add(this.textName);
            this.mainPanelSearch.Controls.Add(this.textCrime);
            this.mainPanelSearch.Controls.Add(this.label1);
            this.mainPanelSearch.Controls.Add(this.birthdayPicker);
            this.mainPanelSearch.Controls.Add(this.textSurname);
            this.mainPanelSearch.Controls.Add(this.label2);
            this.mainPanelSearch.Controls.Add(this.comboBoxGender);
            this.mainPanelSearch.Controls.Add(this.textNickname);
            this.mainPanelSearch.Controls.Add(this.label6);
            this.mainPanelSearch.Controls.Add(this.label3);
            this.mainPanelSearch.Controls.Add(this.label5);
            this.mainPanelSearch.Controls.Add(this.label4);
            this.mainPanelSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanelSearch.Location = new System.Drawing.Point(0, 70);
            this.mainPanelSearch.Name = "mainPanelSearch";
            this.mainPanelSearch.Size = new System.Drawing.Size(484, 490);
            this.mainPanelSearch.TabIndex = 0;
            // 
            // pictureInfo
            // 
            this.pictureInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureInfo.Image = global::Interpol.Properties.Resources.info;
            this.pictureInfo.Location = new System.Drawing.Point(432, 17);
            this.pictureInfo.Name = "pictureInfo";
            this.pictureInfo.Size = new System.Drawing.Size(40, 40);
            this.pictureInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureInfo.TabIndex = 75;
            this.pictureInfo.TabStop = false;
            this.pictureInfo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureInfo_MouseClick);
            this.pictureInfo.MouseEnter += new System.EventHandler(this.pictureInfo_MouseEnter);
            this.pictureInfo.MouseLeave += new System.EventHandler(this.pictureInfo_MouseLeave);
            // 
            // pictureData
            // 
            this.pictureData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureData.Image = global::Interpol.Properties.Resources.accept;
            this.pictureData.Location = new System.Drawing.Point(411, 162);
            this.pictureData.Name = "pictureData";
            this.pictureData.Size = new System.Drawing.Size(30, 30);
            this.pictureData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureData.TabIndex = 74;
            this.pictureData.TabStop = false;
            this.pictureData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureData_MouseClick);
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.Color.Moccasin;
            this.buttonFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFind.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFind.Image = global::Interpol.Properties.Resources.search_icon1;
            this.buttonFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFind.Location = new System.Drawing.Point(179, 410);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(126, 40);
            this.buttonFind.TabIndex = 73;
            this.buttonFind.Text = "Найти";
            this.buttonFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonFind_MouseClick);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.label9.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(80, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 30);
            this.label9.TabIndex = 72;
            this.label9.Text = "Группировка";
            // 
            // textGroup
            // 
            this.textGroup.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGroup.Location = new System.Drawing.Point(240, 342);
            this.textGroup.MaxLength = 50;
            this.textGroup.Name = "textGroup";
            this.textGroup.Size = new System.Drawing.Size(165, 30);
            this.textGroup.TabIndex = 8;
            // 
            // comboBoxWanted
            // 
            this.comboBoxWanted.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxWanted.FormattingEnabled = true;
            this.comboBoxWanted.Items.AddRange(new object[] {
            "Ukraine",
            "France",
            "Italy",
            "Germany",
            "Poland",
            "USA"});
            this.comboBoxWanted.Location = new System.Drawing.Point(240, 252);
            this.comboBoxWanted.Name = "comboBoxWanted";
            this.comboBoxWanted.Size = new System.Drawing.Size(165, 31);
            this.comboBoxWanted.TabIndex = 6;
            this.comboBoxWanted.Text = "Выберите";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.label8.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(80, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 30);
            this.label8.TabIndex = 71;
            this.label8.Text = "Преступление";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(240, 27);
            this.textName.MaxLength = 50;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(165, 30);
            this.textName.TabIndex = 1;
            // 
            // textCrime
            // 
            this.textCrime.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCrime.Location = new System.Drawing.Point(240, 297);
            this.textCrime.MaxLength = 50;
            this.textCrime.Name = "textCrime";
            this.textCrime.Size = new System.Drawing.Size(165, 30);
            this.textCrime.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(80, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 30);
            this.label1.TabIndex = 65;
            this.label1.Text = "Имя";
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.CalendarFont = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdayPicker.Enabled = false;
            this.birthdayPicker.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdayPicker.Location = new System.Drawing.Point(240, 162);
            this.birthdayPicker.MaxDate = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            this.birthdayPicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(165, 30);
            this.birthdayPicker.TabIndex = 4;
            this.birthdayPicker.Value = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            // 
            // textSurname
            // 
            this.textSurname.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSurname.Location = new System.Drawing.Point(240, 72);
            this.textSurname.MaxLength = 50;
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(165, 30);
            this.textSurname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(80, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 30);
            this.label2.TabIndex = 66;
            this.label2.Text = "Фамилия";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "man ",
            "woman"});
            this.comboBoxGender.Location = new System.Drawing.Point(240, 207);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(165, 31);
            this.comboBoxGender.TabIndex = 5;
            this.comboBoxGender.Text = "Выберите";
            // 
            // textNickname
            // 
            this.textNickname.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNickname.Location = new System.Drawing.Point(240, 117);
            this.textNickname.MaxLength = 50;
            this.textNickname.Name = "textNickname";
            this.textNickname.Size = new System.Drawing.Size(165, 30);
            this.textNickname.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.label6.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(80, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 31);
            this.label6.TabIndex = 70;
            this.label6.Text = "Страна";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(80, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 30);
            this.label3.TabIndex = 67;
            this.label3.Text = "Прозвище";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.label5.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(80, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 31);
            this.label5.TabIndex = 69;
            this.label5.Text = "Пол";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(80, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 30);
            this.label4.TabIndex = 68;
            this.label4.Text = "Дата ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Interpol.Properties.Resources.search_bar;
            this.pictureBox2.Location = new System.Drawing.Point(68, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(348, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 87);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(484, 560);
            this.Controls.Add(this.mainPanelSearch);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdvancedSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdvancedSearch @Interpol Application";
            this.mainPanelSearch.ResumeLayout(false);
            this.mainPanelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel mainPanelSearch;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textGroup;
        private System.Windows.Forms.ComboBox comboBoxWanted;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textCrime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.TextBox textNickname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureData;
        private System.Windows.Forms.PictureBox pictureInfo;
    }
}