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
    public partial class FormAskQuestion : Form
    {        
        public FormAskQuestion()
        {
            InitializeComponent();
            textBoxTitle.Enabled = false;
            comboBoxSubject.Enabled = false;
            comboBoxTeacher.Enabled = false;
            comboBoxPrio.Enabled = false;
            checkBoxStep3j.Enabled = false;
            checkBoxStep3n.Enabled = false;
            checkBoxStep4j.Enabled = false;
            checkBoxStep4n.Enabled = false;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CheckBoxStep3j_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxStep3j.Checked)
            {
              textBoxQuestion1.Visible = false;
              labeltextBox2.Visible = false;
            }

            if (checkBoxStep3j.Checked)
            {
                checkBoxStep3n.Checked = false;
                textBoxQuestion1.Visible = true;
                labeltextBox2.Visible = true;
            }

        }

        private void CheckBoxStep3n_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStep3n.Checked)
            {
                checkBoxStep3j.Checked = false;
                MessageBox.Show(" Je dient eerst zelf stappen te ondernemen voordat je verder kunt");
            }

        }

        private void CheckBoxStep4j_CheckedChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxQuestion1.Text))
            {
                MessageBox.Show("Stap 3 dient nog ingevuld te worden");
                textBoxQuestion2.Enabled = false;
                checkBoxStep4j.Checked = false;

            }

            else
            {
                textBoxQuestion2.Enabled = true;
            }


            if (!checkBoxStep4j.Checked)
            {
                textBoxQuestion2.Visible = false;
                labeltextBox3.Visible = false;
            }

            else if (checkBoxStep4j.Checked)
            {
                checkBoxStep4n.Checked = false;
                textBoxQuestion2.Visible = true;
                labeltextBox3.Visible = true;
            }

            if (checkBoxStep4j.Checked && checkBoxStep3j.Checked)
            {
                buttonConfirm.Visible = true;
            }

            else
            {
                buttonConfirm.Visible = false;
            }
        }

        private void CheckBoxStep4n_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStep4n.Checked)
            {
                checkBoxStep4j.Checked = false;
                MessageBox.Show("Je dient eerst een ander student om hulp te vragen voordat je verder kunt");
            }                           
        }
        private void ButtonConfirm_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBoxQuestion2.Text))
            {
                MessageBox.Show("Stap 4 dient nog ingevuld te worden");
            }

            else
            {
                var userName = new Model.UserModel();
                QuestionHelper.SetQuestion("", "", false, textBoxTitle.Text, textBoxSubject.Text, comboBoxSubject.SelectedItem.ToString(), comboBoxTeacher.SelectedItem.ToString(), comboBoxPrio.SelectedItem.ToString(), textBoxQuestion1.Text, textBoxQuestion2.Text, "", userName.Name + userName.SurName, "", true);
                MessageBox.Show("Weet u zeker dat u deze vraag wilt bevestiggen");
            }
      
        }

        private void TextBoxSubject_MouseLeave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSubject.Text))
            {
                textBoxTitle.Enabled = true;
            }

            else
            {
                textBoxTitle.Enabled = false;
                MessageBox.Show("Je moet eerst een vak selecteren");
            }
        }

        private void TextBoxTitle_MouseLeave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxTitle.Text))
            {
                comboBoxSubject.Enabled = true;
            }

            else
            {
                comboBoxSubject.Enabled = false;
            }
        }

        private void ComboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSubject.SelectedIndex > -1)
            {
                comboBoxTeacher.Enabled = true;
            }

            else
            {
                comboBoxTeacher.Enabled = false;
            }
        }

        private void ComboBoxTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTeacher.SelectedIndex > -1)
            {
                comboBoxPrio.Enabled = true;
            }

            else
            {
                comboBoxPrio.Enabled = false;
            }
        }

        private void ComboBoxPrio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPrio.SelectedIndex > -1)
            {
                checkBoxStep3j.Enabled = true;
                checkBoxStep3n.Enabled = true;
            }

            else
            {
                checkBoxStep3j.Enabled = false;
                checkBoxStep3n.Enabled = false;
            }
        }

        private void TextBoxSubject_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxSubject.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Het is niet mogelijk om cijfers in te vullen");
                textBoxSubject.Text = "";
            }
        }

        private void TextBoxTitle_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxTitle.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("Het is niet mogelijk om cijfers in te vullen");
                textBoxTitle.Text = "";
            }
        }
    }
}
