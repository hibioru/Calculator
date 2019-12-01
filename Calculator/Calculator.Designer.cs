namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.operational_result = new System.Windows.Forms.TextBox();
            this.expression = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.ao_add = new System.Windows.Forms.Button();
            this.ao_subtract = new System.Windows.Forms.Button();
            this.ao_multiply = new System.Windows.Forms.Button();
            this.ao_divide = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.clear_entry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // operational_result
            // 
            this.operational_result.BackColor = System.Drawing.Color.White;
            this.operational_result.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.operational_result.Location = new System.Drawing.Point(10, 61);
            this.operational_result.Name = "operational_result";
            this.operational_result.Size = new System.Drawing.Size(357, 60);
            this.operational_result.TabIndex = 0;
            this.operational_result.Text = "0";
            this.operational_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.operational_result.TextChanged += new System.EventHandler(this.operational_result_TextChanged);
            // 
            // expression
            // 
            this.expression.Location = new System.Drawing.Point(12, 21);
            this.expression.Name = "expression";
            this.expression.Size = new System.Drawing.Size(355, 31);
            this.expression.TabIndex = 1;
            this.expression.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.expression.TextChanged += new System.EventHandler(this.expression_TextChanged);
            // 
            // num1
            // 
            this.num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num1.Location = new System.Drawing.Point(22, 466);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(63, 49);
            this.num1.TabIndex = 2;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num2.Location = new System.Drawing.Point(91, 466);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(63, 49);
            this.num2.TabIndex = 2;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num3.Location = new System.Drawing.Point(160, 466);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(63, 49);
            this.num3.TabIndex = 2;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num4
            // 
            this.num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num4.Location = new System.Drawing.Point(22, 411);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(63, 49);
            this.num4.TabIndex = 2;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num5
            // 
            this.num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num5.Location = new System.Drawing.Point(91, 411);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(63, 49);
            this.num5.TabIndex = 2;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num6
            // 
            this.num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num6.Location = new System.Drawing.Point(160, 411);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(63, 49);
            this.num6.TabIndex = 2;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num7
            // 
            this.num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num7.Location = new System.Drawing.Point(22, 356);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(63, 49);
            this.num7.TabIndex = 2;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num8
            // 
            this.num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num8.Location = new System.Drawing.Point(91, 356);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(63, 49);
            this.num8.TabIndex = 2;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num9
            // 
            this.num9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num9.Location = new System.Drawing.Point(160, 356);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(63, 49);
            this.num9.TabIndex = 2;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num0
            // 
            this.num0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num0.Location = new System.Drawing.Point(91, 521);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(63, 49);
            this.num0.TabIndex = 2;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // dot
            // 
            this.dot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dot.Location = new System.Drawing.Point(160, 521);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(62, 48);
            this.dot.TabIndex = 3;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // ao_add
            // 
            this.ao_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ao_add.Location = new System.Drawing.Point(231, 467);
            this.ao_add.Name = "ao_add";
            this.ao_add.Size = new System.Drawing.Size(61, 47);
            this.ao_add.TabIndex = 4;
            this.ao_add.Text = "+";
            this.ao_add.UseVisualStyleBackColor = true;
            this.ao_add.Click += new System.EventHandler(this.ao_add_Click);
            // 
            // ao_subtract
            // 
            this.ao_subtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ao_subtract.Location = new System.Drawing.Point(231, 411);
            this.ao_subtract.Name = "ao_subtract";
            this.ao_subtract.Size = new System.Drawing.Size(61, 47);
            this.ao_subtract.TabIndex = 4;
            this.ao_subtract.Text = "-";
            this.ao_subtract.UseVisualStyleBackColor = true;
            this.ao_subtract.Click += new System.EventHandler(this.ao_subtract_Click);
            // 
            // ao_multiply
            // 
            this.ao_multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ao_multiply.Location = new System.Drawing.Point(231, 358);
            this.ao_multiply.Name = "ao_multiply";
            this.ao_multiply.Size = new System.Drawing.Size(61, 47);
            this.ao_multiply.TabIndex = 4;
            this.ao_multiply.Text = "*";
            this.ao_multiply.UseVisualStyleBackColor = true;
            this.ao_multiply.Click += new System.EventHandler(this.ao_multiply_Click);
            // 
            // ao_divide
            // 
            this.ao_divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ao_divide.Location = new System.Drawing.Point(231, 305);
            this.ao_divide.Name = "ao_divide";
            this.ao_divide.Size = new System.Drawing.Size(61, 47);
            this.ao_divide.TabIndex = 4;
            this.ao_divide.Text = "/";
            this.ao_divide.UseVisualStyleBackColor = true;
            this.ao_divide.Click += new System.EventHandler(this.ao_divide_Click);
            // 
            // equal
            // 
            this.equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equal.Location = new System.Drawing.Point(231, 523);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(61, 47);
            this.equal.TabIndex = 4;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // backspace
            // 
            this.backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backspace.Location = new System.Drawing.Point(160, 307);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(61, 44);
            this.backspace.TabIndex = 5;
            this.backspace.Text = "←";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // clear
            // 
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Location = new System.Drawing.Point(91, 306);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(62, 44);
            this.clear.TabIndex = 6;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // clear_entry
            // 
            this.clear_entry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_entry.Location = new System.Drawing.Point(20, 301);
            this.clear_entry.Name = "clear_entry";
            this.clear_entry.Size = new System.Drawing.Size(64, 48);
            this.clear_entry.TabIndex = 7;
            this.clear_entry.Text = "CE";
            this.clear_entry.UseVisualStyleBackColor = true;
            this.clear_entry.Click += new System.EventHandler(this.clear_entry_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(384, 601);
            this.Controls.Add(this.clear_entry);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.ao_divide);
            this.Controls.Add(this.ao_multiply);
            this.Controls.Add(this.ao_subtract);
            this.Controls.Add(this.ao_add);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.expression);
            this.Controls.Add(this.operational_result);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(400, 640);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox operational_result;
        private System.Windows.Forms.TextBox expression;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button ao_add;
        private System.Windows.Forms.Button ao_subtract;
        private System.Windows.Forms.Button ao_multiply;
        private System.Windows.Forms.Button ao_divide;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button clear_entry;
    }
}

