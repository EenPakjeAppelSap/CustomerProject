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
            this.panelQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBackGround1.SuspendLayout();
            this.panelBackGround2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackGround1
            // 
            this.panelBackGround1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBackGround1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelBackGround1.Controls.Add(this.panelMenu);
            this.panelBackGround1.Controls.Add(this.buttonAskQuestion);
            this.panelBackGround1.Controls.Add(this.buttonLogout);
            this.panelBackGround1.Controls.Add(this.panelProfile);
            this.panelBackGround1.Controls.Add(this.buttonMyQuestions);
            this.panelBackGround1.Controls.Add(this.buttonHome);
            this.panelBackGround1.Location = new System.Drawing.Point(-1, 0);
            this.panelBackGround1.Name = "panelBackGround1";
            this.panelBackGround1.Size = new System.Drawing.Size(262, 634);
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
            this.buttonAskQuestion.Location = new System.Drawing.Point(29, 246);
            this.buttonAskQuestion.Name = "buttonAskQuestion";
            this.buttonAskQuestion.Size = new System.Drawing.Size(197, 47);
            this.buttonAskQuestion.TabIndex = 5;
            this.buttonAskQuestion.Text = "Stel een vraag";
            this.buttonAskQuestion.UseVisualStyleBackColor = true;
            this.buttonAskQuestion.Click += new System.EventHandler(this.ButtonAskQuestion_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogout.Location = new System.Drawing.Point(38, 570);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(120, 50);
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
            this.panelProfile.Size = new System.Drawing.Size(262, 144);
            this.panelProfile.TabIndex = 0;
            // 
            // buttonMyQuestions
            // 
            this.buttonMyQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyQuestions.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMyQuestions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMyQuestions.Location = new System.Drawing.Point(29, 335);
            this.buttonMyQuestions.Name = "buttonMyQuestions";
            this.buttonMyQuestions.Size = new System.Drawing.Size(197, 47);
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
            this.buttonHome.Size = new System.Drawing.Size(197, 47);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // panelBackGround2
            // 
            this.panelBackGround2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBackGround2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelBackGround2.Controls.Add(this.panelQuestions);
            this.panelBackGround2.Location = new System.Drawing.Point(261, 0);
            this.panelBackGround2.Name = "panelBackGround2";
            this.panelBackGround2.Size = new System.Drawing.Size(1195, 634);
            this.panelBackGround2.TabIndex = 3;
            // 
            // panelQuestions
            // 
            this.panelQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQuestions.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelQuestions.Location = new System.Drawing.Point(1, 145);
            this.panelQuestions.Margin = new System.Windows.Forms.Padding(2);
            this.panelQuestions.Name = "panelQuestions";
            this.panelQuestions.Size = new System.Drawing.Size(1192, 489);
            this.panelQuestions.TabIndex = 59;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1453, 633);
            this.Controls.Add(this.panelBackGround2);
            this.Controls.Add(this.panelBackGround1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelBackGround1.ResumeLayout(false);
            this.panelBackGround2.ResumeLayout(false);
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
        public System.Windows.Forms.FlowLayoutPanel panelQuestions;
    }
}
