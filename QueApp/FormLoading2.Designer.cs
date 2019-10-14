namespace QueApp
{
    partial class FormLoading2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timerLoading2 = new System.Windows.Forms.Timer(this.components);
            this.panelSlide = new System.Windows.Forms.Panel();
            this.labelWait = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelWait);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 453);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.panelSlide);
            this.panel2.Location = new System.Drawing.Point(202, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 16);
            this.panel2.TabIndex = 0;
            // 
            // timerLoading2
            // 
            this.timerLoading2.Interval = 10;
            this.timerLoading2.Tick += new System.EventHandler(this.TimerLoading2_Tick);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.Coral;
            this.panelSlide.Location = new System.Drawing.Point(224, 0);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(83, 16);
            this.panelSlide.TabIndex = 1;
            // 
            // labelWait
            // 
            this.labelWait.AutoSize = true;
            this.labelWait.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelWait.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWait.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelWait.Location = new System.Drawing.Point(199, 309);
            this.labelWait.Name = "labelWait";
            this.labelWait.Size = new System.Drawing.Size(120, 18);
            this.labelWait.TabIndex = 1;
            this.labelWait.Text = "Loading, data......";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QueApp.Properties.Resources.QuestLine_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(557, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(231, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QueApp.Properties.Resources.tenor;
            this.pictureBox1.Location = new System.Drawing.Point(220, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormLoading2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoading2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoading2";
            this.Load += new System.EventHandler(this.FormLoading2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerLoading2;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Label labelWait;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}