using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strrings
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
            if( textBox1.Text != string.Empty ) listBox1.Items.Add(textBox1.Text); textBox1.Text = string.Empty;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            if(textBox2.Text != string.Empty && textBox2.Text.All(char.IsDigit))
            {
                if (Convert.ToInt32(textBox2.Text) > 0)
                {
                    if(Convert.ToInt32(textBox2.Text) <= listBox1.Items.Count)
                    {
                        richTextBox1.Text = string.Empty;
                        string[] starr = listBox1.Items.Cast<string>().ToArray();
                        int k = Convert.ToInt32(textBox2.Text);
                        string text = ""; string str = "";
                        int[] len = new int[starr.Length - k + 1];
                        string[] starrs = new string[starr.Length - k + 1];
                        for (int i = 0; i <= starr.Length - k; i++)
                        {
                            for (int j = i; j < i + k; j++)
                            {
                                str += starr[j];
                            }
                            starrs[i] = str;
                            len[i] = str.Length;
                            text = $"{str} (длина {str.Length})";
                            richTextBox1.Text += text + "\n";
                            str = "";
                            text = "";
                        }


                        richTextBox1.Text += $"Самые длинные строки: ";
                        foreach (string st in starrs)
                        {
                            if (st.Length == len.Max()) richTextBox1.Text += st + "    ";
                        }
                    }
                    else richTextBox1.Text = "Задайте k в пределах кол-ва элементов!";
                }
                else richTextBox1.Text = "Задайте k положительным числом!";

            }
            else richTextBox1.Text = "Вы не задали k!";
        }
    }
}
