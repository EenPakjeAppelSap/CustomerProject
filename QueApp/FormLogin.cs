using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            textBoxEmail.ForeColor = Color.FromArgb(97, 166, 186);
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
            if (textBoxPassword.Text != string.Empty && textBoxPassword.Text != string.Empty)
            {
                var user = Helpers.UserHelper.UserLogin(textBoxEmail.Text.ToString(), textBoxPassword.Text.ToString());
                if (user.LoginSucceeded == true)
                {

                    MessageBox.Show("Login Succeeded! " + user.Name + " " + user.SurName);
                    var formLoading2 = new FormLoading2();
                    this.Close();
                    formLoading2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }

            }
            else if (textBoxPassword.Text == string.Empty || textBoxPassword.Text == string.Empty)
            {
                MessageBox.Show("Email or Password are empty. Please fill in!");
            }
        }
    }
}
