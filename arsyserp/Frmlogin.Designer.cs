namespace arsyserp
{
    partial class Frmlogin
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
            this.Btnlogin = new Telerik.WinControls.UI.RadButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new Telerik.WinControls.UI.RadLabel();
            this.label1 = new Telerik.WinControls.UI.RadLabel();
            this.Txtpassword = new Telerik.WinControls.UI.RadTextBox();
            this.Txtusername = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Btnlogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtpassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtusername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // Btnlogin
            // 
            this.Btnlogin.Location = new System.Drawing.Point(259, 189);
            this.Btnlogin.Name = "Btnlogin";
            this.Btnlogin.Size = new System.Drawing.Size(64, 31);
            this.Btnlogin.TabIndex = 16;
            this.Btnlogin.Text = "ورود";
            this.Btnlogin.Click += new System.EventHandler(this.Btnlogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::arsyserp.Properties.Resources.falogo2_min;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(64, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(363, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "کلمه عبور";
            this.label2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(362, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "نام کاربری";
            this.label1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // Txtpassword
            // 
            this.Txtpassword.Location = new System.Drawing.Point(252, 149);
            this.Txtpassword.Name = "Txtpassword";
            this.Txtpassword.PasswordChar = '●';
            this.Txtpassword.Size = new System.Drawing.Size(89, 20);
            this.Txtpassword.TabIndex = 12;
            this.Txtpassword.Text = "123";
            this.Txtpassword.UseSystemPasswordChar = true;
            // 
            // Txtusername
            // 
            this.Txtusername.Location = new System.Drawing.Point(252, 95);
            this.Txtusername.Name = "Txtusername";
            this.Txtusername.Size = new System.Drawing.Size(89, 20);
            this.Txtusername.TabIndex = 11;
            this.Txtusername.Text = "123";
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 289);
            this.Controls.Add(this.Btnlogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtpassword);
            this.Controls.Add(this.Txtusername);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Frmlogin";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ایده پردازان عصر اطلاعات آرسس";
            ((System.ComponentModel.ISupportInitialize)(this.Btnlogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtpassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtusername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton Btnlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadLabel label2;
        private Telerik.WinControls.UI.RadLabel label1;
        private Telerik.WinControls.UI.RadTextBox Txtpassword;
        private Telerik.WinControls.UI.RadTextBox Txtusername;
    }
}
