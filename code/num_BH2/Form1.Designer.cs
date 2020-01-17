namespace num_BH2
{
    partial class Form1
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
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_solve = new System.Windows.Forms.Button();
            this.comboBox_method = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_Taylor = new System.Windows.Forms.Panel();
            this.numericUpDown_Taylor = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_ODE = new System.Windows.Forms.Panel();
            this.numericUpDown_ODE = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_error = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_Taylor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Taylor)).BeginInit();
            this.panel_ODE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ODE)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_x
            // 
            this.textBox_x.Location = new System.Drawing.Point(112, 79);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(100, 25);
            this.textBox_x.TabIndex = 0;
            this.textBox_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_x_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入x：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "结果：";
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(83, 257);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(226, 79);
            this.textBox_result.TabIndex = 6;
            // 
            // button_solve
            // 
            this.button_solve.Location = new System.Drawing.Point(303, 192);
            this.button_solve.Name = "button_solve";
            this.button_solve.Size = new System.Drawing.Size(75, 47);
            this.button_solve.TabIndex = 7;
            this.button_solve.Text = "求解";
            this.button_solve.UseVisualStyleBackColor = true;
            this.button_solve.Click += new System.EventHandler(this.button_solve_Click);
            // 
            // comboBox_method
            // 
            this.comboBox_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_method.FormattingEnabled = true;
            this.comboBox_method.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_method.Items.AddRange(new object[] {
            "逼近法",
            "常微分方程",
            "cordic算法"});
            this.comboBox_method.Location = new System.Drawing.Point(112, 134);
            this.comboBox_method.Name = "comboBox_method";
            this.comboBox_method.Size = new System.Drawing.Size(121, 23);
            this.comboBox_method.TabIndex = 8;
            this.comboBox_method.SelectedIndexChanged += new System.EventHandler(this.comboBox_method_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "计算方法：";
            // 
            // panel_Taylor
            // 
            this.panel_Taylor.Controls.Add(this.numericUpDown_Taylor);
            this.panel_Taylor.Controls.Add(this.label6);
            this.panel_Taylor.Location = new System.Drawing.Point(30, 174);
            this.panel_Taylor.Name = "panel_Taylor";
            this.panel_Taylor.Size = new System.Drawing.Size(195, 55);
            this.panel_Taylor.TabIndex = 10;
            this.panel_Taylor.Visible = false;
            // 
            // numericUpDown_Taylor
            // 
            this.numericUpDown_Taylor.Location = new System.Drawing.Point(68, 12);
            this.numericUpDown_Taylor.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDown_Taylor.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.numericUpDown_Taylor.Name = "numericUpDown_Taylor";
            this.numericUpDown_Taylor.Size = new System.Drawing.Size(65, 25);
            this.numericUpDown_Taylor.TabIndex = 4;
            this.numericUpDown_Taylor.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "项数k=";
            // 
            // panel_ODE
            // 
            this.panel_ODE.Controls.Add(this.label8);
            this.panel_ODE.Controls.Add(this.numericUpDown_ODE);
            this.panel_ODE.Controls.Add(this.label7);
            this.panel_ODE.Location = new System.Drawing.Point(29, 172);
            this.panel_ODE.Name = "panel_ODE";
            this.panel_ODE.Size = new System.Drawing.Size(210, 55);
            this.panel_ODE.TabIndex = 11;
            this.panel_ODE.Visible = false;
            // 
            // numericUpDown_ODE
            // 
            this.numericUpDown_ODE.Location = new System.Drawing.Point(88, 15);
            this.numericUpDown_ODE.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_ODE.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_ODE.Name = "numericUpDown_ODE";
            this.numericUpDown_ODE.Size = new System.Drawing.Size(65, 25);
            this.numericUpDown_ODE.TabIndex = 4;
            this.numericUpDown_ODE.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "划分次数t=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "*10^3";
            // 
            // textBox_error
            // 
            this.textBox_error.Location = new System.Drawing.Point(82, 350);
            this.textBox_error.Multiline = true;
            this.textBox_error.Name = "textBox_error";
            this.textBox_error.ReadOnly = true;
            this.textBox_error.Size = new System.Drawing.Size(227, 79);
            this.textBox_error.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "误差：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(24, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "求解sin(x)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 453);
            this.Controls.Add(this.panel_ODE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_error);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_Taylor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_method);
            this.Controls.Add(this.button_solve);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_x);
            this.Name = "Form1";
            this.Text = "sin(x)";
            this.panel_Taylor.ResumeLayout(false);
            this.panel_Taylor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Taylor)).EndInit();
            this.panel_ODE.ResumeLayout(false);
            this.panel_ODE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ODE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_solve;
        private System.Windows.Forms.ComboBox comboBox_method;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_Taylor;
        private System.Windows.Forms.NumericUpDown numericUpDown_Taylor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_ODE;
        private System.Windows.Forms.NumericUpDown numericUpDown_ODE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_error;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

