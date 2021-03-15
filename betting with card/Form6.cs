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
    
    public partial class Form6 : Form
    {
        private int _timer4;
        int right;
        public static int left;
        public static Image[] arrImage;
        
        Form7 form7 = new Form7();
        public static string dir;
        public static string bet;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            progressBar4.Step = 100;
            timer4.Start();
            _timer4 = 0;
            Random ran = new Random();
            right = ran.Next(1, 6);
            
            pictureBox1.Image=arrImage[left/2 - 1];
            pictureBox2.Image = arrImage[right - 1];
            right = right * 2;
            File.AppendAllText(dir, "\t|\t" + left.ToString() + "\t|\t" + right.ToString() + "\t|\t" + bet, Encoding.Default);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.PerformStep();
            _timer4++;
            if (_timer4 == 4)
            {
                Form7.left = left;
                Form7.right = right;
                Form7.dir = dir;
                Form7.bet = bet;
                form7.Show();
                this.Close();
            }
        }
    }
}
