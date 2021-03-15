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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private int _timer2=0;
        private int left;
        Form5 form5 = new Form5();
        
        Image[] arrImage = {Properties.Resources.Spade2,
                            Properties.Resources.Spade4,
                            Properties.Resources.Spade6,
                            Properties.Resources.Spade8,
                            Properties.Resources.Spade10};
        public static string dir;
        public static int count;
        private void Form4_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            timer2.Start();
            progressBar2.Step = 1000;
            
            Random ran = new Random();
            left = ran.Next(1, 6);
            pictureBox1.Image = arrImage[left-1];
            left = left * 2;
            File.AppendAllText(dir, "\n\t" + count.ToString(), Encoding.Default);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            _timer2++;
            progressBar2.PerformStep();
            if (_timer2 == 4)
            {
                Form6.left = left;
                Form6.arrImage = arrImage;
                Form5.dir = dir;
                form5.Show();
                this.Close();
            }
        }
    }
}
