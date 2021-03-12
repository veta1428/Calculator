using System;
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
        int a = 0;
        int b = 0;

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
            Tuple<int, bool> result = CalculateAndCheck(a, b);
            if (result.Item2 == true)
            {
                ResultLabel.Text = "ERROR";
            }
            else
            {
                ResultLabel.Text = result.Item1.ToString();
            }
        }

        private delegate int Operation(int a, int b);
        Operation calc = (a, b) => 0;

        private Tuple<int, bool> CalculateAndCheck(int a, int b)
        {
            int result = 0;
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

        private Tuple<Int32, Boolean> CheckStringAndConvert(string str/*, string smth*/)
        {
            int result = 0;
            bool isInputMistake = false;

            try
            {
                result = Convert.ToInt32(str);
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
            Tuple<int, bool> info = CheckStringAndConvert(str);

            if (info.Item2 == true)
            {
                FirstNumber.Text = CopyNoLast(FirstNumber.Text);
                FirstNumber.SelectionStart = FirstNumber.Text.Length;
                
                if (FirstNumber.Text.Length == 0)
                {
                    FirstNumber.Text = "0";
                    FirstNumber.SelectionStart = FirstNumber.Text.Length;
                    a = 0;
                }
                else
                {
                    a = Convert.ToInt32(FirstNumber.Text);
                }
            }
            else
            {
                a = info.Item1;
                FirstNumber.Text = a.ToString();
                FirstNumber.SelectionStart = FirstNumber.Text.Length;
            }

            PrintResult();
           
        }
        
       
        private string CopyNoLast(string s1)
        {
            string result = null;
            int len = s1.Length - 1;
            for (int i = 0; i < len; i++)
            {
                result += s1[i];
            }
            return result;
        }

        private void SecondNumber_TextChanged(object sender, EventArgs e)
        {
            string str = SecondNumber.Text;
            Tuple<int, bool> info = CheckStringAndConvert(str);

            if (info.Item2 == true)
            {
                SecondNumber.Text = CopyNoLast(SecondNumber.Text);
                SecondNumber.SelectionStart = SecondNumber.Text.Length;

                if (SecondNumber.Text.Length == 0)
                {
                    SecondNumber.Text = "0";
                    SecondNumber.SelectionStart = SecondNumber.Text.Length;
                    b = 0;
                }
                else
                {
                    b = Convert.ToInt32(SecondNumber.Text);
                }
            }
            else
            {
                b = info.Item1;
                SecondNumber.Text = b.ToString();
                SecondNumber.SelectionStart = SecondNumber.Text.Length;
            }

            PrintResult();
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //pictureBox1.Load();
            //pictureBox1.Image = Image.FromFile("C:\Users\Liza\source\repos\sum\sum\wallpaper.jpg");
        }

        private void pictureBox1_Layout(object sender, LayoutEventArgs e)
        {
            //pictureBox1.Load();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ResultLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form1.Size = new System.Drawing.Size(200, 200);
            //Form1.Width = 300;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
