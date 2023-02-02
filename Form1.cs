using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        private char islem;
        private float sayi;
        private bool temizle;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (temizle)
            {
                textBox1.Text = "";
                temizle = false;
            }
            if (textBox1.Text=="0")textBox1.Text="";
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (temizle)
            {
                textBox1.Text = "";
                temizle = false;
            }
           
            if (textBox1.Text == "0") textBox1.Text = "";

            textBox1.Text += "2";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (temizle)
            {
                textBox1.Text = "";
                temizle = false;
            }

            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (temizle)
            {
                textBox1.Text = "";
                temizle = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        
{
            if (temizle)
            {
                textBox1.Text = "";
                temizle = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (temizle)
            {
                textBox1.Text = "";
                temizle = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (temizle)
            {
                textBox1.Text = "";
                temizle = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (temizle)
            {
                textBox1.Text = "";
                temizle = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (temizle)
            {
                textBox1.Text = "";
                temizle = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (temizle)
            {
                textBox1.Text = "";
                temizle = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            temizle = true;
          
            islem = '+';
       
            sayi = Convert.ToInt32(textBox1.Text);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            temizle = true;
            islem = '-';
            sayi = Convert.ToInt32(textBox1.Text);


        }

        private void button13_Click(object sender, EventArgs e)
        {
            temizle = true;
            islem = 'X';
            sayi = Convert.ToInt32(textBox1.Text);


        }

        private void button14_Click(object sender, EventArgs e)
        {
            temizle = true;
            islem = '/';
            sayi = Convert.ToInt32(textBox1.Text);


        }

        private void button17_Click(object sender, EventArgs e)
        {
            temizle = true;

            islem = 'u';
            sayi=Convert.ToInt32(textBox1.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            temizle = true;
            islem = '%';
            sayi = Convert.ToInt32(textBox1.Text);


        }

        private void button23_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += ",";
        }

        private void button19_Click(object sender, EventArgs e)
        { float ikinciSayi=Convert.ToInt32(textBox1.Text);
            float sonuc=0;
            
            switch (islem)
            {
                case '+':
                    sonuc = sayi + ikinciSayi;
                  
                    break;
                case '-':
                    sonuc=sayi-ikinciSayi;
                    break;
                case '/':
                    sonuc = sayi / ikinciSayi;
                    break;
                case 'X':
                    sonuc = sayi * ikinciSayi;
                    break;
                case '%':
                    sonuc = sayi % ikinciSayi; break;
                case 'u':
                    sonuc = (int)Math.Pow(sayi, ikinciSayi);
                    break;
                case 't':
                   (sonuc) = 1 / sayi;  
                    break;
                case 's':
                    sonuc= (float)Math.Sqrt(sayi);
                   
                    break;


            }
            textBox1.Text = Convert.ToString(sonuc);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            temizle = true;
            islem = 't';     
            sayi= Convert.ToInt32(textBox1.Text);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            temizle = true;
            islem = 's';
            sayi=Convert.ToInt32(textBox1.Text);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.NumPad0) {
                button10.PerformClick();
            }
            if(e.KeyCode== Keys.NumPad1)
            {
                button6.PerformClick();
            }
            if(e.KeyCode== Keys.NumPad2)
            {
                button2.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad3)
            {
                button9.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad4)
            {
                button3.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad5)
            {
                button5.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad6)
            {
                button8.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad7)
            { button1.PerformClick();}
            if (e.KeyCode == Keys.NumPad8)
            {
                button4.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad9)
            {
                button7.PerformClick();
            }
          


        }
    }
}
