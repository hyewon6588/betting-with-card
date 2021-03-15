using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace betting_with_card
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int _timer3;
        
        bool result;
        bool next;
        public static string dir;
        string bet;
        Form6 form6 = new Form6();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            next = true;
            result = true;
            Form7.result = result;
            Form6.dir = dir;
            bet = "$5";
            Form6.bet = bet;
            form6.Show();
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            progressBar3.Step = 100;
            timer3.Start();

            _timer3 = 0;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.PerformStep();
            _timer3++;
            if (!(next))
            {
                if (_timer3 == 11)
                {
                    Random ran = new Random();
                    next = true;
                    result = Convert.ToBoolean(ran.Next(0,2));
                    Form7.result = result;
                    Form6.dir = dir;
                    bet = " ";
                    Form6.bet = bet;
                    form6.Show();
                    this.Close();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            next = true;
            result = false;
            Form7.result = result;
            Form6.dir = dir;
            bet = "$20";
            Form6.bet = bet;
            form6.Show();
            this.Close();

        }
    }
}
