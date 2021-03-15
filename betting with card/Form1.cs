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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        string gender = "Male";
        int age;
        int trial;
        string dir = @"\Users\" + SystemInformation.UserName + @"\Desktop\";


        private String name;
        int count = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            name=textBox1.Text;
            int age = comboBox1.SelectedIndex+1;
            
            DateTime thisDay = DateTime.Now;
            Form3 form = new Form3();
            
            dir = dir + name+thisDay.ToString("_yyyy_MM_dd_HH_mm")+".txt";
            if(File.Exists(dir))
            {
                File.Delete(dir);
            }
            File.AppendAllText(dir,"Name : "+name + " / " + "Age : "+age + " / " +"Gender : "+ gender + "\nDate : "+thisDay.ToString("yyyy-MM-dd HH:mm")+"\n", Encoding.Default);
            File.AppendAllText(dir, "===============================================================================\n", Encoding.Default);
            File.AppendAllText(dir, "       Trial    |    Face Up\t|      FaceDown\t|\tBet\t|        Result", Encoding.Default);
            Form4.dir = dir;
            dir= @"\Users\"+SystemInformation.UserName+@"\Desktop\";
            Form4.count = count;
            Form7.count = count;
            Form7.trial = trial;
            form.Show();
            tableLayoutPanel1.Controls.Clear();
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";   
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            age = int.Parse(comboBox1.SelectedItem.ToString());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            trial = int.Parse(comboBox2.SelectedItem.ToString());
        }
    }
}
