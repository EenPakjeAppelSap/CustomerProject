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
        }

        private void FormLoading2_Load(object sender, EventArgs e)
        {
            timerLoading2.Start();
        }

        int move = 2;

        private void TimerLoading2_Tick(object sender, EventArgs e)
        {
            panelSlide.Left += 2;

            if (panelSlide.Left > 250)
            {
                panelSlide.Left = 0;
            }

            if (panelSlide.Left < 0)
            {
                move = 2; 
            }

        }


    }
}
