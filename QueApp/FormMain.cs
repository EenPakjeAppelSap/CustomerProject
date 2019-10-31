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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            //panelQuestions.AutoScrollMinSize = new Size(0, 1700);
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
