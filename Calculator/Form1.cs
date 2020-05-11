using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float a, b;
        int count;
        bool znak = true; //переменная за ввод знака
        
        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text + 0;
                myFocus();
            }
            catch { }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text + ",";
                button18.Enabled = false;
                myFocus();
            }
            catch { }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text + 1;
                myFocus();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text + 2;
                myFocus();
            }
            catch { }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text + 3;
                myFocus();
            }
            catch { }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text + 4;
                myFocus();
            }
            catch { }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text + 5;
                myFocus();
            }
            catch { }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text + 6;
                myFocus();
            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text + 7;
                myFocus();
            }
            catch { }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text + 8;
                myFocus();
            }
            catch { }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text + 9;
                myFocus();
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 1;
                label1.Text = a.ToString() + "+";
                znak = true;
                myFocus();
                button18.Enabled = true;
            }
            catch { }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 2;
                label1.Text = a.ToString() + "-";
                znak = true;
                myFocus();
                button18.Enabled = true;
            }
            catch { }
            }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 3;
                label1.Text = a.ToString() + "*";
                znak = true;
                myFocus();
                button18.Enabled = true;
            }
            catch { }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 4;
                label1.Text = a.ToString() + "/";
                znak = true;
                button18.Enabled = true;
                myFocus();
            }
            catch { }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                button18.Enabled = true;
                znak = false;
                calculate();
                label1.Text = "";
                myFocus();
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimumSize = new Size(250, 250);
            this.MaximumSize = new Size(500, 500);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }

            if (number == 43) // если нажали "+" на клавиатуре
            {
                button4.PerformClick();
            }
            
            if (number == 45) // если нажали "-" на клавиатуре
            {
                button8.PerformClick();
            }

            if (number == 42) // если нажали "*" на клавиатуре
            {
                button12.PerformClick();
            }

            if (number == 47) // если нажали "/" на клавиатуре
            {
                button16.PerformClick();
            }

            if (number == 13) // если нажали "enter" на клавиатуре
            {
                button19.PerformClick();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        /// <summary>
        /// Производим вычисление примера после нажатия "=" или "enter"
        /// </summary>
        private void calculate()
        {
            try{
                switch (count)
                {
                    case 1:
                        b = a + float.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                        break;

                    case 2:
                        b = a - float.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                        break;
                    case 3:
                        b = a * float.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                        break;
                    case 4:
                        b = a / float.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                        break;

                    default:
                        break;
                }
            }catch
            {
                MessageBox.Show("неправильный ввод данных");
                textBox1.Clear();
                label1.Text = "";
            }

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBox1.Text);
        }

        /// <summary>
        /// Передаем фокус textBox1 без выделения текста
        /// </summary>
        private void myFocus()
        {
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }
    }
}
