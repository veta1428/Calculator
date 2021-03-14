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


        private delegate double Operation(double a, double b);
        Operation calc = (a, b) => 0;


        public MainForm()
        {
            InitializeComponent();
        }




        /// <summary>
        /// Block of getting calculated result and printing it:
        /// If there were mistakes in input we have appropriate message.
        /// If no operations is choosed the result is zero (default operation),
        /// but it asks user to chooseoperation and don't show result.
        /// If we had exceptions in calculating meaning it show ERROR in ResultLabel
        /// </summary>
        

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






        /// <summary>
        /// Block of making operation
        /// Try to calculate someting (even if the wrong input is displaying in FirstNumber and in SecondNumber we have a or b 0 then,
        /// so input here is correct
        /// If some mistakes happend like OverFlow or DivideByZero (here compiler put infinity to it, but still let it be),
        /// this displays it in ErrorTable and Mistake
        /// </summary>

       



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





        /// <summary>
        /// Block of switching operations to be done
        /// Sends message to calculate result
        /// </summary>
        




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

        private void PlusButton_CheckedChanged(object sender, EventArgs e)
        {
            calc = (a, b) => checked(a + b);
            PrintResult();
        }




        /// <summary>
        /// Block of checking if input is appropriate to further actions
        /// Sending a message about mistakes or their absence
        /// </summary>




        //
        //
        //
        //Trying to conver string to double:
        // if succeeded -> return double value and true
        // if not -> return 0 and false
        //
        //
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






        /// <summary>
        /// Block of getting input, then it is being checked and corrected (NOT making it valid for operations, just making it look prettier)
        /// Also it displays if input is correct/ can be used in operatios further
        /// </summary>







        //
        //
        //
        // Processing input FIRST number
        // Correcting it
        // Showing * if it has mistakes
        // Printing any result
        //
        //
        //
        private void FirstNumber_TextChanged(object sender, EventArgs e)
        {
            string str = FirstNumber.Text;

            Tuple<double, bool> info = CheckStringAndConvert(str);

            
           //displaying if any mistake exists 
            if (info.Item2 == true) 
            {
                mistakeInFirst = true;
                CheckMistakeFirst.Text = "*";
            }
            else
            {
                mistakeInFirst = false;
                CheckMistakeFirst.Text = "";
            }

            str = ProcessInput(str);

            //Showing input
            FirstNumber.Text = str;
            FirstNumber.SelectionStart = str.Length;

            a = info.Item1;

            PrintResult();          
        }
        //
        //
        //
        // Processing input SECOND number
        // Correcting it
        // Showing * if it has mistakes
        // Printing any result
        //
        //
        //
        private void SecondNumber_TextChanged(object sender, EventArgs e)
        {
            string str = SecondNumber.Text;

            Tuple<double, bool> info = CheckStringAndConvert(str);

            //displaying mistakes
            if (info.Item2 == true)
            {
                mistakeInSecond = true;
                CheckMistakeSecond.Text = "*";

            }
            else
            {
                mistakeInSecond = false;
                CheckMistakeSecond.Text = "";
            }

            str = ProcessInput(str);

            //showing corrected input
            SecondNumber.Text = str;
            SecondNumber.SelectionStart = str.Length;

            b = info.Item1;

            PrintResult();
        }






        /// <summary>
        /// Block of methods to correct input (NOT making it valid for operations, just making it look prettier)
        /// Used in SecondNumber_TextChanged, FirstNumber_TextChanged (also 1 method is used in Validating for both SecondNumber and FirstNumber)
        /// The most important and general method of the block is ProcessInput() is used in SecondNumber_TextChanged, FirstNumber_TextChanged
        /// </summary>






        //
        //
        //
        // Processing input
        //
        //
        //
        private string ProcessInput(string str)
        {
            //Deleting first " "
            str = GetStrWithOutNBSP(str);

            //Deleting first zeroes
            str = FormatingZero(str);

            //Deleting sequences of comas
            str = NoManyComas(str);

            return str;
        }
        //
        //
        //
        // Deleting first " "-s
        //
        //
        //
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
        //
        //
        //
        // Returns a string without last char
        //
        //
        //
        private string CopyNoFirst(string str)
        {
            int len = str.Length;
            string result = "";
            for (int i = 1; i < len; i++)
            {
                result += str[i];
            }
            return result;
        }
        //
        //
        //    Formating tricks with zero like:
        //    0,,* go to *
        //    00 go to 0
        //    0* go to *
        //    same with minus forward
        //
        //
        //
        private string  FormatingZero(string str)
        {
            bool wasMinus = false;

            if (str.Length >= 3)
            {
                if (str[0] == '-')
                {
                    str = CopyNoFirst(str);                      //string without minus
                    wasMinus = true;                             //remembering minus
                }
            }

            if (str.Length >= 2)
            {                
                if (str[0] == '0')
                {
                    if (str[1] == ',' && str.Length > 2)
                    {
                        if (str[2] == ',')                       //case 0,,* go to *
                        {
                            if (wasMinus == true)                //not to forget minus
                            {
                                return "-" + CopyFromKChar(str, 3);
                            }
                            return CopyFromKChar(str, 3);
                        }
                        else                                     //case 0,* go to *
                        {
                            if (wasMinus == true)                //not to forget minus
                            {
                                return "-" + CopyFromKChar(str, 2);
                            }
                            return CopyFromKChar(str, 2);
                        }
                       
                    }
                    else if (str[1] != '.' && str[1] != ',')     //case 0* go to *
                    {
                        if (wasMinus == true)                    //not to forget minus
                        {
                            return "-" + CopyFromKChar(str, 1);
                        }
                        return CopyFromKChar(str, 1);  
                    }
                }                
            }
            if (wasMinus == true)                                //not to forget minus
            {
                return "-" + str;
            }
            
            return str;
        }
        //
        //
        //
        //Copy string starting from string[k] char (inluding string[k])
        //
        //
        //
        private string CopyFromKChar(string str, int k)
        {
            string result = "";
            for (int i = k; i < str.Length; i++)
            {
                result += str[i];
            }
            return result;
        }
        //
        //
        //
        // From sequence of n comas delte n-1 ones 
        //
        //
        //
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
        //
        //
        //
        // Returns a string without last char
        //
        //
        //
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





        /// <summary>
        /// Block of events to correct input after losing focus
        /// For both FIRST and SECOND numbers
        /// Deleting last chars if they are "," or "."
        /// </summary>
        




       
        //
        //
        // FIRST number
        // Deleting last sign if it is "," or "." after losing focus
        // Works right after losing focus
        //
        //
        //
        private void FirstNumber_Validating(object sender, CancelEventArgs e)
        {
            string input = FirstNumber.Text;
            int len = input.Length;
            if (len != 0)
            {
                if (input[len - 1] == ',' || input[len - 1] == '.')
                {
                    FirstNumber.Text = CopyNoLast(input);
                }
            }           
        }
        //
        //
        // SECOND number
        // Deleting last sign if it is "," or "." after losing focus
        // Works right after losing focus
        //
        //
        private void SecondNumber_Validating(object sender, CancelEventArgs e)
        {
            string input = SecondNumber.Text;
            int len = input.Length;
            if (len != 0)
            {
                if (input[len - 1] == ',' || input[len - 1] == '.')
                {
                    SecondNumber.Text = CopyNoLast(input);
                }
            }
        }
    }
}
