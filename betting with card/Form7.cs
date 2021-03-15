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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public static int left;
        public static int right;
        public static bool result;
        public static string dir;
        public static string bet;
        public static int count;
        public static int trial;
        private int _timer5;
        Form8 form8 = new Form8();

        Form3 form3;
        
        Form4 form4;
        private void Form7_Load(object sender, EventArgs e)
        {
            progressBar5.Step = 100;
            timer5.Start();
            _timer5 = 0;
            this.WindowState = FormWindowState.Maximized;
            
            if ((left < right) || (bet==" "))//lose
            {
                if (result)//-5
                {
                    label1.Text = "-$5";
                }
                else//-20
                {
                    label1.Text = "-$20";
                }
                pictureBox1.Image = Properties.Resources.minusdollar;
            }
            else if(left > right)//win
            {
                if (result)//+5
                {
                    label1.Text = "+$5";
                }
                else//+20
                {
                    label1.Text = "+$20";
                }
                pictureBox1.Image = Properties.Resources.plusdollar;
            }
            else
            {
                label1.Text = "Draw";
                pictureBox1.Image = Properties.Resources.dollars;
            }
            File.AppendAllText(dir, "\t|\t" + label1.Text, Encoding.Default);
            label2.Text = count.ToString() + "/"+trial.ToString();
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            progressBar5.PerformStep();
            _timer5++;
            if (_timer5 == 13)
            {
                /*if (form3 != null)
                    form3 = null;*/
                if (form3 == null)//if form 4 instance doesn't exist, make new instance
                    //reason:if not giving condition, it keeps making form4 instance->makes infinity loop
                    form3 = new Form3();
                    //form4 = new Form4();
                if (count == trial)
                {
                    form8.Show();//다음으로 넘어가기
                }
                else
                {
                    count++;
                    Form4.count = count;
                    form3.Show();
                }
                this.Close();
            }
        }
    }
}
