namespace ChatApplicationLearningSocket
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.USERNAME = new System.Windows.Forms.TextBox();
            this.MenuZone = new System.Windows.Forms.Panel();
            this.Coronamap = new System.Windows.Forms.WebBrowser();
            this.Permission = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.chatzonebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StatusServer = new System.Windows.Forms.PictureBox();
            this.RealtimeChat = new System.Windows.Forms.TextBox();
            this.ShowStatus = new System.Windows.Forms.Label();
            this.TextAdminSend = new System.Windows.Forms.TextBox();
            this.ASB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MenuZone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusServer)).BeginInit();
            this.SuspendLayout();
            // 
            // USERNAME
            // 
            this.USERNAME.BackColor = System.Drawing.Color.Maroon;
            this.USERNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.USERNAME.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F);
            this.USERNAME.ForeColor = System.Drawing.Color.Transparent;
            this.USERNAME.Location = new System.Drawing.Point(87, 15);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(236, 49);
            this.USERNAME.TabIndex = 0;
            this.USERNAME.Text = "YOURNAME";
            this.USERNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.USERNAME.Visible = false;
            // 
            // MenuZone
            // 
            this.MenuZone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(19)))), ((int)(((byte)(13)))));
            this.MenuZone.Controls.Add(this.Coronamap);
            this.MenuZone.Controls.Add(this.Permission);
            this.MenuZone.Controls.Add(this.bunifuImageButton1);
            this.MenuZone.Controls.Add(this.bunifuFlatButton2);
            this.MenuZone.Controls.Add(this.bunifuFlatButton1);
            this.MenuZone.Controls.Add(this.chatzonebutton);
            this.MenuZone.Controls.Add(this.USERNAME);
            this.MenuZone.Location = new System.Drawing.Point(0, 0);
            this.MenuZone.Name = "MenuZone";
            this.MenuZone.Size = new System.Drawing.Size(82, 603);
            this.MenuZone.TabIndex = 2;
            this.MenuZone.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuZone_Paint);
            // 
            // Coronamap
            // 
            this.Coronamap.Location = new System.Drawing.Point(19, 358);
            this.Coronamap.MinimumSize = new System.Drawing.Size(20, 20);
            this.Coronamap.Name = "Coronamap";
            this.Coronamap.Size = new System.Drawing.Size(304, 218);
            this.Coronamap.TabIndex = 4;
            this.Coronamap.Url = new System.Uri("", System.UriKind.Relative);
            this.Coronamap.Visible = false;
            this.Coronamap.WebBrowserShortcutsEnabled = false;
            this.Coronamap.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Coronamap_DocumentCompleted);
            // 
            // Permission
            // 
            this.Permission.AutoSize = true;
            this.Permission.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Permission.Location = new System.Drawing.Point(84, 67);
            this.Permission.Name = "Permission";
            this.Permission.Size = new System.Drawing.Size(0, 17);
            this.Permission.TabIndex = 3;
            this.Permission.Click += new System.EventHandler(this.Permission_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 15);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(59, 49);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "                      Chat Zone";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 80D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(19, 290);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(304, 52);
            this.bunifuFlatButton2.TabIndex = 1;
            this.bunifuFlatButton2.Text = "                      Chat Zone";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Visible = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "                      Chat Zone";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 80D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(19, 206);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(304, 52);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Text = "                      Chat Zone";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Visible = false;
            // 
            // chatzonebutton
            // 
            this.chatzonebutton.Activecolor = System.Drawing.Color.Green;
            this.chatzonebutton.BackColor = System.Drawing.Color.Maroon;
            this.chatzonebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chatzonebutton.BorderRadius = 0;
            this.chatzonebutton.ButtonText = "                      Chat Zone";
            this.chatzonebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chatzonebutton.DisabledColor = System.Drawing.Color.Gray;
            this.chatzonebutton.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatzonebutton.Iconcolor = System.Drawing.Color.Transparent;
            this.chatzonebutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("chatzonebutton.Iconimage")));
            this.chatzonebutton.Iconimage_right = null;
            this.chatzonebutton.Iconimage_right_Selected = null;
            this.chatzonebutton.Iconimage_Selected = null;
            this.chatzonebutton.IconMarginLeft = 0;
            this.chatzonebutton.IconMarginRight = 0;
            this.chatzonebutton.IconRightVisible = true;
            this.chatzonebutton.IconRightZoom = 0D;
            this.chatzonebutton.IconVisible = true;
            this.chatzonebutton.IconZoom = 80D;
            this.chatzonebutton.IsTab = false;
            this.chatzonebutton.Location = new System.Drawing.Point(19, 118);
            this.chatzonebutton.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.chatzonebutton.Name = "chatzonebutton";
            this.chatzonebutton.Normalcolor = System.Drawing.Color.Maroon;
            this.chatzonebutton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.chatzonebutton.OnHoverTextColor = System.Drawing.Color.White;
            this.chatzonebutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chatzonebutton.selected = false;
            this.chatzonebutton.Size = new System.Drawing.Size(304, 52);
            this.chatzonebutton.TabIndex = 1;
            this.chatzonebutton.Text = "                      Chat Zone";
            this.chatzonebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chatzonebutton.Textcolor = System.Drawing.Color.White;
            this.chatzonebutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatzonebutton.Visible = false;
            this.chatzonebutton.Click += new System.EventHandler(this.chatzonebutton_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.MenuZone;
            this.bunifuDragControl1.Vertical = true;
            // 
            // StatusServer
            // 
            this.StatusServer.BackColor = System.Drawing.Color.Transparent;
            this.StatusServer.Image = global::ChatApplicationLearningSocket.Properties.Resources.Red_Point;
            this.StatusServer.Location = new System.Drawing.Point(890, 12);
            this.StatusServer.Name = "StatusServer";
            this.StatusServer.Size = new System.Drawing.Size(128, 72);
            this.StatusServer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StatusServer.TabIndex = 3;
            this.StatusServer.TabStop = false;
            this.StatusServer.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RealtimeChat
            // 
            this.RealtimeChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(19)))), ((int)(((byte)(13)))));
            this.RealtimeChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RealtimeChat.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.RealtimeChat.ForeColor = System.Drawing.Color.White;
            this.RealtimeChat.Location = new System.Drawing.Point(703, 407);
            this.RealtimeChat.Multiline = true;
            this.RealtimeChat.Name = "RealtimeChat";
            this.RealtimeChat.ReadOnly = true;
            this.RealtimeChat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RealtimeChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RealtimeChat.Size = new System.Drawing.Size(315, 169);
            this.RealtimeChat.TabIndex = 4;
            // 
            // ShowStatus
            // 
            this.ShowStatus.AutoSize = true;
            this.ShowStatus.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowStatus.Location = new System.Drawing.Point(886, 96);
            this.ShowStatus.Name = "ShowStatus";
            this.ShowStatus.Size = new System.Drawing.Size(0, 21);
            this.ShowStatus.TabIndex = 5;
            // 
            // TextAdminSend
            // 
            this.TextAdminSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(19)))), ((int)(((byte)(13)))));
            this.TextAdminSend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextAdminSend.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.TextAdminSend.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextAdminSend.Location = new System.Drawing.Point(703, 358);
            this.TextAdminSend.Multiline = true;
            this.TextAdminSend.Name = "TextAdminSend";
            this.TextAdminSend.Size = new System.Drawing.Size(315, 31);
            this.TextAdminSend.TabIndex = 6;
            this.TextAdminSend.Visible = false;
            // 
            // ASB
            // 
            this.ASB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(19)))), ((int)(((byte)(13)))));
            this.ASB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ASB.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.ASB.ForeColor = System.Drawing.Color.White;
            this.ASB.Location = new System.Drawing.Point(935, 312);
            this.ASB.Name = "ASB";
            this.ASB.Size = new System.Drawing.Size(83, 30);
            this.ASB.TabIndex = 7;
            this.ASB.Text = "SEND";
            this.ASB.UseVisualStyleBackColor = false;
            this.ASB.Visible = false;
            this.ASB.Click += new System.EventHandler(this.ASB_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(922, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Denined";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 588);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ASB);
            this.Controls.Add(this.TextAdminSend);
            this.Controls.Add(this.ShowStatus);
            this.Controls.Add(this.RealtimeChat);
            this.Controls.Add(this.StatusServer);
            this.Controls.Add(this.MenuZone);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "USER : ADMIN";
            this.Load += new System.EventHandler(this.ADMINSIZE_Load);
            this.MenuZone.ResumeLayout(false);
            this.MenuZone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusServer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel MenuZone;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton chatzonebutton;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ShowStatus;
        private System.Windows.Forms.Button ASB;
        private System.Windows.Forms.TextBox TextAdminSend;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox USERNAME;
        public System.Windows.Forms.PictureBox StatusServer;
        public System.Windows.Forms.TextBox RealtimeChat;
        public System.Windows.Forms.WebBrowser Coronamap;
        public System.Windows.Forms.Label Permission;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}