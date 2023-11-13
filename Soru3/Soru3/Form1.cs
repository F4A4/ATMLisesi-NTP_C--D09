using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Soru3
    
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public int UsAlma(int sayi)
        {

            return sayi * sayi;

        }
        public int UsAlma(int sayi1, int usal)
        {
            int sonuc=1;
            for (int i = 0;  i< usal; i++)
            {
                sonuc = sonuc * sayi1; 
            }
            return sonuc;
        }

        private void button1_Click(object sender, EventArgs e)
        {   //int sayı = Int32.Parse(textBox1.Text);
            //textBox1.Text = UsAlma(sayı).ToString();
            //int S1 = UsAlma(5);
            //MessageBox.Show(S1.ToString());
            //int S2 = UsAlma(2, 4);
            //MessageBox.Show(S2.ToString());


            if (textBox2.Text != "")
            {
                int s2 = UsAlma(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text));
                textBox3.Text = s2.ToString();
            }
            else
            {
                int s1 = UsAlma(Int32.Parse(textBox1.Text));
                textBox3.Text = s1.ToString();
            }

        }
    }
}
