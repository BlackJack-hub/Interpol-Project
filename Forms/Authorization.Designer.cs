namespace Interpol
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pictureCodeVisible = new System.Windows.Forms.PictureBox();
            this.userErrorBlock = new System.Windows.Forms.Label();
            this.userError = new System.Windows.Forms.Label();
            this.CheckData = new System.Windows.Forms.Button();
            this.pictureCode = new System.Windows.Forms.PictureBox();
            this.picturePassword = new System.Windows.Forms.PictureBox();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.userCode = new System.Windows.Forms.TextBox();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.userLogin = new System.Windows.Forms.TextBox();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.timerFailure = new System.Windows.Forms.Timer(this.components);
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCodeVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(111)))), ((int)(((byte)(161)))));
            this.mainPanel.Controls.Add(this.pictureCodeVisible);
            this.mainPanel.Controls.Add(this.userErrorBlock);
            this.mainPanel.Controls.Add(this.userError);
            this.mainPanel.Controls.Add(this.CheckData);
            this.mainPanel.Controls.Add(this.pictureCode);
            this.mainPanel.Controls.Add(this.picturePassword);
            this.mainPanel.Controls.Add(this.pictureUser);
            this.mainPanel.Controls.Add(this.userCode);
            this.mainPanel.Controls.Add(this.userPassword);
            this.mainPanel.Controls.Add(this.userLogin);
            this.mainPanel.Controls.Add(this.pictureLogo);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(684, 561);
            this.mainPanel.TabIndex = 1;
            // 
            // pictureCodeVisible
            // 
            this.pictureCodeVisible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureCodeVisible.Enabled = false;
            this.pictureCodeVisible.Image = global::Interpol.Properties.Resources.show;
            this.pictureCodeVisible.Location = new System.Drawing.Point(556, 400);
            this.pictureCodeVisible.Name = "pictureCodeVisible";
            this.pictureCodeVisible.Size = new System.Drawing.Size(36, 36);
            this.pictureCodeVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCodeVisible.TabIndex = 10;
            this.pictureCodeVisible.TabStop = false;
            this.pictureCodeVisible.Visible = false;
            this.pictureCodeVisible.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureCodeVisible_MouseClick);
            // 
            // userErrorBlock
            // 
            this.userErrorBlock.AutoSize = true;
            this.userErrorBlock.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userErrorBlock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.userErrorBlock.Location = new System.Drawing.Point(150, 530);
            this.userErrorBlock.Name = "userErrorBlock";
            this.userErrorBlock.Size = new System.Drawing.Size(395, 23);
            this.userErrorBlock.TabIndex = 9;
            this.userErrorBlock.Text = "Программа заблокирована на секунд!";
            this.userErrorBlock.Visible = false;
            // 
            // userError
            // 
            this.userError.AutoSize = true;
            this.userError.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.userError.Location = new System.Drawing.Point(205, 530);
            this.userError.Name = "userError";
            this.userError.Size = new System.Drawing.Size(290, 23);
            this.userError.TabIndex = 8;
            this.userError.Text = "Введены неверные данные!";
            this.userError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userError.Visible = false;
            // 
            // CheckData
            // 
            this.CheckData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(188)))), ((int)(((byte)(193)))));
            this.CheckData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckData.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CheckData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(108)))));
            this.CheckData.FlatAppearance.BorderSize = 0;
            this.CheckData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(108)))));
            this.CheckData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(108)))));
            this.CheckData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckData.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckData.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CheckData.Location = new System.Drawing.Point(290, 480);
            this.CheckData.Margin = new System.Windows.Forms.Padding(1);
            this.CheckData.Name = "CheckData";
            this.CheckData.Size = new System.Drawing.Size(120, 40);
            this.CheckData.TabIndex = 5;
            this.CheckData.Text = "Войти";
            this.CheckData.UseVisualStyleBackColor = false;
            this.CheckData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckData_MouseClick);
            // 
            // pictureCode
            // 
            this.pictureCode.Image = global::Interpol.Properties.Resources.shield;
            this.pictureCode.Location = new System.Drawing.Point(67, 374);
            this.pictureCode.Name = "pictureCode";
            this.pictureCode.Size = new System.Drawing.Size(64, 64);
            this.pictureCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCode.TabIndex = 6;
            this.pictureCode.TabStop = false;
            this.pictureCode.Visible = false;
            // 
            // picturePassword
            // 
            this.picturePassword.Image = global::Interpol.Properties.Resources.key;
            this.picturePassword.Location = new System.Drawing.Point(67, 292);
            this.picturePassword.Name = "picturePassword";
            this.picturePassword.Size = new System.Drawing.Size(64, 64);
            this.picturePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePassword.TabIndex = 5;
            this.picturePassword.TabStop = false;
            // 
            // pictureUser
            // 
            this.pictureUser.Image = global::Interpol.Properties.Resources.user;
            this.pictureUser.Location = new System.Drawing.Point(67, 212);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(64, 64);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 4;
            this.pictureUser.TabStop = false;
            // 
            // userCode
            // 
            this.userCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.userCode.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userCode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userCode.Location = new System.Drawing.Point(150, 400);
            this.userCode.MaxLength = 6;
            this.userCode.Name = "userCode";
            this.userCode.Size = new System.Drawing.Size(400, 36);
            this.userCode.TabIndex = 4;
            this.userCode.Text = "Секретный код";
            this.userCode.Visible = false;
            this.userCode.Enter += new System.EventHandler(this.userCode_Enter);
            this.userCode.Leave += new System.EventHandler(this.userCode_Leave);
            // 
            // userPassword
            // 
            this.userPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.userPassword.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userPassword.Location = new System.Drawing.Point(150, 320);
            this.userPassword.MaxLength = 50;
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(400, 36);
            this.userPassword.TabIndex = 3;
            this.userPassword.Text = "Пароль";
            this.userPassword.Enter += new System.EventHandler(this.userPassword_Enter);
            this.userPassword.Leave += new System.EventHandler(this.userPassword_Leave);
            // 
            // userLogin
            // 
            this.userLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.userLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userLogin.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userLogin.Location = new System.Drawing.Point(150, 240);
            this.userLogin.MaxLength = 50;
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(400, 36);
            this.userLogin.TabIndex = 2;
            this.userLogin.Text = "Логин";
            this.userLogin.Enter += new System.EventHandler(this.userLogin_Enter);
            this.userLogin.Leave += new System.EventHandler(this.userLogin_Leave);
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::Interpol.Properties.Resources.interpol_logo;
            this.pictureLogo.Location = new System.Drawing.Point(150, 0);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(400, 200);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // timerFailure
            // 
            this.timerFailure.Interval = 1000;
            this.timerFailure.Tick += new System.EventHandler(this.timerFailure_Tick);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interpol Application";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCodeVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label userErrorBlock;
        private System.Windows.Forms.Label userError;
        private System.Windows.Forms.Button CheckData;
        private System.Windows.Forms.PictureBox pictureCode;
        private System.Windows.Forms.PictureBox picturePassword;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.TextBox userCode;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.TextBox userLogin;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Timer timerFailure;
        private System.Windows.Forms.PictureBox pictureCodeVisible;
    }
}