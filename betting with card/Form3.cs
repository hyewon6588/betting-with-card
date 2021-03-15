using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace betting_with_card
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private int _timer1 = 0;
        private int result = 0;
        Form4 form4 = new Form4();
        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Step = 1000;
            this.WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            _timer1++;
            if (result == 0)
            {
                if (_timer1 == 15)
                {
                    form4.Show();
                    this.Close();
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
