using System;
using System.Windows.Forms;

namespace Calculator
{
    //程序的窗体直接命名为Calculator
    public partial class Calculator : Form
    {
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

        private void dot_Click(object sender, EventArgs e)
        {

        }


        //算术运算符按键（Arithmetic operator）；命名规范：ao_xxx

        private void ao_add_Click(object sender, EventArgs e)
        {

        }

        private void ao_subtract_Click(object sender, EventArgs e)
        {

        }

        private void ao_multiply_Click(object sender, EventArgs e)
        {

        }

        private void ao_divide_Click(object sender, EventArgs e)
        {

        }


        //运算结果输出键"="（equal）

        private void equal_Click(object sender, EventArgs e)
        {

        }


        //功能性按键

        //退格键（Backspace） - 在数字输入期间按下此键将清除上一个输入的字符（打算做的功能：也包括清除算术运算符）
        private void backspace_Click(object sender, EventArgs e)
        {

        }

        //清除键（Clear） - 在数字输入期间按下此键将清除除存储器内容外的所有数值
        private void clear_Click(object sender, EventArgs e)
        {

        }

        //清除输入键（Clear Entry） - 在数字输入期间按下此键将清除输入寄存器中的值并显示"0"
        private void clear_entry_Click(object sender, EventArgs e)
        {

        }
    }
}
