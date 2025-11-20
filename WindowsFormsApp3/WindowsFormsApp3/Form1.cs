using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize, final, devam;
            double ort;

            textBox3.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox1.BackColor = Color.White;

            if (textBox3.Text == "")
            {
                textBox3.BackColor = Color.Orange;
                MessageBox.Show("Vizeyi Giriniz!", "Veri Girişi");
                textBox3.Focus();
            }

            else if (textBox2.Text == "")
            {
                textBox2.BackColor = Color.Orange;
                MessageBox.Show("Finali Giriniz!", "Veri Girişi");
                textBox2.Focus();
            }
            else if (textBox1.Text == "")
            {
                textBox1.BackColor = Color.Orange;
                MessageBox.Show("Devamsızlığı Giriniz!", "Veri Girişi");
                textBox1.Focus();
            }
            else
            {
                vize=Convert.ToInt32(textBox3.Text);
                final=Convert.ToInt32(textBox2.Text);
                devam=Convert.ToInt32(textBox1.Text);
                ort=vize*0.4+final*0.6;
                textBox5.Text= ort.ToString();

                if (ort < 55 || devam>3)
                {
                    textBox4.Text="kaldı";
                }
                else 
                {
                    textBox4.Text="geçti";
                }
                if (ort>=90)
                {
                    textBox7.Text="aa";
                }
                else if(ort>=85)
                {
                    textBox7.Text="ba";
                }
                else if(ort>=75)
                {
                    textBox7.Text="bb";
                }
                else if (ort>=65)
                {
                    textBox7.Text="cb";
                }
                else if (ort>=60)
                {
                    textBox7.Text="cc";
                }
                else if (ort>=55)
                {
                    textBox7.Text="dc";
                }
                else if (ort>=50)
                {
                    textBox7.Text="dd";
                }
                else if (ort>=40)
                {
                    textBox7.Text="fd";
                }
                else if (ort>=0)
                {
                    textBox7.Text="ff";
                }


            }
            


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
