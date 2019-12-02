using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 计算器
{
    public partial class Form1 : Form
    {
        private double a = 0, b = 0,answer=0;//运算用的数值
        private bool c = false;//向a、b输入数值
        private int step = 1;//运算步骤
        private string m;//运算结果
        private bool ms = true;//与累加累减等有关
        private bool es = true;//与累加有关
        private int num = 1;//跟删除有关（数据长度？）
        private int pn = 1;//跟删除有关
        private bool pw = true;//与小数点有关
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            if (c == false)
            {
                c = true;
                ms = true;
                es = true;
                textBox1.Text = "1";
                num = 1;
            }
            else
            {
                textBox1.Text += "1";
                num += 1;
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (c == false)
            {
                c = true;
                ms = true;
                es = true;
                textBox1.Text = "2";
                num = 1;
            }
            else
            {
                textBox1.Text += "2";
                num += 1;
            }

        }

        private void three_Click(object sender, EventArgs e)
        {
            if (c == false)
            {
                c = true;
                ms = true;
                es = true;
                textBox1.Text = "3";
                num = 1;
            }
            else
            {
                textBox1.Text += "3";
                num += 1;
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (c == false)
            {
                c = true;
                ms = true;
                es = true;
                textBox1.Text = "4";
                num = 1;
            }
            else
            {
                textBox1.Text += "4";
                num += 1;
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (c == false)
            {
                c = true;
                ms = true;
                es = true;
                textBox1.Text = "5";
                num = 1;
            }
            else
            {
                textBox1.Text += "5";
                num += 1;
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (c == false)
            {
                c = true;
                ms = true;
                es = true;
                textBox1.Text = "6";
                num = 1;
            }
            else
            {
                textBox1.Text += "6";
                num += 1;
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (c == false)
            {
                c = true;
                ms = true;
                es = true;
                textBox1.Text = "7";
                num = 1;
            }
            else
            {
                textBox1.Text += "7";
                num += 1;
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (c == false)
            {
                c = true;
                ms = true;
                es = true;
                textBox1.Text = "8";
                num = 1;
            }
            else
            {
                textBox1.Text += "8";
                num += 1;
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (c == false)
            {
                c = true;
                ms = true;
                es = true;
                textBox1.Text = "9";
                num = 1;
            }
            else
            {
                textBox1.Text += "9";
                num += 1;
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
                num = 1;
            }
            else
            {
                if (c == false)
                {
                    c = true;
                    ms = true;
                    es = true;
                    textBox1.Text = "0";
                    num = 1;
                }
                else
                {
                    textBox1.Text += "0";
                    num += 1;
                }
            }
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (c == false)
            {
                c = true;
                ms = true;
                es = true;
                pw = false;
                textBox1.Text = "0.";
                num = 2;
                pn = num;
            }
            if(c==true && pw == true )
            {
                textBox1.Text += ".";
                pw = false;
                num += 1;
                pn = num;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void plus_Click(object sender, EventArgs e)//加法
        {
            label1.Text = "+";
            pw = true;
            if (step == 1)
            {
                a = double.Parse(textBox1.Text);
                listBox2.Items.Add(a.ToString());
                m = "+";
                listBox2.Items.Add(m.ToString());
                step = 2;
                c = false;
                ms = false;
            }
            else 
            {
                if (ms == true && step == 2)
                {
                    b = double.Parse(textBox1.Text.ToString());
                    switch (m)
                    {
                        case "+":
                            answer = a + b;
                            break;
                        case "-":
                            answer = a - b;
                            break;
                        case "*":
                            answer = a * b;
                            break;
                        case "/":
                            answer = a / b;
                            break;
                    }
                    a = answer;
                    textBox1.Text = a.ToString();
                    m = "+";
                    step = 2;
                    c = false;
                    ms = false;
                }
                else
                {
                    //a = answer;
                    //textBox1.Text = a.ToString();
                    m = "+";
                    step = 2;
                    c = false;
                    ms = false;
                }

            }
        }

        private void minus_Click(object sender, EventArgs e)//减法
        {
            label1.Text = "-";
            pw = true;
            if (step == 1)
            {
                a = double.Parse(textBox1.Text);
                listBox2.Items.Add(a.ToString());
                m = "-";
                listBox2.Items.Add(m.ToString());
                step = 2;
                c = false;
                ms = false;
            }
            else
            {
                if (ms == true && step == 2)
                {
                    b = double.Parse(textBox1.Text.ToString());
                    switch (m)
                    {
                        case "+":
                            answer = a + b;
                            break;
                        case "-":
                            answer = a - b;
                            break;
                        case "*":
                            answer = a * b;
                            break;
                        case "/":
                            answer = a / b;
                            break;
                    }
                    a = answer;
                    textBox1.Text = a.ToString();
                    m = "-";
                    step = 2;
                    c = false;
                    ms = false;
                }
                else
                {
                    //a = answer;
                    //textBox1.Text = a.ToString();
                    m = "-";
                    step = 2;
                    c = false;
                    ms = false;
                }
            }

        }

        private void multiply_Click(object sender, EventArgs e)//乘法
        {
            label1.Text = "×";
            pw = true;
            if (step == 1)
            {
                a = double.Parse(textBox1.Text.ToString());
                listBox2.Items.Add(a.ToString());
                m = "*";
                listBox2.Items.Add(m.ToString());
                step = 2;
                c = false;
                ms = false;
            }
            else
            {
                if (ms == true && step == 2)
                {
                    b = double.Parse(textBox1.Text.ToString());
                    switch (m)
                    {
                        case "+":
                            answer = a + b;
                            break;
                        case "-":
                            answer = a - b;
                            break;
                        case "*":
                            answer = a * b;
                            break;
                        case "/":
                            answer = a / b;
                            break;
                    }
                    a = answer;
                    textBox1.Text = a.ToString();
                    m = "*";
                    step = 2;
                    c = false;
                    ms = false;
                }
                else
                {
                    //a = answer;
                    //textBox1.Text = a.ToString();
                    m = "*";
                    step = 2;
                    c = false;
                    ms = false;
                }
            }
        }

        private void divide_Click(object sender, EventArgs e)//除法
        {
            label1.Text = "÷";
            pw = true;
            if (step == 1)
            {
                a = double.Parse(textBox1.Text.ToString());
                listBox2.Items.Add(a.ToString());
                m = "/";
                listBox2.Items.Add(m.ToString());
                step = 2;
                c = false;
                ms = false;
            }
            else
            {
                if (ms == true && step == 2)
                {
                    b = double.Parse(textBox1.Text.ToString());
                    switch (m)
                    {
                        case "+":
                            answer = a + b;
                            break;
                        case "-":
                            answer = a - b;
                            break;
                        case "*":
                            answer = a * b;
                            break;
                        case "/":
                            answer = a / b;
                            break;
                    }
                    a = answer;
                    textBox1.Text = a.ToString();
                    m = "/";
                    step = 2;
                    c = false;
                    ms = false;
                }
                else
                {
                    //a = answer;
                    //textBox1.Text = a.ToString();
                    m = "/";
                    step = 2;
                    c = false;
                    ms = false;
                }
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            pw = true;
            if (es == true)
            {
                b = double.Parse(textBox1.Text.ToString());
                listBox2.Items.Add(b.ToString());
                ms = true;
                switch (m)
                {
                    case "+":
                        answer = a + b;
                        break;
                    case "-":
                        answer = a - b;
                        break;
                    case "*":
                        answer = a * b;
                        break;
                    case "/":
                        answer = a / b;
                        break;
                }
                textBox1.Text = answer.ToString();
                listBox2.Items.Add("=");
                listBox2.Items.Add(answer.ToString());
                step = 1;
                c = false;
                label1.Text = "";
                es = false;
            }
            else
            {
                a = double.Parse(textBox1.Text.ToString());
                listBox2.Items.Add(m.ToString());
                listBox2.Items.Add(b.ToString());
                listBox2.Items.Add("=");
                switch (m)
                {
                    case "+":
                        answer = a + b;
                        break;
                    case "-":
                        answer = a - b;
                        break;
                    case "*":
                        answer = a * b;
                        break;
                    case "/":
                        answer = a / b;
                        break;
                }
                textBox1.Text = answer.ToString();
                listBox2.Items.Add(answer.ToString());
            }
        }

        private void AC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            a = 0;
            b = 0;
            answer = 0;
            c = false;
            label1.Text = "";
            m= "";
            step = 1;
            ms = true;
            es = true;
            pw = true;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                if (num == pn)
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    pw = true;
                    num -= 1;
                    textBox1.Text = "0";
                }
                else
                {
                    if (textBox1.Text.Length > 1)
                    {
                        textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                        num -= 1;
                    }
                    else
                    {

                        textBox1.Text = "0";
                        num = 1;
                        c = false;
                    }
                   
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
    }
}
