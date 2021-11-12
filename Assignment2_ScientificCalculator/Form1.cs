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
        double firstvalue;
        double secondvalue;
        string[] parts = null;
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



        private void button66_Click(object sender, EventArgs e)
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
                    parts = Display.Text.Split("+");
                    firstvalue = Convert.ToDouble(parts[0]);
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = firstvalue + secondvalue;
                    Display.Text = Convert.ToString(answer);
                    break;

                case "-":
                    parts = Display.Text.Split("-");
                    firstvalue = Convert.ToDouble(parts[0]);
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = firstvalue - secondvalue;
                    Display.Text = Convert.ToString(answer);
                    break;

                case "*":
                    parts = Display.Text.Split("*");
                    firstvalue = Convert.ToDouble(parts[0]);
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = firstvalue * secondvalue;
                    Display.Text = Convert.ToString(answer);
                    break;

                case "/":
                    parts = Display.Text.Split("/");
                    firstvalue = Convert.ToDouble(parts[0]);
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = firstvalue / secondvalue;
                    Display.Text = Convert.ToString(answer);
                    break;

                case "1/":
                    parts = Display.Text.Split("1/");
                    
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = 1 / secondvalue;
                    Display.Text = Convert.ToString(answer);
                    break;

                case "%":
                    parts = Display.Text.Split("%");
                    firstvalue = Convert.ToDouble(parts[0]);
                    
                    answer = firstvalue / 100;
                    Display.Text = Convert.ToString(answer);
                    break;

                case "±":
                    parts = Display.Text.Split("±");

                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = secondvalue * (-1);
                    Display.Text = Convert.ToString(answer);
                    break;

                case "x√y":
                    parts = Display.Text.Split("√");
                    firstvalue = Convert.ToDouble(parts[0]);
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Pow(secondvalue, 1 / firstvalue);
                    Display.Text = Convert.ToString(answer);
                    break;

                case "10":
                    parts = Display.Text.Split("10^");
                   
                    secondvalue = Convert.ToDouble(parts[1]);
                    answer = Math.Pow(10, secondvalue);
                    Display.Text = Convert.ToString(answer);
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
    }
}
