using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace QueApp
{
    public partial class UserControlQuestions : UserControl
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category1 { get; set; }
        public string Category2 { get; set; }
        public string Category3 { get; set; }
        public string Question1 { get; set; }
        public string Question2 { get; set; }
        public string Answer { get; set; }
        public string AskedBy { get; set; }
        public string AnsweredBy { get; set; }
        public DateTime AskedDateTime { get; set; }
        public DateTime AnsweredDateTime { get; set; }
        public bool IsActive { get; set; }

        public UserControlQuestions()
        {
            InitializeComponent();
        }


        //private void ButtonAnswer_Click(object sender, EventArgs e)
        //{

        //    //FormAnswer formAnswer = new FormAnswer();
        //    //formAnswer.Show();

        //}

        private void UserControlQuestions_Click(object sender, EventArgs e)
        {
            var ucQuestion = (UserControlQuestions)sender;
            if (ucQuestion.checkBoxDone.Checked == false)
            {
                var question = QuestionHelper.GetQuestionToBeAnswered(ucQuestion.labelPartitionKey.Text);
                FormAnswer formAnswer = new FormAnswer();
                formAnswer.labelRowKey.Text = question.RowKey;
                formAnswer.labelPartitionKey.Text = question.PartitionKey;
                formAnswer.textBoxAskedBy.Text = question.AskedBy;
                formAnswer.textBoxAskedSince.Text = question.AskedDateTime.ToString();
                formAnswer.textBoxQuestion.Text = question.Description;
                formAnswer.textBoxQuestion1.Text = question.Question1;
                formAnswer.textBoxQuestion2.Text = question.Question2;
                formAnswer.textBoxTitle.Text = question.Title;
                formAnswer.labelCategory1.Text = question.Category1;
                formAnswer.labelCategory2.Text = question.Category2;
                formAnswer.labelCategory3.Text = question.Category3;                
                formAnswer.ShowDialog();
                
                //MessageBox.Show(question.Title);
            }
            else
            {
                MessageBox.Show("Vraag is al beantwoord");
            }
        }
    }
}
