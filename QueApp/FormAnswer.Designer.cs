namespace QueApp
{
    partial class FormAnswer
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
            this.panelAnswer = new System.Windows.Forms.Panel();
            this.buttonConfirmAnswer = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.panelAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAnswer
            // 
            this.panelAnswer.BackColor = System.Drawing.Color.LightGray;
            this.panelAnswer.Controls.Add(this.labelId);
            this.panelAnswer.Controls.Add(this.buttonConfirmAnswer);
            this.panelAnswer.Controls.Add(this.buttonCancel);
            this.panelAnswer.Controls.Add(this.buttonMinus);
            this.panelAnswer.Controls.Add(this.buttonClose);
            this.panelAnswer.Location = new System.Drawing.Point(0, 0);
            this.panelAnswer.Name = "panelAnswer";
            this.panelAnswer.Size = new System.Drawing.Size(1109, 628);
            this.panelAnswer.TabIndex = 0;
            // 
            // buttonConfirmAnswer
            // 
            this.buttonConfirmAnswer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonConfirmAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmAnswer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConfirmAnswer.Location = new System.Drawing.Point(838, 569);
            this.buttonConfirmAnswer.Name = "buttonConfirmAnswer";
            this.buttonConfirmAnswer.Size = new System.Drawing.Size(187, 45);
            this.buttonConfirmAnswer.TabIndex = 26;
            this.buttonConfirmAnswer.Text = "Bevestig antwoord";
            this.buttonConfirmAnswer.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancel.Location = new System.Drawing.Point(35, 569);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(121, 45);
            this.buttonCancel.TabIndex = 25;
            this.buttonCancel.Text = "Annuleer";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMinus.Location = new System.Drawing.Point(954, -3);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(75, 42);
            this.buttonMinus.TabIndex = 3;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClose.Location = new System.Drawing.Point(1029, -3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 42);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // labelId
            // 
            this.labelId.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelId.Location = new System.Drawing.Point(3, 9);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(39, 25);
            this.labelId.TabIndex = 27;
            this.labelId.Text = "id";
            // 
            // FormAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 627);
            this.Controls.Add(this.panelAnswer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAnswer";
            this.Text = "FormAnswer";
            this.panelAnswer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAnswer;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonConfirmAnswer;
        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.Label labelId;
    }
}
