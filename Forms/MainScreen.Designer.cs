namespace Interpol.Forms
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.loadMore = new System.Windows.Forms.Button();
            this.userLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchNickname = new System.Windows.Forms.TextBox();
            this.searchName = new System.Windows.Forms.TextBox();
            this.searchSurname = new System.Windows.Forms.TextBox();
            this.searchNumber = new System.Windows.Forms.Label();
            this.totalNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureReload = new System.Windows.Forms.PictureBox();
            this.pictureInfo = new System.Windows.Forms.PictureBox();
            this.buttonArchive = new System.Windows.Forms.Button();
            this.pictureAdvancedSearch = new System.Windows.Forms.PictureBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.pictureFinger = new System.Windows.Forms.PictureBox();
            this.pictureWorld = new System.Windows.Forms.PictureBox();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAdvancedSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFinger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWorld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(111)))), ((int)(((byte)(161)))));
            this.mainPanel.Controls.Add(this.pictureReload);
            this.mainPanel.Controls.Add(this.pictureInfo);
            this.mainPanel.Controls.Add(this.buttonArchive);
            this.mainPanel.Controls.Add(this.loadMore);
            this.mainPanel.Controls.Add(this.userLayoutPanel);
            this.mainPanel.Controls.Add(this.pictureAdvancedSearch);
            this.mainPanel.Controls.Add(this.searchNickname);
            this.mainPanel.Controls.Add(this.searchName);
            this.mainPanel.Controls.Add(this.searchSurname);
            this.mainPanel.Controls.Add(this.buttonCreate);
            this.mainPanel.Controls.Add(this.searchNumber);
            this.mainPanel.Controls.Add(this.buttonSearch);
            this.mainPanel.Controls.Add(this.totalNumber);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.pictureFinger);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 148);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1184, 513);
            this.mainPanel.TabIndex = 0;
            // 
            // loadMore
            // 
            this.loadMore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loadMore.BackColor = System.Drawing.Color.LightGray;
            this.loadMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadMore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(20)))), ((int)(((byte)(114)))));
            this.loadMore.FlatAppearance.BorderSize = 2;
            this.loadMore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.loadMore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.loadMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadMore.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadMore.Location = new System.Drawing.Point(541, 471);
            this.loadMore.Name = "loadMore";
            this.loadMore.Size = new System.Drawing.Size(150, 30);
            this.loadMore.TabIndex = 31;
            this.loadMore.Text = "ЗАГРУЗИТЬ";
            this.loadMore.UseVisualStyleBackColor = false;
            this.loadMore.Click += new System.EventHandler(this.loadMore_Click);
            // 
            // userLayoutPanel
            // 
            this.userLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userLayoutPanel.AutoScroll = true;
            this.userLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userLayoutPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userLayoutPanel.Location = new System.Drawing.Point(88, 102);
            this.userLayoutPanel.Name = "userLayoutPanel";
            this.userLayoutPanel.Size = new System.Drawing.Size(1056, 364);
            this.userLayoutPanel.TabIndex = 30;
            // 
            // searchNickname
            // 
            this.searchNickname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchNickname.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchNickname.Location = new System.Drawing.Point(770, 6);
            this.searchNickname.MaxLength = 50;
            this.searchNickname.Name = "searchNickname";
            this.searchNickname.Size = new System.Drawing.Size(150, 30);
            this.searchNickname.TabIndex = 26;
            this.searchNickname.Text = "Прозвище";
            this.searchNickname.Enter += new System.EventHandler(this.searchNickname_Enter);
            this.searchNickname.Leave += new System.EventHandler(this.searchNickname_Leave);
            // 
            // searchName
            // 
            this.searchName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchName.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchName.Location = new System.Drawing.Point(600, 6);
            this.searchName.MaxLength = 50;
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(150, 30);
            this.searchName.TabIndex = 25;
            this.searchName.Text = "Имя";
            this.searchName.Enter += new System.EventHandler(this.searchName_Enter);
            this.searchName.Leave += new System.EventHandler(this.searchName_Leave);
            // 
            // searchSurname
            // 
            this.searchSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchSurname.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchSurname.Location = new System.Drawing.Point(430, 6);
            this.searchSurname.MaxLength = 50;
            this.searchSurname.Name = "searchSurname";
            this.searchSurname.Size = new System.Drawing.Size(150, 30);
            this.searchSurname.TabIndex = 24;
            this.searchSurname.Text = "Фамилия";
            this.searchSurname.Enter += new System.EventHandler(this.searchSurname_Enter);
            this.searchSurname.Leave += new System.EventHandler(this.searchSurname_Leave);
            // 
            // searchNumber
            // 
            this.searchNumber.AutoSize = true;
            this.searchNumber.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.searchNumber.Location = new System.Drawing.Point(98, 44);
            this.searchNumber.Name = "searchNumber";
            this.searchNumber.Size = new System.Drawing.Size(199, 23);
            this.searchNumber.TabIndex = 19;
            this.searchNumber.Text = "Search results: 142";
            // 
            // totalNumber
            // 
            this.totalNumber.AutoSize = true;
            this.totalNumber.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.totalNumber.Location = new System.Drawing.Point(98, 7);
            this.totalNumber.Name = "totalNumber";
            this.totalNumber.Size = new System.Drawing.Size(326, 23);
            this.totalNumber.TabIndex = 18;
            this.totalNumber.Text = "Total number of criminals: 8074";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(849, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "INTERPOL 2020. All Rights Reserved.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureWorld);
            this.panel1.Controls.Add(this.pictureLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 148);
            this.panel1.TabIndex = 5;
            // 
            // pictureReload
            // 
            this.pictureReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureReload.Image = global::Interpol.Properties.Resources.arrow_loader_static;
            this.pictureReload.Location = new System.Drawing.Point(1108, 0);
            this.pictureReload.Name = "pictureReload";
            this.pictureReload.Size = new System.Drawing.Size(64, 64);
            this.pictureReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureReload.TabIndex = 34;
            this.pictureReload.TabStop = false;
            this.pictureReload.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureReload_MouseClick);
            this.pictureReload.MouseEnter += new System.EventHandler(this.pictureReload_MouseEnter);
            this.pictureReload.MouseLeave += new System.EventHandler(this.pictureReload_MouseLeave);
            // 
            // pictureInfo
            // 
            this.pictureInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureInfo.Image = global::Interpol.Properties.Resources.info;
            this.pictureInfo.Location = new System.Drawing.Point(21, 117);
            this.pictureInfo.Name = "pictureInfo";
            this.pictureInfo.Size = new System.Drawing.Size(46, 46);
            this.pictureInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureInfo.TabIndex = 33;
            this.pictureInfo.TabStop = false;
            this.pictureInfo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureInfo_MouseClick);
            this.pictureInfo.MouseEnter += new System.EventHandler(this.pictureInfo_MouseEnter);
            this.pictureInfo.MouseLeave += new System.EventHandler(this.pictureInfo_MouseLeave);
            // 
            // buttonArchive
            // 
            this.buttonArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonArchive.BackColor = System.Drawing.Color.Moccasin;
            this.buttonArchive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArchive.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonArchive.Image = global::Interpol.Properties.Resources.folder;
            this.buttonArchive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonArchive.Location = new System.Drawing.Point(529, 57);
            this.buttonArchive.Name = "buttonArchive";
            this.buttonArchive.Size = new System.Drawing.Size(135, 40);
            this.buttonArchive.TabIndex = 32;
            this.buttonArchive.Text = "Архив";
            this.buttonArchive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonArchive.UseVisualStyleBackColor = false;
            this.buttonArchive.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonArchive_MouseClick);
            // 
            // pictureAdvancedSearch
            // 
            this.pictureAdvancedSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureAdvancedSearch.Image = global::Interpol.Properties.Resources.advanced_search;
            this.pictureAdvancedSearch.Location = new System.Drawing.Point(12, 7);
            this.pictureAdvancedSearch.Name = "pictureAdvancedSearch";
            this.pictureAdvancedSearch.Size = new System.Drawing.Size(80, 80);
            this.pictureAdvancedSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAdvancedSearch.TabIndex = 27;
            this.pictureAdvancedSearch.TabStop = false;
            this.pictureAdvancedSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureAdvancedSearch_MouseClick);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.BackColor = System.Drawing.Color.Moccasin;
            this.buttonCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Image = global::Interpol.Properties.Resources.add;
            this.buttonCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreate.Location = new System.Drawing.Point(710, 57);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(135, 40);
            this.buttonCreate.TabIndex = 21;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.BackColor = System.Drawing.Color.LightGray;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Image = global::Interpol.Properties.Resources.search_icon;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(947, 7);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(135, 30);
            this.buttonSearch.TabIndex = 20;
            this.buttonSearch.Text = "     Найти";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSearch_MouseClick);
            // 
            // pictureFinger
            // 
            this.pictureFinger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureFinger.Image = global::Interpol.Properties.Resources.finger;
            this.pictureFinger.Location = new System.Drawing.Point(0, 421);
            this.pictureFinger.Name = "pictureFinger";
            this.pictureFinger.Size = new System.Drawing.Size(89, 92);
            this.pictureFinger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFinger.TabIndex = 29;
            this.pictureFinger.TabStop = false;
            // 
            // pictureWorld
            // 
            this.pictureWorld.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureWorld.BackColor = System.Drawing.Color.White;
            this.pictureWorld.Image = global::Interpol.Properties.Resources.main_map;
            this.pictureWorld.Location = new System.Drawing.Point(200, 0);
            this.pictureWorld.Name = "pictureWorld";
            this.pictureWorld.Size = new System.Drawing.Size(985, 162);
            this.pictureWorld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureWorld.TabIndex = 2;
            this.pictureWorld.TabStop = false;
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.White;
            this.pictureLogo.Image = global::Interpol.Properties.Resources.interpol_logo;
            this.pictureLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(256, 148);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 1;
            this.pictureLogo.TabStop = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interpol Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainScreen_FormClosed);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAdvancedSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFinger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWorld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.PictureBox pictureWorld;
        private System.Windows.Forms.PictureBox pictureAdvancedSearch;
        private System.Windows.Forms.TextBox searchNickname;
        private System.Windows.Forms.TextBox searchName;
        private System.Windows.Forms.TextBox searchSurname;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label searchNumber;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label totalNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureFinger;
        private System.Windows.Forms.FlowLayoutPanel userLayoutPanel;
        private System.Windows.Forms.Button loadMore;
        private System.Windows.Forms.Button buttonArchive;
        private System.Windows.Forms.PictureBox pictureInfo;
        private System.Windows.Forms.PictureBox pictureReload;
        private System.Windows.Forms.Panel panel1;
    }
}