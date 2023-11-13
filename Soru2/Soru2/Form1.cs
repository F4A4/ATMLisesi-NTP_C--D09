using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Soru2
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
        public string soruıkı(string metin,string deger)
        {
            string sonuc;
            if (deger == "Büyük Yaz")
            {
                sonuc=metin.ToUpper();
            }
            else if(deger=="Küçük Yaz")
            {
                sonuc=metin.ToLower();
            }
            else
            {
                return metin;
            }
            return sonuc;
         }

        private void button1_Click(object sender, EventArgs e)
        {
           textBox1.Text = soruıkı(textBox2.Text, listBox1.Text);
        }
    }
}
