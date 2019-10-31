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
using Newtonsoft.Json;

namespace QueApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            SetQuestionsInPanel();
            panelQuestions.AutoScrollMinSize = new Size(0, 1700);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            panelMenu.Height = buttonHome.Height;
            position(buttonHome);
        }

        private void position(Button b)
        {
            panelMenu.Location = new Point(b.Location.X - panelMenu.Width, b.Location.Y);
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAskQuestion_Click(object sender, EventArgs e)
        {
            position(buttonAskQuestion);
            FormAskQuestion formLogin = new FormAskQuestion();
            formLogin.ShowDialog();
        }

        private void buttonMyQuestions_Click(object sender, EventArgs e)
        {
            position(buttonMyQuestions);
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            position(buttonHome);
        }

        private void SetQuestionsInPanel()
        {

            string responseString = QuestionHelper.GetQuestion();
            var questions = JsonConvert.DeserializeObject<List<Model.QuestionModel>>(responseString);
            var rowNr = 0;


            foreach (var question in questions)
            {
                UserControlQuestions ucQuestion = new UserControlQuestions();

                ucQuestion.PartitionKey = question.PartitionKey;
                ucQuestion.RowKey = question.RowKey;
                ucQuestion.Title = question.Title;
                ucQuestion.Description = question.Description;
                ucQuestion.Category1 = question.Category1;
                ucQuestion.Category2 = question.Category2;
                ucQuestion.Category3 = question.Category3;
                ucQuestion.Question1 = question.Question1;
                ucQuestion.Question2 = question.Question2;
                ucQuestion.Answer = question.Answer;
                ucQuestion.AskedBy = question.AskedBy;
                ucQuestion.AnsweredBy = question.AnsweredBy;
                ucQuestion.AskedDateTime = question.AskedDateTime;
                ucQuestion.AnsweredDateTime = question.AnsweredDateTime;
                ucQuestion.Top = 300 * rowNr;

                panelQuestions.Controls.Add(ucQuestion);

                rowNr++;
            }
        }


    }
}
