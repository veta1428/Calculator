using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sum
{
    public partial class MainForm : Form
    {
        double a = 0;
        double b = 0;


        bool mistakeInFirst = false;
        bool mistakeInSecond = false; 

        public MainForm()
        {
            InitializeComponent();
        }

        private void PlusButton_CheckedChanged(object sender, EventArgs e)
        {
            calc = (a, b) => checked(a + b);
            PrintResult();
        }

        private void PrintResult()
        {
            Tuple<double, bool> result = CalculateAndCheck(a, b);
            if (mistakeInFirst || mistakeInSecond)
            {
                ErrorTable.Text = "Wrong input!";
                Mistake.Text = "Mistake:";
                ResultLabel.Text = "ERROR";
                
            }
            else if (!MinusButton.Checked && !MultiplicationButton.Checked && !PlusButton.Checked && !DivisionButton.Checked)
            {
                ResultLabel.Text = "choose operation";
            }
            else if (result.Item2 == true)
            {
                ResultLabel.Text = "ERROR";
            }
            else
            {
                ResultLabel.Text = result.Item1.ToString();
            }
        }

        private delegate double Operation(double a, double b);
        Operation calc = (a, b) => 0;

        private Tuple<double, bool> CalculateAndCheck(double a, double b)
        {
            double result = 0;
            bool isMistake = false;
            try
            {
                result = calc(a, b);
                ErrorTable.Text = "";
                Mistake.Text = "";
            }
            catch (System.OverflowException)
            {
                ErrorTable.Text = "Wrong input! \nOverflow happened!";
                Mistake.Text = "Mistake:";
                isMistake = true;
            }
            catch (System.DivideByZeroException)
            {
                ErrorTable.Text = "Can't divide by zero!";
                Mistake.Text = "Mistake:";
                isMistake = true;
            }
            return Tuple.Create(result, isMistake);
        }

        private void MinusButton_CheckedChanged(object sender, EventArgs e)
        {
            calc = (a, b) => checked(a - b);
            PrintResult();
        }

        private void MultiplicationButton_CheckedChanged(object sender, EventArgs e)
        {
            calc = (a, b) => checked(a * b);
            PrintResult();
        }

        private void DivisionButton_CheckedChanged(object sender, EventArgs e)
        {
            calc = (a, b) => checked(a / b);
            PrintResult();
        }

        private Tuple<Double, Boolean> CheckStringAndConvert(string str)
        {
            

            double result = 0;
            bool isInputMistake = false;

            try
            {
                result = Convert.ToDouble(str);
            }
            catch (System.FormatException)
            {
                isInputMistake = true;
            }
            catch (System.OverflowException)
            {
                isInputMistake = true;
            }
            return Tuple.Create(result, isInputMistake);
        }

        private void FirstNumber_TextChanged(object sender, EventArgs e)
        {
            string str = FirstNumber.Text;

            Tuple<double, bool> info = CheckStringAndConvert(str);
            
            
            if (info.Item2 == true)
            {
                mistakeInFirst = true;
                CheckMistakeFirst.Text = "*";
            }
            else
            {
                mistakeInFirst = false;
                CheckMistakeFirst.Text = "OK";
            }

            if (mistakeInFirst == false)//deleting nbsp
            {
                str = GetStrWithOutNBSP(str);
                FirstNumber.Text = str;
                FirstNumber.SelectionStart = str.Length;
            }
            string buf = str;
            str = FormatingZero(str);//getting string without first zeroes

            if (str.Length != 0)
            {
                FirstNumber.Text = str;
                FirstNumber.SelectionStart = str.Length;
                buf = str;
            }

            str = ControlMinus(buf);//working on minus

            if (str.Length != 0)
            {
                FirstNumber.Text = "-" + str;
                FirstNumber.SelectionStart = str.Length + 1;
            }

            str = NoManyComas(buf);
            if (str.Length != 0)
            {
                FirstNumber.Text = str;
                FirstNumber.SelectionStart = str.Length;
            }



            a = info.Item1;

            PrintResult();
           
        }
        private string GetStrWithOutNBSP(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]!= ' ')
                {
                    result += str[i];
                }
            }
            return result;
        }

        private string ControlMinus(string str)
        {
            if (str.Length >= 3)
            {
                if (str[0] == '-')
                {
                    if (str[1] == '0')
                    {
                        if (str[2] == ',' && str.Length > 3)
                        {
                            return WithoutZeroAndSMTH(str, 3);
                        }
                        else if (str[2] != '.' && str[2] != ',')
                        {
                            return WithoutZeroAndSMTH(str, 2);
                        }
                    }
                }
            }
            return "";
        }

        

        private string  FormatingZero(string str)
        {

            if (str.Length >= 2)
            {                
                if (str[0] == '0')
                {
                    if (str[1] == ',' && str.Length > 2)
                    {
                        if (str[2] == ',')
                        {
                            return WithoutZeroAndSMTH(str, 3);
                        }
                        else
                        {
                            return WithoutZeroAndSMTH(str, 2);
                        }
                       
                    }
                    else if (str[1] != '.' && str[1] != ',')
                    {
                        return WithoutZeroAndSMTH(str, 1);  
                    }
                }
                
            }
            return "";
        }
        
        private string WithoutZeroAndSMTH(string str, int k)
        {
            string result = "";
            for (int i = k; i < str.Length; i++)
            {
                result += str[i];
            }
            return result;
        }

        private void SecondNumber_TextChanged(object sender, EventArgs e)
        {
            string str = SecondNumber.Text;


            Tuple<double, bool> info = CheckStringAndConvert(str);

            if (info.Item2 == true)
            {
                mistakeInSecond = true;
                CheckMistakeSecond.Text = "*";

            }
            else
            {
                mistakeInSecond = false;
                CheckMistakeSecond.Text = "OK";
            }

            if (mistakeInSecond == false)//deleting nbsp
            {
                str = GetStrWithOutNBSP(str);
                SecondNumber.Text = str;
                SecondNumber.SelectionStart = str.Length;
            }
            string buf = str;
            str = FormatingZero(str);//getting string without first zeroes

            if (str.Length != 0)
            {
                SecondNumber.Text = str;
                SecondNumber.SelectionStart = str.Length;
                buf = str;
            }

            str = ControlMinus(buf);//working on minus

            if (str.Length != 0)
            {
                SecondNumber.Text = "-" + str;
                SecondNumber.SelectionStart = str.Length + 1;
            }

            
            

            b = info.Item1;

            PrintResult();
        }

        private void FirstNumber_Validating(object sender, CancelEventArgs e)
        {
            if (FirstNumber.Text.Length != 0)
            {
                if (FirstNumber.Text[FirstNumber.Text.Length - 1] == ',' || FirstNumber.Text[FirstNumber.Text.Length - 1] == '.')
                {
                    FirstNumber.Text = CopyNoLast(FirstNumber.Text);
                }
            }
            
        }

        private string NoManyComas(string str)
        {
            string result = "";
            bool previousWasBadSign = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ',' && previousWasBadSign == false)
                {
                    result += str[i];
                    previousWasBadSign = true;
                }
                else if (str[i] != ',')
                {
                    result += str[i];
                    previousWasBadSign = false;
                }
            }
            return result;
        }

        private string CopyNoLast(string str)
        {
            int len = str.Length - 1;
            string result = "";
            for (int i = 0; i < len; i++)
            {
                result += str[i];
            }
            return result;
        }
    }
}
