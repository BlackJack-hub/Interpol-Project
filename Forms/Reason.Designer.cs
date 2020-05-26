namespace Interpol.Forms
{
    partial class Reason
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reason));
            this.mainPanelAdding = new System.Windows.Forms.Panel();
            this.pictureInfo = new System.Windows.Forms.PictureBox();
            this.buttonAddArchieve = new System.Windows.Forms.Button();
            this.textReason = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanelAdding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanelAdding
            // 
            this.mainPanelAdding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(111)))), ((int)(((byte)(161)))));
            this.mainPanelAdding.Controls.Add(this.pictureInfo);
            this.mainPanelAdding.Controls.Add(this.buttonAddArchieve);
            this.mainPanelAdding.Controls.Add(this.textReason);
            this.mainPanelAdding.Controls.Add(this.label1);
            this.mainPanelAdding.Controls.Add(this.pictureBox1);
            this.mainPanelAdding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelAdding.Location = new System.Drawing.Point(0, 0);
            this.mainPanelAdding.Name = "mainPanelAdding";
            this.mainPanelAdding.Size = new System.Drawing.Size(284, 261);
            this.mainPanelAdding.TabIndex = 0;
            // 
            // pictureInfo
            // 
            this.pictureInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureInfo.Image = global::Interpol.Properties.Resources.info;
            this.pictureInfo.Location = new System.Drawing.Point(3, 3);
            this.pictureInfo.Name = "pictureInfo";
            this.pictureInfo.Size = new System.Drawing.Size(46, 46);
            this.pictureInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureInfo.TabIndex = 4;
            this.pictureInfo.TabStop = false;
            this.pictureInfo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureInfo_MouseClick);
            this.pictureInfo.MouseEnter += new System.EventHandler(this.pictureInfo_MouseEnter);
            this.pictureInfo.MouseLeave += new System.EventHandler(this.pictureInfo_MouseLeave);
            // 
            // buttonAddArchieve
            // 
            this.buttonAddArchieve.BackColor = System.Drawing.Color.Moccasin;
            this.buttonAddArchieve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddArchieve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonAddArchieve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonAddArchieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddArchieve.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddArchieve.Image = global::Interpol.Properties.Resources.reason;
            this.buttonAddArchieve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddArchieve.Location = new System.Drawing.Point(66, 214);
            this.buttonAddArchieve.Name = "buttonAddArchieve";
            this.buttonAddArchieve.Size = new System.Drawing.Size(150, 40);
            this.buttonAddArchieve.TabIndex = 3;
            this.buttonAddArchieve.Text = "    Добавить";
            this.buttonAddArchieve.UseVisualStyleBackColor = false;
            this.buttonAddArchieve.Click += new System.EventHandler(this.buttonAddArchieve_Click);
            // 
            // textReason
            // 
            this.textReason.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textReason.Location = new System.Drawing.Point(35, 155);
            this.textReason.MaxLength = 50;
            this.textReason.Multiline = true;
            this.textReason.Name = "textReason";
            this.textReason.Size = new System.Drawing.Size(222, 53);
            this.textReason.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(71)))), ((int)(((byte)(105)))));
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(36, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите причину";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interpol.Properties.Resources.interpol_logo;
            this.pictureBox1.Location = new System.Drawing.Point(80, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Reason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.mainPanelAdding);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Reason";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding to Archieve";
            this.mainPanelAdding.ResumeLayout(false);
            this.mainPanelAdding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanelAdding;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureInfo;
        private System.Windows.Forms.Button buttonAddArchieve;
        private System.Windows.Forms.TextBox textReason;
    }
}