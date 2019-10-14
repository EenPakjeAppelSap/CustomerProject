namespace QueApp
{
    partial class FormMain
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
            this.panelBackGround1 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonAskQuestion = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.buttonMyQuestions = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelBackGround2 = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBackGround1.SuspendLayout();
            this.panelBackGround2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackGround1
            // 
            this.panelBackGround1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelBackGround1.Controls.Add(this.panelMenu);
            this.panelBackGround1.Controls.Add(this.buttonAskQuestion);
            this.panelBackGround1.Controls.Add(this.buttonLogout);
            this.panelBackGround1.Controls.Add(this.panelProfile);
            this.panelBackGround1.Controls.Add(this.buttonMyQuestions);
            this.panelBackGround1.Controls.Add(this.buttonHome);
            this.panelBackGround1.Location = new System.Drawing.Point(0, 0);
            this.panelBackGround1.Name = "panelBackGround1";
            this.panelBackGround1.Size = new System.Drawing.Size(200, 634);
            this.panelBackGround1.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(10, 168);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(10, 37);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonAskQuestion
            // 
            this.buttonAskQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAskQuestion.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAskQuestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAskQuestion.Location = new System.Drawing.Point(29, 221);
            this.buttonAskQuestion.Name = "buttonAskQuestion";
            this.buttonAskQuestion.Size = new System.Drawing.Size(160, 37);
            this.buttonAskQuestion.TabIndex = 5;
            this.buttonAskQuestion.Text = "Stel een vraag";
            this.buttonAskQuestion.UseVisualStyleBackColor = true;
            this.buttonAskQuestion.Click += new System.EventHandler(this.ButtonAskQuestion_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogout.Location = new System.Drawing.Point(38, 570);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(115, 37);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Log uit";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelProfile.Location = new System.Drawing.Point(0, 0);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(200, 113);
            this.panelProfile.TabIndex = 0;
            // 
            // buttonMyQuestions
            // 
            this.buttonMyQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyQuestions.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMyQuestions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMyQuestions.Location = new System.Drawing.Point(29, 273);
            this.buttonMyQuestions.Name = "buttonMyQuestions";
            this.buttonMyQuestions.Size = new System.Drawing.Size(160, 37);
            this.buttonMyQuestions.TabIndex = 3;
            this.buttonMyQuestions.Text = "Mijn vragen";
            this.buttonMyQuestions.UseVisualStyleBackColor = true;
            this.buttonMyQuestions.Click += new System.EventHandler(this.buttonMyQuestions_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHome.Location = new System.Drawing.Point(29, 168);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(160, 37);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // panelBackGround2
            // 
            this.panelBackGround2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelBackGround2.Controls.Add(this.textBoxSearch);
            this.panelBackGround2.Controls.Add(this.pictureBox1);
            this.panelBackGround2.Location = new System.Drawing.Point(199, 0);
            this.panelBackGround2.Name = "panelBackGround2";
            this.panelBackGround2.Size = new System.Drawing.Size(1008, 634);
            this.panelBackGround2.TabIndex = 3;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxSearch.Location = new System.Drawing.Point(21, 14);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(164, 19);
            this.textBoxSearch.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QueApp.Properties.Resources._2161479_200;
            this.pictureBox1.Location = new System.Drawing.Point(-295, -76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(811, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1207, 633);
            this.Controls.Add(this.panelBackGround2);
            this.Controls.Add(this.panelBackGround1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelBackGround1.ResumeLayout(false);
            this.panelBackGround2.ResumeLayout(false);
            this.panelBackGround2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackGround1;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panelBackGround2;
        private System.Windows.Forms.Button buttonMyQuestions;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonAskQuestion;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}
