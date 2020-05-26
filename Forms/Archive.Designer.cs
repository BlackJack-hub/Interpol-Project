namespace Interpol.Forms
{
    partial class Archive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Archive));
            this.mainPanelArchive = new System.Windows.Forms.Panel();
            this.searchNickname = new System.Windows.Forms.TextBox();
            this.searchName = new System.Windows.Forms.TextBox();
            this.searchSurname = new System.Windows.Forms.TextBox();
            this.listBoxArchive = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureHome = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeArchive = new System.Windows.Forms.Button();
            this.buttonArchiveSearch = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.pictureInfo = new System.Windows.Forms.PictureBox();
            this.exitArchive = new System.Windows.Forms.Button();
            this.mainPanelArchive.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanelArchive
            // 
            this.mainPanelArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(111)))), ((int)(((byte)(161)))));
            this.mainPanelArchive.Controls.Add(this.closeArchive);
            this.mainPanelArchive.Controls.Add(this.searchNickname);
            this.mainPanelArchive.Controls.Add(this.buttonArchiveSearch);
            this.mainPanelArchive.Controls.Add(this.buttonBack);
            this.mainPanelArchive.Controls.Add(this.searchName);
            this.mainPanelArchive.Controls.Add(this.buttonOpen);
            this.mainPanelArchive.Controls.Add(this.searchSurname);
            this.mainPanelArchive.Controls.Add(this.pictureInfo);
            this.mainPanelArchive.Controls.Add(this.listBoxArchive);
            this.mainPanelArchive.Controls.Add(this.exitArchive);
            this.mainPanelArchive.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanelArchive.Location = new System.Drawing.Point(0, 146);
            this.mainPanelArchive.Name = "mainPanelArchive";
            this.mainPanelArchive.Size = new System.Drawing.Size(1184, 515);
            this.mainPanelArchive.TabIndex = 0;
            // 
            // searchNickname
            // 
            this.searchNickname.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchNickname.Location = new System.Drawing.Point(701, 10);
            this.searchNickname.MaxLength = 50;
            this.searchNickname.Name = "searchNickname";
            this.searchNickname.Size = new System.Drawing.Size(150, 30);
            this.searchNickname.TabIndex = 6;
            this.searchNickname.Text = "Прозвище";
            this.searchNickname.Enter += new System.EventHandler(this.searchNickname_Enter);
            this.searchNickname.Leave += new System.EventHandler(this.searchNickname_Leave);
            // 
            // searchName
            // 
            this.searchName.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchName.Location = new System.Drawing.Point(545, 10);
            this.searchName.MaxLength = 50;
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(150, 30);
            this.searchName.TabIndex = 5;
            this.searchName.Text = "Имя";
            this.searchName.Enter += new System.EventHandler(this.searchName_Enter);
            this.searchName.Leave += new System.EventHandler(this.searchName_Leave);
            // 
            // searchSurname
            // 
            this.searchSurname.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchSurname.Location = new System.Drawing.Point(389, 10);
            this.searchSurname.MaxLength = 50;
            this.searchSurname.Name = "searchSurname";
            this.searchSurname.Size = new System.Drawing.Size(150, 30);
            this.searchSurname.TabIndex = 4;
            this.searchSurname.Text = "Фамилия";
            this.searchSurname.Enter += new System.EventHandler(this.searchSurname_Enter);
            this.searchSurname.Leave += new System.EventHandler(this.searchSurname_Leave);
            // 
            // listBoxArchive
            // 
            this.listBoxArchive.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxArchive.FormattingEnabled = true;
            this.listBoxArchive.ItemHeight = 23;
            this.listBoxArchive.Location = new System.Drawing.Point(54, 55);
            this.listBoxArchive.Name = "listBoxArchive";
            this.listBoxArchive.Size = new System.Drawing.Size(1038, 395);
            this.listBoxArchive.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureHome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 150);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Interpol.Properties.Resources.handcuffs;
            this.pictureBox3.Location = new System.Drawing.Point(185, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(317, 138);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Interpol.Properties.Resources.planet;
            this.pictureBox2.Location = new System.Drawing.Point(1009, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureHome
            // 
            this.pictureHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureHome.Image = global::Interpol.Properties.Resources.home;
            this.pictureHome.Location = new System.Drawing.Point(12, 12);
            this.pictureHome.Name = "pictureHome";
            this.pictureHome.Size = new System.Drawing.Size(64, 64);
            this.pictureHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHome.TabIndex = 1;
            this.pictureHome.TabStop = false;
            this.pictureHome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureHome_MouseClick);
            this.pictureHome.MouseEnter += new System.EventHandler(this.pictureHome_MouseEnter);
            this.pictureHome.MouseLeave += new System.EventHandler(this.pictureHome_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interpol.Properties.Resources.national_archive;
            this.pictureBox1.Location = new System.Drawing.Point(633, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // closeArchive
            // 
            this.closeArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(111)))), ((int)(((byte)(161)))));
            this.closeArchive.FlatAppearance.BorderSize = 0;
            this.closeArchive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(111)))), ((int)(((byte)(161)))));
            this.closeArchive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.closeArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeArchive.Image = global::Interpol.Properties.Resources.minus;
            this.closeArchive.Location = new System.Drawing.Point(1057, 3);
            this.closeArchive.Name = "closeArchive";
            this.closeArchive.Size = new System.Drawing.Size(66, 33);
            this.closeArchive.TabIndex = 8;
            this.closeArchive.UseVisualStyleBackColor = false;
            this.closeArchive.MouseClick += new System.Windows.Forms.MouseEventHandler(this.close_MouseClick);
            // 
            // buttonArchiveSearch
            // 
            this.buttonArchiveSearch.BackColor = System.Drawing.Color.Moccasin;
            this.buttonArchiveSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonArchiveSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonArchiveSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonArchiveSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArchiveSearch.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArchiveSearch.Image = global::Interpol.Properties.Resources.search_icon;
            this.buttonArchiveSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonArchiveSearch.Location = new System.Drawing.Point(875, 10);
            this.buttonArchiveSearch.Name = "buttonArchiveSearch";
            this.buttonArchiveSearch.Size = new System.Drawing.Size(150, 30);
            this.buttonArchiveSearch.TabIndex = 3;
            this.buttonArchiveSearch.Text = "    Найти";
            this.buttonArchiveSearch.UseVisualStyleBackColor = false;
            this.buttonArchiveSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonArchiveSearch_MouseClick);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Moccasin;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Image = global::Interpol.Properties.Resources._return;
            this.buttonBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBack.Location = new System.Drawing.Point(223, 10);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(150, 30);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "    Вернуть";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.Moccasin;
            this.buttonOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen.Image = global::Interpol.Properties.Resources.open;
            this.buttonOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpen.Location = new System.Drawing.Point(54, 10);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(150, 30);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonOpen_MouseClick);
            // 
            // pictureInfo
            // 
            this.pictureInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureInfo.Image = global::Interpol.Properties.Resources.info;
            this.pictureInfo.Location = new System.Drawing.Point(3, 6);
            this.pictureInfo.Name = "pictureInfo";
            this.pictureInfo.Size = new System.Drawing.Size(40, 40);
            this.pictureInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureInfo.TabIndex = 78;
            this.pictureInfo.TabStop = false;
            this.pictureInfo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureInfo_MouseClick);
            this.pictureInfo.MouseEnter += new System.EventHandler(this.pictureInfo_MouseEnter);
            this.pictureInfo.MouseLeave += new System.EventHandler(this.pictureInfo_MouseLeave);
            // 
            // exitArchive
            // 
            this.exitArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(111)))), ((int)(((byte)(161)))));
            this.exitArchive.FlatAppearance.BorderSize = 0;
            this.exitArchive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(111)))), ((int)(((byte)(161)))));
            this.exitArchive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitArchive.Image = global::Interpol.Properties.Resources.cancelled;
            this.exitArchive.Location = new System.Drawing.Point(1118, 3);
            this.exitArchive.Name = "exitArchive";
            this.exitArchive.Size = new System.Drawing.Size(66, 33);
            this.exitArchive.TabIndex = 7;
            this.exitArchive.UseVisualStyleBackColor = false;
            this.exitArchive.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exit_MouseClick);
            // 
            // Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanelArchive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Archive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archive @Interpol Application";
            this.Load += new System.EventHandler(this.Archive_Load);
            this.mainPanelArchive.ResumeLayout(false);
            this.mainPanelArchive.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanelArchive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchNickname;
        private System.Windows.Forms.TextBox searchName;
        private System.Windows.Forms.TextBox searchSurname;
        private System.Windows.Forms.Button buttonArchiveSearch;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ListBox listBoxArchive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureHome;
        private System.Windows.Forms.Button closeArchive;
        private System.Windows.Forms.Button exitArchive;
        private System.Windows.Forms.PictureBox pictureInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}