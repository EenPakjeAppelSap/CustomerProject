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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void TextBoxUsername_Click(object sender, EventArgs e)
        {
            textBoxPassword.Clear();
            pictureBoxUsername.BackgroundImage = Properties.Resources.no_user;
            textBoxUsername.ForeColor = Color.FromArgb(97, 166, 186);
            panelUsername.BackColor = Color.FromArgb(97, 166, 186);
        }

        private void TextBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.Clear();
            textBoxPassword.PasswordChar = '*';
            pictureBoxPassword.BackgroundImage = Properties.Resources.no_user;
            panelPassword.ForeColor = Color.FromArgb(97, 166, 186);
            panelPassword.BackColor = Color.FromArgb(97, 166, 186);
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            FormLoading2 formLogin = new FormLoading2();
            formLogin.Show();
            this.Hide();
        }
    }
}
