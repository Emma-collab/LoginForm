namespace LoginForm
{
    partial class frmLogin
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
            this.pswTxtBox = new System.Windows.Forms.TextBox();
            this.userNameTxtBox = new System.Windows.Forms.TextBox();
            this.Logoutfrm = new System.Windows.Forms.Button();
            this.Loginfrm = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pswTxtBox
            // 
            this.pswTxtBox.Location = new System.Drawing.Point(219, 175);
            this.pswTxtBox.Multiline = true;
            this.pswTxtBox.Name = "pswTxtBox";
            this.pswTxtBox.Size = new System.Drawing.Size(250, 40);
            this.pswTxtBox.TabIndex = 0;
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.Location = new System.Drawing.Point(219, 106);
            this.userNameTxtBox.Multiline = true;
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.Size = new System.Drawing.Size(250, 39);
            this.userNameTxtBox.TabIndex = 1;
            // 
            // Logoutfrm
            // 
            this.Logoutfrm.BackColor = System.Drawing.Color.Moccasin;
            this.Logoutfrm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logoutfrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutfrm.Location = new System.Drawing.Point(359, 261);
            this.Logoutfrm.Name = "Logoutfrm";
            this.Logoutfrm.Size = new System.Drawing.Size(120, 32);
            this.Logoutfrm.TabIndex = 2;
            this.Logoutfrm.Text = "LOGOUT";
            this.Logoutfrm.UseVisualStyleBackColor = false;
            this.Logoutfrm.Click += new System.EventHandler(this.Logoutfrm_Click);
            // 
            // Loginfrm
            // 
            this.Loginfrm.BackColor = System.Drawing.Color.Moccasin;
            this.Loginfrm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Loginfrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginfrm.ForeColor = System.Drawing.Color.Black;
            this.Loginfrm.Location = new System.Drawing.Point(219, 261);
            this.Loginfrm.Name = "Loginfrm";
            this.Loginfrm.Size = new System.Drawing.Size(123, 32);
            this.Loginfrm.TabIndex = 3;
            this.Loginfrm.Text = "LOGIN";
            this.Loginfrm.UseVisualStyleBackColor = false;
            this.Loginfrm.Click += new System.EventHandler(this.Loginfrm_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.Black;
            this.userNameLabel.Location = new System.Drawing.Point(0, 109);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(203, 36);
            this.userNameLabel.TabIndex = 4;
            this.userNameLabel.Text = "USERNAME";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userNameLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "PASSWORD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.Loginfrm);
            this.Controls.Add(this.Logoutfrm);
            this.Controls.Add(this.userNameTxtBox);
            this.Controls.Add(this.pswTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pswTxtBox;
        private System.Windows.Forms.TextBox userNameTxtBox;
        private System.Windows.Forms.Button Logoutfrm;
        private System.Windows.Forms.Button Loginfrm;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label label1;
    }
}

