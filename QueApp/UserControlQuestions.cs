using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueApp
{
    public partial class UserControlQuestions : UserControl
    {
        public UserControlQuestions()
        {
            InitializeComponent();
            checkBoxDone.Enabled = false;
        }


        private void ButtonAnswer_Click(object sender, EventArgs e)
        {
            FormAnswer formAnswer = new FormAnswer();
            formAnswer.Show();

        }

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
    }
}
