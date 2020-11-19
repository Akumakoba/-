using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        int[,] array2;
        int[] array1;
        int b;
        int n;
        int k;
        int g;
        int a;
        int q;
        int w;
        int u;
        string s;
        int da;
        int c;
        string text33;
        string we;


        public Form1()
        { InitializeComponent(); }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < a; i++)
            {
                textBox2.Text = textBox2.Text + "\r\n";
                for (int j = 0; j < n; j++)
                {
                    { textBox2.Text = textBox2.Text + "   " + array2[i, j].ToString(); }

                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            n = int.Parse(textBox1.Text);
            array2 = new int[a, n];
            Random random2 = new Random();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array2[i, j] = random2.Next(10);

                }


            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        { textBox3.Text = a.ToString(); }
        private void textBox3_TextChanged(object sender, EventArgs e)
        { a = int.Parse(textBox3.Text); }
        private void button3_Click(object sender, EventArgs e)
        {
            array2 = null;
            textBox2.Text = " ";
        }
        private void label1_Click(object sender, EventArgs e)
        { }
        private void Form1_Load(object sender, EventArgs e)
        { }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            b = int.Parse(textBox4.Text);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            array1 = new int[b];
            Random random3 = new Random();
            for (int i = 0; i < b; i++)
            {
                { array1[i] = random3.Next(10); }

            }
            for (int i = 0; i < b; i++)
            {
                { textBox5.Text = textBox5.Text + "   " + array1[i].ToString(); }
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            k = int.Parse(textBox6.Text);
            k = k - 1;
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        { }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox8.Text = array1[k].ToString();
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            a = int.Parse(textBox7.Text);
            a = a - 1;
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            n = int.Parse(textBox9.Text);
            n = n - 1;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox10.Text = array2[a, n].ToString();
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int q = Convert.ToInt32(textBox10.Text);
            int w = Convert.ToInt32(textBox8.Text);
            u = q * w;
            Text = Convert.ToString(u);
            textBox11.Text = Text.ToString();
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        { }

        private void button8_Click(object sender, EventArgs e)
        {
            var vp = "C:/Users/Коба/Desktop/Farm.txt";
            for (int i = 0; i < a; i++)
            {
                text33 = text33 + "\r\n";
                for (int j = 0; j < n; j++)
                {
                    text33 = text33 + "    " + array2[i, j].ToString();
                }
            }
            File.WriteAllText(vp, text33);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int da;
            int r = 0;
            da = Convert.ToInt32(textBox12.Text);
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (da == array2[i, j])
                    {
                        r++;
                    }
                }
                textBox13.Text = r.ToString();
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        { da = int.Parse(textBox12.Text); }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
        
        
    }
}