using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QueApp
{
    public partial class FormLoading : Form
    {
       
        public FormLoading()
        {
            InitializeComponent();
          
        }

        private void TimerLoad_Tick(object sender, EventArgs e)
        {
            panelLoad2.Width += 2;
            if (panelLoad2.Width >= 700)
            {
                timerLoad.Stop();
                FormLogin formLogin = new FormLogin();
                formLogin.ShowDialog();
                this.Hide();
            }
        }
    }
}
