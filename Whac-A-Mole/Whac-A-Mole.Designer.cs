namespace Whac_A_Mole
{
    partial class whac_a_mole
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
            this.gopher1 = new System.Windows.Forms.PictureBox();
            this.gopher2 = new System.Windows.Forms.PictureBox();
            this.gopher3 = new System.Windows.Forms.PictureBox();
            this.gopher4 = new System.Windows.Forms.PictureBox();
            this.gopher5 = new System.Windows.Forms.PictureBox();
            this.gopher6 = new System.Windows.Forms.PictureBox();
            this.difficulty = new System.Windows.Forms.HScrollBar();
            this.time = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.gopher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gopher2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gopher3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gopher4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gopher5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gopher6)).BeginInit();
            this.SuspendLayout();
            // 
            // gopher1
            // 
            this.gopher1.Location = new System.Drawing.Point(120, 120);
            this.gopher1.Name = "gopher1";
            this.gopher1.Size = new System.Drawing.Size(150, 180);
            this.gopher1.TabIndex = 0;
            this.gopher1.TabStop = false;
            // 
            // gopher2
            // 
            this.gopher2.Location = new System.Drawing.Point(325, 120);
            this.gopher2.Name = "gopher2";
            this.gopher2.Size = new System.Drawing.Size(150, 180);
            this.gopher2.TabIndex = 0;
            this.gopher2.TabStop = false;
            // 
            // gopher3
            // 
            this.gopher3.Location = new System.Drawing.Point(530, 120);
            this.gopher3.Name = "gopher3";
            this.gopher3.Size = new System.Drawing.Size(150, 180);
            this.gopher3.TabIndex = 0;
            this.gopher3.TabStop = false;
            // 
            // gopher4
            // 
            this.gopher4.Location = new System.Drawing.Point(120, 320);
            this.gopher4.Name = "gopher4";
            this.gopher4.Size = new System.Drawing.Size(150, 180);
            this.gopher4.TabIndex = 0;
            this.gopher4.TabStop = false;
            // 
            // gopher5
            // 
            this.gopher5.Location = new System.Drawing.Point(325, 320);
            this.gopher5.Name = "gopher5";
            this.gopher5.Size = new System.Drawing.Size(150, 180);
            this.gopher5.TabIndex = 0;
            this.gopher5.TabStop = false;
            // 
            // gopher6
            // 
            this.gopher6.Location = new System.Drawing.Point(530, 320);
            this.gopher6.Name = "gopher6";
            this.gopher6.Size = new System.Drawing.Size(150, 180);
            this.gopher6.TabIndex = 0;
            this.gopher6.TabStop = false;
            // 
            // difficulty
            // 
            this.difficulty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.difficulty.Location = new System.Drawing.Point(468, 28);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(100, 10);
            this.difficulty.TabIndex = 1;
            // 
            // time
            // 
            this.time.Cursor = System.Windows.Forms.Cursors.Hand;
            this.time.Location = new System.Drawing.Point(301, 28);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(100, 10);
            this.time.TabIndex = 1;
            // 
            // whac_a_mole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.time);
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.gopher6);
            this.Controls.Add(this.gopher5);
            this.Controls.Add(this.gopher3);
            this.Controls.Add(this.gopher4);
            this.Controls.Add(this.gopher2);
            this.Controls.Add(this.gopher1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "whac_a_mole";
            this.Text = "我在方格纸上玩了一场打地鼠";
            ((System.ComponentModel.ISupportInitialize)(this.gopher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gopher2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gopher3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gopher4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gopher5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gopher6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gopher1;
        private System.Windows.Forms.PictureBox gopher2;
        private System.Windows.Forms.PictureBox gopher3;
        private System.Windows.Forms.PictureBox gopher4;
        private System.Windows.Forms.PictureBox gopher5;
        private System.Windows.Forms.PictureBox gopher6;
        private System.Windows.Forms.HScrollBar difficulty;
        private System.Windows.Forms.HScrollBar time;
    }
}

