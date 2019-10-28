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
    public partial class UserControlAnswerQuestions : UserControl
    {

        public UserControlQuestions UserControlQuestions;

        public UserControlAnswerQuestions()
        {
            InitializeComponent();
            this.textBoxAnswer.AutoSize = false;
            this.textBoxAnswer.Size = new System.Drawing.Size(142, 27);
        }

        public UserControlAnswerQuestions(UserControlQuestions UserControlQuestions)
        {
            this.UserControlQuestions = UserControlQuestions;
            InitializeComponent();
        }

    }
}
