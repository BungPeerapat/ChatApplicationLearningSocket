namespace ChatApplicationLearningSocket
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BGLOGIN = new System.Windows.Forms.PictureBox();
            this.USERNAMETEXT = new System.Windows.Forms.TextBox();
            this.PASSWORDTEXT = new System.Windows.Forms.TextBox();
            this.USERNAME = new System.Windows.Forms.Label();
            this.PASSWORD = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SYSTEMDEMOTEXT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BGLOGIN)).BeginInit();
            this.SuspendLayout();
            // 
            // BGLOGIN
            // 
            this.BGLOGIN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BGLOGIN.BackgroundImage")));
            this.BGLOGIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BGLOGIN.Image = ((System.Drawing.Image)(resources.GetObject("BGLOGIN.Image")));
            this.BGLOGIN.Location = new System.Drawing.Point(-3, -7);
            this.BGLOGIN.Name = "BGLOGIN";
            this.BGLOGIN.Size = new System.Drawing.Size(595, 601);
            this.BGLOGIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BGLOGIN.TabIndex = 0;
            this.BGLOGIN.TabStop = false;
            // 
            // USERNAMETEXT
            // 
            this.USERNAMETEXT.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F);
            this.USERNAMETEXT.Location = new System.Drawing.Point(288, 207);
            this.USERNAMETEXT.Name = "USERNAMETEXT";
            this.USERNAMETEXT.Size = new System.Drawing.Size(282, 49);
            this.USERNAMETEXT.TabIndex = 1;
            // 
            // PASSWORDTEXT
            // 
            this.PASSWORDTEXT.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F);
            this.PASSWORDTEXT.Location = new System.Drawing.Point(288, 285);
            this.PASSWORDTEXT.Name = "PASSWORDTEXT";
            this.PASSWORDTEXT.Size = new System.Drawing.Size(282, 49);
            this.PASSWORDTEXT.TabIndex = 1;
            // 
            // USERNAME
            // 
            this.USERNAME.AutoSize = true;
            this.USERNAME.BackColor = System.Drawing.Color.White;
            this.USERNAME.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.USERNAME.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAME.ForeColor = System.Drawing.Color.Maroon;
            this.USERNAME.Location = new System.Drawing.Point(12, 210);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(236, 44);
            this.USERNAME.TabIndex = 2;
            this.USERNAME.Text = "USERNAME : ";
            // 
            // PASSWORD
            // 
            this.PASSWORD.AutoSize = true;
            this.PASSWORD.BackColor = System.Drawing.Color.White;
            this.PASSWORD.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PASSWORD.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD.ForeColor = System.Drawing.Color.Maroon;
            this.PASSWORD.Location = new System.Drawing.Point(2, 285);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(246, 44);
            this.PASSWORD.TabIndex = 2;
            this.PASSWORD.Text = "PASSWORD : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F);
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(197, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 85);
            this.button1.TabIndex = 3;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SYSTEMDEMOTEXT
            // 
            this.SYSTEMDEMOTEXT.AutoSize = true;
            this.SYSTEMDEMOTEXT.BackColor = System.Drawing.Color.White;
            this.SYSTEMDEMOTEXT.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SYSTEMDEMOTEXT.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SYSTEMDEMOTEXT.ForeColor = System.Drawing.Color.Maroon;
            this.SYSTEMDEMOTEXT.Location = new System.Drawing.Point(100, 37);
            this.SYSTEMDEMOTEXT.Name = "SYSTEMDEMOTEXT";
            this.SYSTEMDEMOTEXT.Size = new System.Drawing.Size(400, 75);
            this.SYSTEMDEMOTEXT.TabIndex = 2;
            this.SYSTEMDEMOTEXT.Text = "SYSTEMDEMO";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(587, 589);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.SYSTEMDEMOTEXT);
            this.Controls.Add(this.USERNAME);
            this.Controls.Add(this.PASSWORDTEXT);
            this.Controls.Add(this.USERNAMETEXT);
            this.Controls.Add(this.BGLOGIN);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Account";
            ((System.ComponentModel.ISupportInitialize)(this.BGLOGIN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BGLOGIN;
        private System.Windows.Forms.TextBox USERNAMETEXT;
        private System.Windows.Forms.TextBox PASSWORDTEXT;
        private System.Windows.Forms.Label USERNAME;
        private System.Windows.Forms.Label PASSWORD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label SYSTEMDEMOTEXT;
    }
}

