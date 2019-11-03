using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QueApp
{
    public partial class FormAnswer : Form
    {
        public FormAnswer()
        {
            InitializeComponent();
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonConfirmAnswer_Click(object sender, EventArgs e)
        {
            QuestionHelper.SetQuestion(labelRowKey.Text, labelPartitionKey.Text, true, textBoxTitle.Text, textBoxQuestion.Text, labelCategory1.Text, labelCategory2.Text, labelCategory3.Text, textBoxQuestion1.Text, textBoxQuestion2.Text, textBoxAnswer.Text, textBoxAskedBy.Text, Helpers.GlobalVariables.GlobalVar, false);
            MessageBox.Show("Vraag beantwoord voor:" + textBoxAskedBy.Text);
            this.Close();
            FormMain.SetQuestionsInPanel();
        }
    }
}

