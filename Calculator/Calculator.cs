using System;
using System.Windows.Forms;

namespace Calculator
{
    //程序的窗体直接命名为Calculator
    public partial class Calculator : Form
    {
        private double a = 0, b = 0, answer = 0;//运算用数值
        private bool c = false;//改变a，b的值
        private int step = 1;//运算步骤
        private string m;//运算符号
        private bool ms = true;//累加累减
        private bool es = true;//连等
        private int num = 1;//textbox内数值长度
        private int pn = 1;//textbox内数据长度参考值
        private bool pw = true;//小数点
        public Calculator()
        {
            InitializeComponent();
        }

        //运算式命名为expression
        //运算结果命名为operational_result


        //数字输入按键；命名规范：num0 - num9

        private void num0_Click(object sender, EventArgs e)
        {

        }

        private void num1_Click(object sender, EventArgs e)
        {

        }

        private void num2_Click(object sender, EventArgs e)
        {

        }

        private void num3_Click(object sender, EventArgs e)
        {

        }

        private void num4_Click(object sender, EventArgs e)
        {

        }

        private void num5_Click(object sender, EventArgs e)
        {

        }

        private void num6_Click(object sender, EventArgs e)
        {

        }

        private void num7_Click(object sender, EventArgs e)
        {

        }

        private void num8_Click(object sender, EventArgs e)
        {

        }

        private void num9_Click(object sender, EventArgs e)
        {

        }


        //辅助性按键（包括小数点，后期考虑加入百分号按键）

        private void dot_Click(object sender, EventArgs e)//小数点
        {
            if (c == false)
            {
                c = true;
                ms = true;
                es = true;
                pw = false;
                operational_result.Text = "0.";
                num = 2;
                pn = num;
            }
            if (c == true && pw == true)
            {
                operational_result.Text += ".";
                num += 1;
                pw = false;
                pn = num;
            }
        }


        //算术运算符按键（Arithmetic operator）；命名规范：ao_xxx

        private void ao_add_Click(object sender, EventArgs e)//加法
        {
            pw = true;
            if (step == 1)
            {
                a = double.Parse(operational_result.Text);
                m = "+";
                step = 2;
                ms = false;
                c = false;
            }
            else
            {
                if (step == 2 && ms == true)
                {
                    b = double.Parse(operational_result.Text.ToString());
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
                    operational_result.Text = a.ToString();
                    m = "+";
                    step = 2;
                    c = false;
                    ms = false;
                }
                else
                {
                    m = "+";
                    step = 2;
                    c = false;
                    ms = false;
                }
            }
        }


        private void ao_subtract_Click(object sender, EventArgs e)//减法
        {
            pw = true;
            if (step == 1)
            {
                a = double.Parse(operational_result.Text);
                m = "-";
                step = 2;
                ms = false;
                c = false;
            }
            else
            {
                if (step == 2 && ms == true)
                {
                    b = double.Parse(operational_result.Text.ToString());
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
                    operational_result.Text = a.ToString();
                    m = "-";
                    step = 2;
                    c = false;
                    ms = false;
                }
                else
                {
                    m = "-";
                    step = 2;
                    c = false;
                    ms = false;
                }
            }
        }

        private void ao_multiply_Click(object sender, EventArgs e)//乘法
        {
            pw = true;
            if (step == 1)
            {
                a = double.Parse(operational_result.Text);
                m = "*";
                step = 2;
                ms = false;
                c = false;
            }
            else
            {
                if (step == 2 && ms == true)
                {
                    b = double.Parse(operational_result.Text.ToString());
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
                    operational_result.Text = a.ToString();
                    m = "*";
                    step = 2;
                    c = false;
                    ms = false;
                }
                else
                {
                    m = "*";
                    step = 2;
                    c = false;
                    ms = false;
                }
            }
        }

        private void ao_divide_Click(object sender, EventArgs e)//除法
        {
            pw = true;
            if (step == 1)
            {
                a = double.Parse(operational_result.Text);
                m = "/";
                step = 2;
                ms = false;
                c = false;
            }
            else
            {
                if (step == 2 && ms == true)
                {
                    b = double.Parse(operational_result.Text.ToString());
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
                    operational_result.Text = a.ToString();
                    m = "/";
                    step = 2;
                    c = false;
                    ms = false;
                }
                else
                {
                    m = "/";
                    step = 2;
                    c = false;
                    ms = false;
                }
            }
        }


        //运算结果输出键"="（equal）

        private void equal_Click(object sender, EventArgs e)
        {
            pw = true;
            if (es == true)
            {
                b = double.Parse(operational_result.Text.ToString());
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
                operational_result.Text = answer.ToString();
                step = 1;
                c = false;
                expression.Text = "";
                es = false;
            }
            else
            {
                a = double.Parse(operational_result.Text.ToString());
                switch (m)
                { 
                    case"+":
                        answer = a + b;
                        break;
                    case"-":
                        answer = a - b;
                        break;
                    case"*":
                        answer = a * b;
                        break;
                    case"/":
                        answer = a / b;
                        break;
                }
                operational_result.Text = answer.ToString();
            }
        }


        //功能性按键

        //退格键（Backspace） - 在数字输入期间按下此键将清除上一个输入的字符（打算做的功能：也包括清除算术运算符）
        private void backspace_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                if (num == pn)
                {
                    operational_result.Text = operational_result.Text.Substring(0, operational_result.Text.Length - 1);
                    pw = true;
                    num -= 1;
                    operational_result.Text = "0";
                }
                else
                {
                    if (operational_result.Text.Length > 1)
                    {
                        operational_result.Text = operational_result.Text.Substring(0, operational_result.Text.Length - 1);
                        num -= 1;
                    }
                    else
                    {

                        operational_result.Text = "0";
                        num = 1;
                        c = false;
                    }
                }
            }
        }

        //清除键（Clear） - 在数字输入期间按下此键将清除除存储器内容外的所有数值
        private void clear_Click(object sender, EventArgs e)
        {

        }

        //清除输入键（Clear Entry） - 在数字输入期间按下此键将清除输入寄存器中的值并显示"0"
        private void clear_entry_Click(object sender, EventArgs e)
        {

        }

        private void operational_result_TextChanged(object sender, EventArgs e)
        {

        }

        private void expression_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

