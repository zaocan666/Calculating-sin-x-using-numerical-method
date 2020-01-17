using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace num_BH2
{
    public partial class Form1 : Form
    {
        int error_m = 15;
        double[] tangent;
        double[] angle;
        double K;
        int cordic_n=15;

    public Form1()
        {
            InitializeComponent();

            //double error = Taylor_error(11, 15, 2 * Math.PI);
            //double result = Taylor_calculate(13, 15, Math.PI/2);
            //ODE_error(Math.PI / 4 / 12000);
            //ODE_calculate(Math.PI / 4, 12000);

            cordic_init();
        }

        //x只能输入数字
        private void textBox_x_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键  
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数  
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符  
                }
            }
        }

        //逼近法计算
        public double Taylor_calculate(int k, double x0)
        {
            double result = 0;
            for(int i=1;i<=k;i++)
            {
                double f_i = 1;
                for(int j=1;j<=2*i-1;j++)
                {
                    f_i *= (x0 / j);
                }

                if(i%2==0)
                {
                    result -= f_i;
                }
                else
                {
                    result += f_i;
                }
            }

            return result;
        }

        //逼近法误差计算
        public double Taylor_error(int k, int m, double x0)
        {
            double error1 = 1;
            for(int i=1;i<=2*k+1;i++)
            {
                error1 *= (x0 / i);
            }

            double ten_m = 0.5;
            for(int i=0;i<m;i++)
            {
                ten_m *= 0.1;
            }
            double error2 = ten_m * (k - 1);

            double error3 = 0;
            for(int i=1;i<=k;i++)
            {
                double error3_i = 1;
                for(int j=1;j<=2*i-2;j++)
                {
                    error3_i *= (x0 / j);
                }
                error3 += error3_i;
            }

            error3 *= ten_m;

            return error1 + error2 + error3;
        }

        //常微分方程法计算
        public double ODE_calculate(double x, int t)
        {
            double h = x / t;
            double y_i = 0;
            for(int i=0;i<t;i++)
            {
                double f_i = my_sqrt(1 - y_i * y_i, 0.5, 200);
                y_i = y_i + h * f_i;
            }

            return y_i;
        }

        //常微分方程法误差计算
        public double ODE_error(double h)
        {
            h = h >= 0 ? h : -h;
            if(h==0)
            {
                return 0;
            }

            double M = 1.2688;
            double pow_h = Math.Pow(1 + M * h, Math.PI / 4 / h);
            double error1 = 2 * pow_h * Math.Pow(10, -15)/M/h;
            double error2 = (pow_h - 1) * h / M;
            double result = error1 + error2;
            return result;
        }

        //cordic算法初始化，准备参数
        public void cordic_init()
        {
            tangent = new double[cordic_n];
            for (int i = 0; i < cordic_n; i++)
            {
                tangent[i] = 1;
                for(int j=0;j<i;j++)
                {
                    tangent[i] /= 2.0;
                }
            }

            angle = new double[cordic_n];
            for (int i = 0; i < cordic_n; i++)
            {
                angle[i] = Math.Atan(tangent[i]);
            }

            K = 1;
            for (int j = 0; j < cordic_n; j++)
            {
                K *= 1 / Math.Sqrt(1 + (tangent[j]) * (tangent[j]));
            }
        }

        //cordic算法计算
        public void cordic_calculate(double x, out double sin_y, out double cos_x)
        {
            int i, sign;
            double cos_last, sin_last, angle_delta;
            cos_x = 0; sin_y = 0; angle_delta = x;
            cos_last = 1; sin_last = 0;
            sign = 1;

            for (i = 0; i < cordic_n; i++)
            {
                cos_x = cos_last - sign * sin_last * tangent[i];
                sin_y = sin_last + sign * cos_last * tangent[i];
                angle_delta = angle_delta - sign * angle[i];
                
                cos_last = cos_x;
                sin_last = sin_y;

                sign = angle_delta > 0 ? 1 : -1;
            }

            sin_y *= K;
            cos_x *= K;
        }

        //方程求根的数值解，求解根号
        public double my_sqrt(double q, double x0, int n)
        {
            double result=x0;
            for(int i=0;i<n;i++)
            {
                result = result - result * result / 4 + q / 4;
            }

            return result;
        }

        private void button_solve_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "";
            textBox_error.Text = "";
            if(textBox_x.Text=="")
            {
                MessageBox.Show(this, "请先输入x！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double x = double.Parse(textBox_x.Text);
            if (Math.Abs(x / 2 / Math.PI) >= 1)
            {
                x = x - Math.PI * 2 * ((int)(x / 2 / Math.PI));//x归一化为0到2pi
            }
            
            string method = comboBox_method.Text;
            if (method == "逼近法")
            {
                int k = (int)numericUpDown_Taylor.Value;
                double result = Taylor_calculate(k, x);
                double error = Taylor_error(k, error_m, x);

                textBox_result.Text = result.ToString();
                textBox_error.Text = error.ToString();
            }
            else if (method == "常微分方程")
            {
                double sign = 1;
                if(x>=Math.PI*3/2)
                {
                    x = x - 2 * Math.PI;
                }
                else if(x>=Math.PI/2)
                {
                    x = x - Math.PI;
                    sign = -1;
                }

                int t = (int)numericUpDown_ODE.Value*1000;
                double sin_x0 = ODE_calculate(x / 2, t);
                double result = sign * 2 * sin_x0 * my_sqrt(1 - sin_x0 * sin_x0, 0.5, 200);
                double error = ODE_error(x / 2 / t);

                textBox_result.Text = result.ToString();
                textBox_error.Text = error.ToString();
            }
            else if(method == "cordic算法")
            {
                double sign = 1;
                bool cos_flag = false;
                if (x >= Math.PI)
                {
                    x = x - Math.PI;
                    sign = -1;
                }
                if (x >= Math.PI / 2)
                {
                    x = x - Math.PI/2; //cos(x-pi/2)=sin(x)
                    cos_flag = true;
                }

                cordic_calculate(x, out double sin_y, out double cos_x);
                double result = sign*(cos_flag ? cos_x : sin_y);
                textBox_result.Text = result.ToString();
            }
            else
            {
                MessageBox.Show(this, "请先选择计算方法！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void comboBox_method_SelectedIndexChanged(object sender, EventArgs e)
        {
            string method = comboBox_method.Text;
            panel_ODE.Visible = false;
            panel_Taylor.Visible = false;

            //逼近法 常微分方程 cordic算法
            if (method=="逼近法")
            {
                panel_Taylor.Visible = true;
            }
            else if(method=="常微分方程")
            {
                panel_ODE.Visible = true;
            }
        }
    }
}
