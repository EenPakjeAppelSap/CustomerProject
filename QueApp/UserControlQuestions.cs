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
        public UserControlQuestions(FormMain formMain)
        {
            InitializeComponent();
            checkBoxDone.Enabled = false;
        }   
       

        private void ButtonAnswer_Click(object sender, EventArgs e)
        {
            FormAnswer formAnswer = new FormAnswer();
            formAnswer.Show();

        }
    }
}
