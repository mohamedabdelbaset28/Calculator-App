using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_APP
{
    public partial class WinCalculator : Form
    {
        private string sOperator = string.Empty;
        private double dFirstNum = 0.0;
        private bool bNew = true;
        public WinCalculator()
        {
            InitializeComponent();
        }
        // Adding or appending Numbers...
        private void btnZero_Click(object sender, EventArgs e)
        {
            AddNumber("0");
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            AddNumber("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            AddNumber("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            AddNumber("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            AddNumber("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            AddNumber("5");
        }

        private void btnSex_Click(object sender, EventArgs e)
        {
            AddNumber("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            AddNumber("7");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            AddNumber("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            AddNumber("9");
        }

        // Fractional number....
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!(RtxtResult.Text.IndexOf(".") > -1))
            {
                RtxtResult.Text = RtxtResult.Text + ".";
                bNew = false;
            }
        }
        // Positive and Negative number....
        private void btnPositiveNegative_Click(object sender, EventArgs e)
        {
            if (!(RtxtResult.Text.Length == 1 && RtxtResult.Text == "0"))
            {
                if (RtxtResult.Text[0] == '-')
                    RtxtResult.Text = RtxtResult.Text.Substring(1);
                else
                    RtxtResult.Text = "-" + RtxtResult.Text;
            }
        }
        // Deleting last number..
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (RtxtResult.Text.Length == 1)
                RtxtResult.Text = "0";
            else
            {
                string sValue = RtxtResult.Text;
               RtxtResult.Text = sValue.Remove(sValue.Length - 1);
            }
        }
        // Clear all numbers... 
        private void btnClear_Click(object sender, EventArgs e)
        {
            RtxtResult.Text = "0";
            sOperator = string.Empty;
            bNew = true;
            dFirstNum = 0.0;
        }
        // Performing mathematical operations...
        private void btnPlus_Click(object sender, EventArgs e)
        {
            AddOperator("+");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            AddOperator("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            AddOperator("*");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            AddOperator("/");
        }

        private void btnReminder_Click(object sender, EventArgs e)
        {
            AddOperator("%");
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            AddOperator("=");
        }
        // Function to add any number... 
        private void AddNumber(string sNumber)
        {
            if ((RtxtResult.Text.Length == 1 && RtxtResult.Text == "0") || bNew)
            {
                RtxtResult.Text = sNumber;
                bNew = false;
            }
            else
                RtxtResult.Text = RtxtResult.Text + sNumber;

        }
        // Function to perform mathematical operation...
        private void AddOperator(string sOper)
        {
            double dResult = 0.0;
            if(!bNew)
            {
                if (sOperator != string.Empty)
                {
                    if (sOperator == "+")
                        dResult = dFirstNum + Convert.ToDouble(RtxtResult.Text);
                    else if (sOperator == "-")
                        dResult = dFirstNum - Convert.ToDouble(RtxtResult.Text);
                    else if (sOperator == "*")
                        dResult = dFirstNum * Convert.ToDouble(RtxtResult.Text);
                    else if (sOperator == "/")
                        dResult = dFirstNum / Convert.ToDouble(RtxtResult.Text);
                    else if (sOperator == "%")
                        dResult = dFirstNum % Convert.ToDouble(RtxtResult.Text);

                    if (sOperator != "=")
                        RtxtResult.Text = dResult.ToString();
                }
                dFirstNum = Convert.ToDouble(RtxtResult.Text);
                bNew = true;
            }
            sOperator = sOper;
        }
    }
}
