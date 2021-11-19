using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_ScientificCalculator
{
    public partial class Form1 : Form
    {
        string operation;
        double firstnum;
        double secondnum;
        string[] value = null;
        double answer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {

        }

       

        

        private void button67_Click(object sender, EventArgs e)
        {

        }



       
        private void clearzero()
        {
            if (Display.Text == "0")
            {
                Display.Text = "";
            }
        }
      
        private void ButtonZero_Click(object sender, EventArgs e)
        {
            clearzero();
            Display.Text = Display.Text + "0";
        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            clearzero();
            Display.Text = Display.Text + "1";
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            clearzero();
            Display.Text = Display.Text + "2";
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            clearzero();
            Display.Text = Display.Text + "3";
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            clearzero();
            Display.Text = Display.Text + "4";
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            clearzero();
            Display.Text = Display.Text + "5";
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            clearzero();
            Display.Text = Display.Text + "6";
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            clearzero();
            Display.Text = Display.Text + "7";
        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            clearzero();
            Display.Text = Display.Text + "8";
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            clearzero();
            Display.Text = Display.Text + "9";
        }

        private void CE_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
            if (Display.Text.Length == 0)
            {
                Display.Text = "0";
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            if (!Display.Text.Contains("."))
            {
                Display.Text = Display.Text + ".";
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            operation = "+";
            if (!Display.Text.Contains("+"))
            {
                Display.Text = Display.Text + "+";             
            }
        }   

        private void Minus_Click(object sender, EventArgs e)
        {
            operation = "-";
            if (!Display.Text.Contains("-"))
            {
                Display.Text = Display.Text + "-";
            }
        }
        private void Multiplication_Click(object sender, EventArgs e)
        {
            operation = "*";
            if (!Display.Text.Contains("*"))
            {
                Display.Text = Display.Text + "*";
            }
        }
        private void Divide_Click(object sender, EventArgs e)
        {
            operation = "/";
            if (!Display.Text.Contains("/"))
            {
                Display.Text = Display.Text + "/";
            }
        }
        private void BtnEquals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    value = Display.Text.Split("+");
                    firstnum = Convert.ToDouble(value[0]);
                    secondnum = Convert.ToDouble(value[1]);
                    answer = firstnum + secondnum;
                    Display.Text = Convert.ToString(answer);
                    break;

                case "-":
                    value = Display.Text.Split("-");
                    firstnum = Convert.ToDouble(value[0]);
                    secondnum = Convert.ToDouble(value[1]);
                    answer = firstnum - secondnum;
                    Display.Text = Convert.ToString(answer);
                    break;

                case "*":
                    value = Display.Text.Split("*");
                    firstnum = Convert.ToDouble(value[0]);
                    secondnum = Convert.ToDouble(value[1]);
                    answer = firstnum * secondnum;
                    Display.Text = Convert.ToString(answer);
                    break;

                case "/":
                    value = Display.Text.Split("/");
                    firstnum = Convert.ToDouble(value[0]);
                    secondnum = Convert.ToDouble(value[1]);
                    answer = firstnum / secondnum;
                    Display.Text = Convert.ToString(answer);
                    break;

                case "1/":
                    value = Display.Text.Split("1/");
                    
                    secondnum = Convert.ToDouble(value[1]);
                    answer = 1 / secondnum;
                    Display.Text = Convert.ToString(answer);
                    break;

                case "%":
                    value = Display.Text.Split("%");
                    firstnum = Convert.ToDouble(value[0]);
                    answer = firstnum / 100;
                    Display.Text = Convert.ToString(answer);
                    break;

                case "±":
                    value = Display.Text.Split("±");

                    secondnum = Convert.ToDouble(value[1]);
                    answer = secondnum * (-1);
                    Display.Text = Convert.ToString(answer);
                    break;

                case "x√y":
                    value = Display.Text.Split("√");
                    firstnum = Convert.ToDouble(value[0]);
                    secondnum = Convert.ToDouble(value[1]);
                    answer = Math.Pow(secondnum, 1 / firstnum);
                    Display.Text = Convert.ToString(answer);
                    break;

                case "10":
                    value = Display.Text.Split("10^");                  
                    secondnum = Convert.ToDouble(value[1]);
                    answer = Math.Pow(10, secondnum);
                    Display.Text = Convert.ToString(answer);
                    break;

                case "xsqrty":
                    value = Display.Text.Split("√");
                    secondnum = Convert.ToDouble(value[1]);
                    answer = Math.Sqrt(secondnum);
                    Display.Text = Convert.ToString(answer);
                    break;

                case "Croot":
                    value = Display.Text.Split("3√");
                    secondnum = Convert.ToDouble(value[1]);
                    answer = Math.Cbrt(secondnum);
                    Display.Text = Convert.ToString(answer);
                    break;
                case "Cube":
                    value = Display.Text.Split("^");
                    firstnum = Convert.ToDouble(value[0]);
                    answer = Math.Pow(firstnum,3);
                    Display.Text = Convert.ToString(answer);
                    break;
                case "square":
                    value = Display.Text.Split("^");
                    firstnum = Convert.ToDouble(value[0]);
                    answer = Math.Pow(firstnum, 2);
                    Display.Text = Convert.ToString(answer);
                    break;
                case "xy":
                    value = Display.Text.Split("^");
                    firstnum = Convert.ToDouble(value[0]);
                    secondnum = Convert.ToDouble(value[1]);
                    answer = Math.Pow(firstnum, secondnum);
                    Display.Text = Convert.ToString(answer);
                    break;
                case "log":
                    value = Display.Text.Split("log");
                    secondnum = Convert.ToDouble(value[1]);
                    answer = Math.Log10(secondnum);
                    Display.Text = Convert.ToString(answer);
                    break;
                case "ln":
                    value = Display.Text.Split("ln");
                    secondnum = Convert.ToDouble(value[1]);
                    answer = Math.Log(secondnum);
                    Display.Text = Convert.ToString(answer);
                    break;
                case "sin":
                    value = Display.Text.Split("sin");
                    secondnum = Convert.ToDouble(value[1]);
                    answer = Math.Sin(secondnum);
                    Display.Text = Convert.ToString(answer);
                    break;
                case "cos":
                    value = Display.Text.Split("cos");
                    secondnum = Convert.ToDouble(value[1]);
                    answer = Math.Cos(secondnum);
                    Display.Text = Convert.ToString(answer);
                    break;
                case "tan":
                    value = Display.Text.Split("tan");
                    secondnum = Convert.ToDouble(value[1]);
                    answer = Math.Tan(secondnum);
                    Display.Text = Convert.ToString(answer);
                    break;
                case "sinh":
                    value = Display.Text.Split("sinh");
                    secondnum = Convert.ToDouble(value[1]);
                    answer = Math.Sinh(secondnum);
                    Display.Text = Convert.ToString(answer);
                    break;
                case "cosh":
                    value = Display.Text.Split("cosh");
                    secondnum = Convert.ToDouble(value[1]);
                    answer = Math.Cosh(secondnum);
                    Display.Text = Convert.ToString(answer);
                    break;
                case "tanh":
                    value = Display.Text.Split("tanh");
                    secondnum = Convert.ToDouble(value[1]);
                    answer = Math.Tanh(secondnum);
                    Display.Text = Convert.ToString(answer);
                    break;
                case "pi":
                    
                    Display.Text = Convert.ToString(Math.PI);
                    break;

            }
        } 

        private void LeftArrow_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
            if (Display.Text.Length == 0)
            {
                Display.Text = "0";
            }
        }

        private void OneOverX_Click(object sender, EventArgs e)
        {
            clearzero();
            operation = "1/";
            if (!Display.Text.Contains("1/"))
            {
                Display.Text = "1/" + Display.Text;
               
            }
        }

        private void Percentage_Click(object sender, EventArgs e)
        {
            clearzero();
            operation = "%";
            if (!Display.Text.Contains("%"))
            {
                Display.Text = Display.Text + "%";

            }
        }

        private void PlusMinus_Click(object sender, EventArgs e)
        {
            clearzero();
            operation = "±";
            if (!Display.Text.Contains("±"))
            {
                Display.Text = "±" + Display.Text;

            }
        }

        private void Radical_Click(object sender, EventArgs e)
        {
            clearzero();
            operation = "x√y";
            if (!Display.Text.Contains("√"))
            {
                Display.Text = Display.Text + "√";
            }
        }

        private void TenraisedtoX_Click(object sender, EventArgs e)
        {
            clearzero();
            operation = "10";
            if (!Display.Text.Contains("10^"))
            {
                Display.Text = "10^" + Display.Text;

            }
        }

        private void Squareroot_Click(object sender, EventArgs e)
        {
            clearzero();
            operation = "xsqrty";
            if (!Display.Text.Contains("√"))
            {
                Display.Text = "√" + Display.Text;
            }
        }

        private void Cuberoot_Click(object sender, EventArgs e)
        {
            clearzero();
            operation = "Croot";
            if (!Display.Text.Contains("3√"))
            {
                Display.Text = "3√" + Display.Text;
            }
        }

        private void Cube_Click(object sender, EventArgs e)
        {
            clearzero();
            operation = "Cube";
            if (!Display.Text.Contains("^3"))
            {
                Display.Text = Display.Text + "^3";
            }
        }

        private void Squared_Click(object sender, EventArgs e)
        {
            clearzero();
            operation = "square";
            if (!Display.Text.Contains("^2"))
            {
                Display.Text = Display.Text + "^2";
            }
        }

        private void XraisedtoY_Click(object sender, EventArgs e)
        {
            clearzero();
            operation = "xy";
            if (!Display.Text.Contains("^"))
            {
                Display.Text = Display.Text + "^";
            }
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            clearzero();
            operation = "log";
            if (!Display.Text.Contains("log10"))
            {
                Display.Text = "log10" + Display.Text;
            }
        }
        private void LnBtn_Click(object sender, EventArgs e)
        {
            clearzero();
            operation = "ln";
            if (!Display.Text.Contains("ln"))
            {
                Display.Text = "ln" + Display.Text;
            }
        }
        private void Sine_Click(object sender, EventArgs e)
        {
            clearzero();
            operation = "sin";
            if (!Display.Text.Contains("sin"))
            {
                Display.Text = "sin" + Display.Text;
            }
        }

        private void Cosine_Click(object sender, EventArgs e)
        {
            clearzero();
            operation = "cos";
            if (!Display.Text.Contains("cos"))
            {
                Display.Text = "cos" + Display.Text;
            }
        }

        private void Tangent_Click(object sender, EventArgs e)
        {
            clearzero();
            operation = "tan";
            if (!Display.Text.Contains("tan"))
            {
                Display.Text = "tan" + Display.Text;
            }
        }

        private void Sinh_Click(object sender, EventArgs e)
        {
            clearzero();
            operation = "sinh";
            if (!Display.Text.Contains("sinh"))
            {
                Display.Text = "sinh" + Display.Text;
            }
        }

        private void Cosh_Click(object sender, EventArgs e)
        {
            clearzero();
            operation = "cosh";
            if (!Display.Text.Contains("cosh"))
            {
                Display.Text = "cosh" + Display.Text;
            }
        }

        private void Tanh_Click(object sender, EventArgs e)
        {
            clearzero();
            operation = "tanh";
            if (!Display.Text.Contains("tanh"))
            {
                Display.Text = "tanh" + Display.Text;
            }
        }

        private void PiBtn_Click(object sender, EventArgs e)
        {
            clearzero();
            operation = "pi";
           
                Display.Text = Convert.ToString(Math.PI);
          
        }
    }
}
