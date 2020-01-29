using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double FirstNumber;
        string Operation;
        public Calculator()
        {
            InitializeComponent();
        }

    private void Calculator_Load(object sender, EventArgs e)
        {
            // Gets the date and time from the device.
            LblDateTime.Text = DateTime.Now.ToString("dddd, MMM dd yyyy" + "\n" + "hh:mm tt");
        }
        //The basic buttons on the windows application and the functions for those buttons. 
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0" && TxtBox.Text != null)
            {
                TxtBox.Text = "1";
            }
            else
            {
                TxtBox.Text = TxtBox.Text + "1";
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0" && TxtBox.Text != null)
            {
                TxtBox.Text = "2";
            }
            else
            {
                TxtBox.Text = TxtBox.Text + "2";
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0" && TxtBox.Text != null)
            {
                TxtBox.Text = "3";
            }
            else
            {
                TxtBox.Text = TxtBox.Text + "3";
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0" && TxtBox.Text != null)
            {
                TxtBox.Text = "4";
            }
            else
            {
                TxtBox.Text = TxtBox.Text + "4";
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0" && TxtBox.Text != null)
            {
                TxtBox.Text = "5";
            }
            else
            {
                TxtBox.Text = TxtBox.Text + "5";
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0" && TxtBox.Text != null)
            {
                TxtBox.Text = "6";
            }
            else
            {
                TxtBox.Text = TxtBox.Text + "6";
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0" && TxtBox.Text != null)
            {
                TxtBox.Text = "7";
            }
            else
            {
                TxtBox.Text = TxtBox.Text + "7";
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0" && TxtBox.Text != null)
            {
                TxtBox.Text = "8";
            }
            else
            {
                TxtBox.Text = TxtBox.Text + "8";
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0" && TxtBox.Text != null)
            {
                TxtBox.Text = "9";
            }
            else
            {
                TxtBox.Text = TxtBox.Text + "9";
            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            //Since the textbox is 0 by default, there's no need to check for a zero before hand.
            TxtBox.Text = TxtBox.Text + "0";
        }
        //The math buttons and functions for those operations. 
        private void BtnEqual_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(TxtBox.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                TxtBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                TxtBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                TxtBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                //Checking for zero because you cannot divide by zero, it would cause errors.
                if (SecondNumber == 0)
                {
                    TxtBox.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    TxtBox.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void BtnAddition_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(TxtBox.Text);
            TxtBox.Text = "0";
            Operation = "+";
        }

        private void BtnSubtraction_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(TxtBox.Text);
            TxtBox.Text = "0";
            Operation = "-";
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(TxtBox.Text);
            TxtBox.Text = "0";
            Operation = "*";
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(TxtBox.Text);
            TxtBox.Text = "0";
            Operation = "/";
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            TxtBox.Text = "0";
        }

        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            TxtBox.Text = TxtBox.Text + ".";
        }
        
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Linking the keyboard keys to the same functions as the ones on the windows application.
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.D1)
            {
                if (TxtBox.Text == "0" && TxtBox.Text != null)
                {
                    TxtBox.Text = "1";
                }
                else
                {
                    TxtBox.Text = TxtBox.Text + "1";
                }
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.D2)
            {
                if (TxtBox.Text == "0" && TxtBox.Text != null)
                {
                    TxtBox.Text = "2";
                }
                else
                {
                    TxtBox.Text = TxtBox.Text + "2";
                }
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.D3)
            {
                if (TxtBox.Text == "0" && TxtBox.Text != null)
                {
                    TxtBox.Text = "3";
                }
                else
                {
                    TxtBox.Text = TxtBox.Text + "3";
                }
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.D4)
            {
                if (TxtBox.Text == "0" && TxtBox.Text != null)
                {
                    TxtBox.Text = "4";
                }
                else
                {
                    TxtBox.Text = TxtBox.Text + "4";
                }
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.D5)
            {
                if (TxtBox.Text == "0" && TxtBox.Text != null)
                {
                    TxtBox.Text = "5";
                }
                else
                {
                    TxtBox.Text = TxtBox.Text + "5";
                }
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.D6)
            {
                if (TxtBox.Text == "0" && TxtBox.Text != null)
                {
                    TxtBox.Text = "6";
                }
                else
                {
                    TxtBox.Text = TxtBox.Text + "6";
                }
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.D7)
            {
                if (TxtBox.Text == "0" && TxtBox.Text != null)
                {
                    TxtBox.Text = "7";
                }
                else
                {
                    TxtBox.Text = TxtBox.Text + "7";
                }
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.D8)
            {
                if (TxtBox.Text == "0" && TxtBox.Text != null)
                {
                    TxtBox.Text = "8";
                }
                else
                {
                    TxtBox.Text = TxtBox.Text + "8";
                }
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.D9)
            {
                if (TxtBox.Text == "0" && TxtBox.Text != null)
                {
                    TxtBox.Text = "9";
                }
                else
                {
                    TxtBox.Text = TxtBox.Text + "9";
                }
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.D0)
            {
                TxtBox.Text = TxtBox.Text + "0";
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.OemMinus)
            {
                FirstNumber = Convert.ToDouble(TxtBox.Text);
                TxtBox.Text = "0";
                Operation = "-";
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Oemplus)
            {
                FirstNumber = Convert.ToDouble(TxtBox.Text);
                TxtBox.Text = "0";
                Operation = "+";
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.NumPad1)
            {
                if (TxtBox.Text == "0" && TxtBox.Text != null)
                {
                    TxtBox.Text = "1";
                }
                else
                {
                    TxtBox.Text = TxtBox.Text + "1";
                }
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.NumPad2)
            {
                if (TxtBox.Text == "0" && TxtBox.Text != null)
                {
                    TxtBox.Text = "2";
                }
                else
                {
                    TxtBox.Text = TxtBox.Text + "2";
                }
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.NumPad4)
            {
                if (TxtBox.Text == "0" && TxtBox.Text != null)
                {
                    TxtBox.Text = "4";
                }
                else
                {
                    TxtBox.Text = TxtBox.Text + "4";
                }
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.NumPad5)
            {
                if (TxtBox.Text == "0" && TxtBox.Text != null)
                {
                    TxtBox.Text = "5";
                }
                else
                {
                    TxtBox.Text = TxtBox.Text + "5";
                }
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.NumPad6)
            {
                if (TxtBox.Text == "0" && TxtBox.Text != null)
                {
                    TxtBox.Text = "6";
                }
                else
                {
                    TxtBox.Text = TxtBox.Text + "6";
                }
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.NumPad7)
            {
                if (TxtBox.Text == "0" && TxtBox.Text != null)
                {
                    TxtBox.Text = "7";
                }
                else
                {
                    TxtBox.Text = TxtBox.Text + "7";
                }
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.NumPad8)
            {
                if (TxtBox.Text == "0" && TxtBox.Text != null)
                {
                    TxtBox.Text = "8";
                }
                else
                {
                    TxtBox.Text = TxtBox.Text + "8";
                }
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.NumPad9)
            {
                if (TxtBox.Text == "0" && TxtBox.Text != null)
                {
                    TxtBox.Text = "9";
                }
                else
                {
                    TxtBox.Text = TxtBox.Text + "9";
                }
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.NumPad0)
            {
                TxtBox.Text = TxtBox.Text + "0";
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Add)
            {
                FirstNumber = Convert.ToDouble(TxtBox.Text);
                TxtBox.Text = "0";
                Operation = "+";
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Subtract)
            {
                FirstNumber = Convert.ToDouble(TxtBox.Text);
                TxtBox.Text = "0";
                Operation = "-";
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Multiply)
            {
                FirstNumber = Convert.ToDouble(TxtBox.Text);
                TxtBox.Text = "0";
                Operation = "*";
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Divide)
            {
                FirstNumber = Convert.ToDouble(TxtBox.Text);
                TxtBox.Text = "0";
                Operation = "/";
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Enter)
            {
                double SecondNumber;
                double Result;

                SecondNumber = Convert.ToDouble(TxtBox.Text);

                if (Operation == "+")
                {
                    Result = (FirstNumber + SecondNumber);
                    TxtBox.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "-")
                {
                    Result = (FirstNumber - SecondNumber);
                    TxtBox.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "*")
                {
                    Result = (FirstNumber * SecondNumber);
                    TxtBox.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "/")
                {
                    if (SecondNumber == 0)
                    {
                        TxtBox.Text = "Cannot divide by zero";

                    }
                    else
                    {
                        Result = (FirstNumber / SecondNumber);
                        TxtBox.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                    }
                }
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Decimal)
            {
                TxtBox.Text = TxtBox.Text + ".";
            }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Back)
            {
                if (TxtBox.Text == "" && TxtBox.Text != null)
                {
                    TxtBox.Text = "0";
                }
                else
                {
                    TxtBox.Text = TxtBox.Text.Remove(TxtBox.Text.Length - 1);
                }
            }
            return base.ProcessDialogKey(keyData);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "" && TxtBox.Text != null)
            {
                TxtBox.Text = "0";
            }
            else
            {
                TxtBox.Text = TxtBox.Text.Remove(TxtBox.Text.Length - 1);
            }
        }
    }
}
