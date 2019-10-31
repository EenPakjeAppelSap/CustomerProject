namespace QueApp
{
    partial class FormLogin
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
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxUsername = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(649, 215);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(225, 26);
            this.textBoxEmail.TabIndex = 2;
            this.textBoxEmail.Click += new System.EventHandler(this.TextBoxUsername_Click);
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelUsername.Location = new System.Drawing.Point(594, 244);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(331, 3);
            this.panelUsername.TabIndex = 3;
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelPassword.Location = new System.Drawing.Point(594, 362);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(331, 3);
            this.panelPassword.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(649, 333);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(225, 26);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.Click += new System.EventHandler(this.TextBoxPassword_Click);
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = global::QueApp.Properties.Resources._698630_icon_114_lock_512;
            this.pictureBoxPassword.Location = new System.Drawing.Point(594, 307);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(49, 52);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPassword.TabIndex = 4;
            this.pictureBoxPassword.TabStop = false;
            // 
            // pictureBoxUsername
            // 
            this.pictureBoxUsername.Image = global::QueApp.Properties.Resources.no_user;
            this.pictureBoxUsername.Location = new System.Drawing.Point(594, 189);
            this.pictureBoxUsername.Name = "pictureBoxUsername";
            this.pictureBoxUsername.Size = new System.Drawing.Size(49, 52);
            this.pictureBoxUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUsername.TabIndex = 1;
            this.pictureBoxUsername.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QueApp.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 638);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(594, 381);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 35);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(681, 174);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 21);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(681, 290);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(76, 21);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Password";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 598);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.pictureBoxPassword);
            this.Controls.Add(this.panelUsername);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.pictureBoxUsername);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxUsername;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
    }
}
