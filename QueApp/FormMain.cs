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
            panelQuestions.AutoScrollMinSize = new Size(0, 1700);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SetQuestionsInPanel();
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

        public void SetQuestionsInPanel()
        {
            panelQuestions.Controls.Clear();

            string responseString = QuestionHelper.GetQuestion();
            var questions = JsonConvert.DeserializeObject<List<Model.QuestionModel>>(responseString);
            var rowNr = 0;


            foreach (var question in questions)
            {                
                UserControlQuestions ucQuestion = new UserControlQuestions();
                if (question.IsActive == true)
                {
                    ucQuestion.checkBoxDone.Enabled = false;
                    ucQuestion.checkBoxDone.Checked = false;
                }
                else
                {
                    ucQuestion.checkBoxDone.Enabled = false;
                    ucQuestion.checkBoxDone.Checked = true;
                }                
                ucQuestion.labelSubject.Text = question.Title;
                ucQuestion.labelStudent.Text = question.AskedBy;
                ucQuestion.labelSchoolSubject.Text = question.Category1;
                ucQuestion.labelTeacher.Text = question.Category2;
                ucQuestion.labelPriority.Text = question.Category3;
                ucQuestion.labelAnsweredBy.Text = question.AnsweredBy;
                ucQuestion.labelPartitionKey.Text = question.PartitionKey;
                ucQuestion.labelRowKey.Text = question.RowKey;
                ucQuestion.labelPartitionKey.Visible = false;
                ucQuestion.labelRowKey.Visible = false;
                ucQuestion.Top = 300 * rowNr;

                panelQuestions.Controls.Add(ucQuestion);

                rowNr++;
            }
        }

        private void ButtonRefreshQuestions_Click(object sender, EventArgs e)
        {
            SetQuestionsInPanel();
        }
    }
}
