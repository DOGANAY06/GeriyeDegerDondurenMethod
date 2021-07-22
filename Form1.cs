using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Return_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Toplam(int s1, int s2)
        {
            int s3 = s1 + s2;
            return s3;

        }
        int carpim(int s1,int s2,int s3)
        {
            int s4 = s1 * s2 * s3;
            return s4;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Toplam(2, 5).ToString();
            label1.Text = carpim(2, 1, 3).ToString();
        }

        int kup(int s1) //küp alma metodu
        { 
            return s1 * s1 * s1;
        }
        private void button2_Click(object sender, EventArgs e)
        { //küp hesaplama işlevi yapan buton
            int s1 = Convert.ToInt32(textBox1.Text);
            label2.Text = kup(s1).ToString();
        }

        int carp(int s1,int s2) //girilen sayıları çarpan metod
        {
            return s1 * s2;
        }
        private void button3_Click(object sender, EventArgs e)
        { //carpan buton
            int s1 = Convert.ToInt32(textBox2.Text);
            int s2 = Convert.ToInt32(textBox3.Text);
            label3.Text = carp(s1, s2).ToString();
        }
    }
}
