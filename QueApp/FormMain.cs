using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            //Thread trd = new Thread(new ThreadStart(formRun));
            //trd.Start();
            //Thread.Sleep(5000);
            InitializeComponent();
            //trd.Abort();
        }

        private void formRun()
        {
            Application.Run(new FormLoading2());
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
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void ButtonAskQuestion_Click(object sender, EventArgs e)
        {
            position(buttonAskQuestion);
            FormAskQuestion formLogin = new FormAskQuestion();
            formLogin.Show();
        }

        private void buttonMyQuestions_Click(object sender, EventArgs e)
        {
            position(buttonMyQuestions);
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            position(buttonHome);
        }
    }
}
