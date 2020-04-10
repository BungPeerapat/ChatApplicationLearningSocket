namespace ChatApplicationLearningSocket
{
    partial class ChatZone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatZone));
            this.tcpserverbotton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tcpserverbotton
            // 
            this.tcpserverbotton.BackColor = System.Drawing.Color.Maroon;
            this.tcpserverbotton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tcpserverbotton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tcpserverbotton.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcpserverbotton.ForeColor = System.Drawing.Color.White;
            this.tcpserverbotton.Location = new System.Drawing.Point(1073, 12);
            this.tcpserverbotton.Name = "tcpserverbotton";
            this.tcpserverbotton.Size = new System.Drawing.Size(51, 27);
            this.tcpserverbotton.TabIndex = 0;
            this.tcpserverbotton.Text = "TCP";
            this.tcpserverbotton.UseVisualStyleBackColor = false;
            // 
            // ChatZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1136, 619);
            this.Controls.Add(this.tcpserverbotton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ChatZone";
            this.Text = "Chat Zone";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tcpserverbotton;
    }
}