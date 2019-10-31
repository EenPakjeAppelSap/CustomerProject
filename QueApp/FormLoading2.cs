using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueApp
{
    public partial class FormLoading2 : Form
    {
        public FormLoading2()
        {
            InitializeComponent();
            var questions = QuestionHelper.GetQuestion();
        }
        private void FormLoading2_Load(object sender, EventArgs e)
        {
            timerLoading2.Start();
        }
        private void TimerLoading2_Tick(object sender, EventArgs e)
        {
            panelLoad2.Width += 1;
            if (panelLoad2.Width >= 700)
            {
                timerLoading2.Stop();
                FormMain formMain = new FormMain();                
                this.Close();
                formMain.ShowDialog();
            }
        }
    }
}
