using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        double firstNumber=0, secondNumber=0;
        bool status = true; 
        int numberSerial = 1;
        double result;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (buttonMinus.BackColor == (Color.PaleGreen))
            {
                calculate("-");
            }
            else if (buttonCross.BackColor == (Color.PaleGreen))
            {
                calculate("x");
            }
            else if (buttonDivide.BackColor == (Color.PaleGreen))
            {
                calculate("/");
            }
            else if (buttonPlus.BackColor == (Color.PaleGreen))
            {
                calculate("+");
            }
            else
            {
                
            }
            buttonPlus.BackColor = (Color.WhiteSmoke);
            buttonMinus.BackColor = (Color.WhiteSmoke);
            buttonCross.BackColor = (Color.WhiteSmoke);
            buttonDivide.BackColor = (Color.WhiteSmoke);
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Trim() == "")
            {
                textBoxInput.Text = "0.";
                status = false;
            }
            else
            {
                textBoxInput.Text = textBoxInput.Text + ".";
                status = false;
            }
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (status==true)
            {
                
                textBoxInput.Text = "0";
                status = false;
            }
            else
            {
                textBoxInput.Text = textBoxInput.Text + "0";
            }
                
            
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
              
                textBoxInput.Text = "1";
                status = false;
            }
            else
            {
                textBoxInput.Text = textBoxInput.Text + "1";
            }
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
                
                textBoxInput.Text = "2";
                status = false;
            }
            else
            {
                textBoxInput.Text = textBoxInput.Text + "2";
            }
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
               
                textBoxInput.Text = "3";
                status = false;
            }
            else
            {
                textBoxInput.Text = textBoxInput.Text + "3";
            }
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
               

                textBoxInput.Text = "4";
                status = false;
            }
            else
            {
                textBoxInput.Text = textBoxInput.Text + "4";
            }
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
               

                textBoxInput.Text = "5";
                status = false;
            }
            else
            {
                textBoxInput.Text = textBoxInput.Text + "5";
            }
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
               
                textBoxInput.Text = "6";
                status = false;
            }
            else
            {
                textBoxInput.Text = textBoxInput.Text + "6";
            }
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
               
                textBoxInput.Text = "7";
                status = false;
            }
            else
            {
                textBoxInput.Text = textBoxInput.Text + "7";
            }
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
                

                textBoxInput.Text = "8";
                status = false;
            }
            else
            {
                textBoxInput.Text = textBoxInput.Text + "8";
            }
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
               

                textBoxInput.Text = "9";
                status = false;
            }
            else
            {
                textBoxInput.Text = textBoxInput.Text + "9";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (buttonMinus.BackColor == (Color.PaleGreen))
            {
                calculate("-");
            }
            else if (buttonCross.BackColor == (Color.PaleGreen))
            {
                calculate("x");
            }
            else if (buttonDivide.BackColor == (Color.PaleGreen))
            {
                calculate("/");
            }
            else if (buttonPlus.BackColor == (Color.PaleGreen))
            {
                calculate("+");
            }
            else
            {
                firstNumber = Convert.ToDouble(textBoxInput.Text);
                numberSerial = 2;
                status = true;
            }
            buttonPlus.BackColor = (Color.PaleGreen);
            buttonMinus.BackColor = (Color.WhiteSmoke);
            buttonCross.BackColor = (Color.WhiteSmoke);
            buttonDivide.BackColor = (Color.WhiteSmoke);
           
            


        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (buttonMinus.BackColor == (Color.PaleGreen))
            {
                calculate("-");
            }
            else if (buttonCross.BackColor == (Color.PaleGreen))
            {
                calculate("x");
            }
            else if (buttonDivide.BackColor == (Color.PaleGreen))
            {
                calculate("/");
            }
            else if (buttonPlus.BackColor == (Color.PaleGreen))
            {
                calculate("+");
            }
            else
            {
                firstNumber = Convert.ToDouble(textBoxInput.Text);
                numberSerial = 2;
                status = true;
            }
            buttonPlus.BackColor = (Color.WhiteSmoke);
            buttonMinus.BackColor = (Color.PaleGreen);
            buttonCross.BackColor = (Color.WhiteSmoke);
            buttonDivide.BackColor = (Color.WhiteSmoke);
           

            
        }

        private void buttonCross_Click(object sender, EventArgs e)
        {
            if (buttonMinus.BackColor == (Color.PaleGreen))
            {
                calculate("-");
            }
            else if (buttonCross.BackColor == (Color.PaleGreen))
            {
                calculate("x");
            }
            else if (buttonDivide.BackColor == (Color.PaleGreen))
            {
                calculate("/");
            }
            else if (buttonPlus.BackColor == (Color.PaleGreen))
            {
                calculate("+");
            }
            else
            {
                firstNumber = Convert.ToDouble(textBoxInput.Text);
                numberSerial = 2;
                status = true;
                // calculate("x");
            }
            buttonPlus.BackColor = (Color.WhiteSmoke);
            buttonMinus.BackColor = (Color.WhiteSmoke);
            buttonCross.BackColor = (Color.PaleGreen);
            buttonDivide.BackColor = (Color.WhiteSmoke);
            
           
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (buttonMinus.BackColor == (Color.PaleGreen))
            {
                calculate("-");
            }
            else if (buttonCross.BackColor == (Color.PaleGreen))
            {
                calculate("x");
            }
            else if (buttonDivide.BackColor == (Color.PaleGreen))
            {
                calculate("/");
            }
            else if (buttonPlus.BackColor == (Color.PaleGreen))
            {
                calculate("+");
            }
            else
            {
                firstNumber = Convert.ToDouble(textBoxInput.Text);
                numberSerial = 2;
                status = true;
                //  calculate("/");
            }
            buttonPlus.BackColor = (Color.WhiteSmoke);
            buttonMinus.BackColor = (Color.WhiteSmoke);
            buttonCross.BackColor = (Color.WhiteSmoke);
            buttonDivide.BackColor = (Color.PaleGreen);
            
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            buttonPlus.BackColor = (Color.WhiteSmoke);
            buttonMinus.BackColor = (Color.WhiteSmoke);
            buttonCross.BackColor = (Color.WhiteSmoke);
            buttonDivide.BackColor = (Color.WhiteSmoke);

            firstNumber = 0;
            secondNumber = 0;
             status = true;
             numberSerial = 1;
             result=0;
            textBoxInput.Text = "";


        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            
        }

        
        private void calculate(string action)
        {
            status = true;
            if (numberSerial == 1)
            {
                firstNumber = Convert.ToDouble(textBoxInput.Text);
                numberSerial = 2;
             //  textBoxInput.Text = "";
            }
            else if (numberSerial == 2)
            {
                secondNumber = Convert.ToDouble(textBoxInput.Text);

                if (action == "+")
                {
                    result = firstNumber + secondNumber;
                }
                else if (action == "-")
                {
                    result = firstNumber - secondNumber;
                }
                else if (action == "x")
                {
                    result = firstNumber * secondNumber;
                }
                else if (action == "/")
                {
                   
                    result = firstNumber / secondNumber;
                }
                textBoxInput.Text = result.ToString();
                firstNumber = result;
                secondNumber = 0;
                numberSerial = 2;
             //   textBoxInput.Text = "";
            }
            else
            {
                if (action == "+")
                {
                    result = firstNumber + secondNumber;
                }
                else if (action == "-")
                {
                    result = firstNumber - secondNumber;
                }
                else if (action == "x")
                {
                    result = firstNumber * secondNumber;
                }
                else if (action == "/")
                {
                    result = firstNumber / secondNumber;
                }

                textBoxInput.Text = result.ToString();
                firstNumber = result;
                numberSerial = 2;
              //  textBoxInput.Text = "";
            }
        }

        // ======= End =======
    }
}
