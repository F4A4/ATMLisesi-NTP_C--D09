using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Soru1
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
        private void button1_Click(object sender, EventArgs e)
        {
            sorubir("HOŞGELDİN ");
            sorubir(textBox1.Text,false);
            sorubir("hoşgeldiniz ", true);
            
        }
        public void sorubir(string metin)
        {
            MessageBox.Show(metin);
          
         }
        public void sorubir(string deger,bool metin)
        {
            if (metin==true)
            {
                MessageBox.Show(deger.ToUpper());
                
            }
            else if (metin==false)
            {
                 MessageBox.Show(deger.ToLower());
            }
            else
            {
                MessageBox.Show(deger.ToString());
            }
           
        }

       

    }
}
