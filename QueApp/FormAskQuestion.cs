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
            if (!checkBoxStep4j.Checked)
            {
                textBoxQuestion2.Visible = false;
                labeltextBox3.Visible = false;
            }

            if (checkBoxStep4j.Checked)
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
            var userName = new Model.UserModel();
            QuestionHelper.SetQuestion("", "", false, textBoxTitle.Text, textBoxQuestion.Text, comboBoxSubject.SelectedItem.ToString(), comboBoxTeacher.SelectedItem.ToString(), comboBoxPrio.SelectedItem.ToString(), textBoxQuestion1.Text, textBoxQuestion2.Text, "", Helpers.GlobalVariables.GlobalVar, "", true);
            MessageBox.Show("Vraag gesteld aan:" + comboBoxTeacher.SelectedItem.ToString());            
            this.Close();
        }
    }
}
