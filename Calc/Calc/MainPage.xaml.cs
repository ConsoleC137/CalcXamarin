using System;
using System.Linq;
using Xamarin.Forms;

namespace Calc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private double firstNumber = 0;
        private double secondNumber = 0;
        private double promNumber2 = 0;
        private char operation;
        private bool flagProm = false;
        private bool flagObnal = false;
        private void ObnalNum()
        {
            if (flagObnal)
            {
                myEntry.Text = "";
                myLabel.Text = "";
                flagObnal = false;
            }
        }

        private void button0_Clicked(object sender, EventArgs e)
        {
            ObnalNum();
            flagProm = false;
            myEntry.Text += 0;
        }

        private void buttonC_Clicked(object sender, EventArgs e)
        {
            myEntry.Text = "";
            firstNumber = 0; secondNumber = 0; promNumber2 = 0; char.TryParse("", out operation);
            myLabel.Text = "0";
        }

        private void buttonCE_Clicked(object sender, EventArgs e)
        {
            myEntry.Text = "";
        }

        private void button1_Clicked(object sender, EventArgs e)
        {
            ObnalNum();
            myEntry.Text += 1;
        }

        private void button2_Clicked(object sender, EventArgs e)
        {
            ObnalNum();
            myEntry.Text += 2;
        }

        private void button3_Clicked(object sender, EventArgs e)
        {
            ObnalNum();
            myEntry.Text += 3;
        }

        private void buttonP_Clicked(object sender, EventArgs e)
        {
            if (myEntry.Text != "" && myEntry.Text != ".")
            {
                double.TryParse(myEntry.Text, out firstNumber);
                myEntry.Text = "";
                operation = '+';
                flagProm = false;
                myLabel.Text = Convert.ToString(firstNumber) + operation;
            }

        }

        private void buttonM_Clicked(object sender, EventArgs e)
        {
            double.TryParse(myEntry.Text, out firstNumber);
            myEntry.Text = "";
            operation = '-';
            myLabel.Text = Convert.ToString(firstNumber) + operation;
        }

        private void button4_Clicked(object sender, EventArgs e)
        {
            ObnalNum();
            myEntry.Text += 4;
        }

        private void button5_Clicked(object sender, EventArgs e)
        {
            ObnalNum();
            myEntry.Text += 5;
        }

        private void button6_Clicked(object sender, EventArgs e)
        {
            ObnalNum();
            myEntry.Text += 6;
        }

        private void buttonD_Clicked(object sender, EventArgs e)
        {
            double.TryParse(myEntry.Text, out firstNumber);
            myEntry.Text = "";
            operation = '/';
            flagProm = false;
            myLabel.Text = Convert.ToString(firstNumber) + operation;
        }

        private void buttonU_Clicked(object sender, EventArgs e)
        {
            double.TryParse(myEntry.Text, out firstNumber);
            myEntry.Text = "";
            operation = '*';
            flagProm = false;
            myLabel.Text = Convert.ToString(firstNumber) + operation;
        }

        private void button7_Clicked(object sender, EventArgs e)
        {
            ObnalNum();
            myEntry.Text += 7;
        }

        private void button8_Clicked(object sender, EventArgs e)
        {
            ObnalNum();
            myEntry.Text += 8;
        }

        private void button9_Clicked(object sender, EventArgs e)
        {
            ObnalNum();
            myEntry.Text += 9;
        }

        private void buttonR_Clicked(object sender, EventArgs e)
        {
            double.TryParse(myEntry.Text, out secondNumber);

            if (flagProm == false)
            {
                promNumber2 = secondNumber;
            }

            if (flagProm)
            {
                switch (operation)
                {
                    case '+':
                        myEntry.Text = Convert.ToString(secondNumber + promNumber2);
                        break;
                    case '-':
                        myEntry.Text = Convert.ToString(secondNumber - promNumber2);
                        break;
                    case '/':
                        myEntry.Text = Convert.ToString(secondNumber / promNumber2);
                        break;
                    case '*':
                        myEntry.Text = Convert.ToString(secondNumber * promNumber2);
                        break;
                    default:
                        break;
                }
                myLabel.Text = Convert.ToString(secondNumber) + operation + Convert.ToString(promNumber2) + "=";
            }

            if (flagProm == false)
            {
                switch (operation)
                {
                    case '+':
                        myEntry.Text = Convert.ToString(firstNumber + secondNumber);

                        break;
                    case '-':
                        myEntry.Text = Convert.ToString(firstNumber - secondNumber);
                        break;
                    case '/':
                        myEntry.Text = Convert.ToString(firstNumber / secondNumber);
                        break;
                    case '*':
                        myEntry.Text = Convert.ToString(firstNumber * secondNumber);
                        break;
                    default:
                        break;
                }
                myLabel.Text = Convert.ToString(firstNumber) + operation + Convert.ToString(secondNumber) + "=";
            }

            if (firstNumber == 0 && secondNumber == 0 && promNumber2 == 0)
            {
                myLabel.Text = "";
            }

            flagProm = true;
            flagObnal = true;
        }

        private void buttonOneDel_Clicked(object sender, EventArgs e)
        {
            if (myEntry.Text != "")
            {
                if (myEntry.Text.Length <= 1)
                {
                    myEntry.Text = myEntry.Text = "";
                }

                else
                {
                    myEntry.Text = myEntry.Text.Remove(myEntry.Text.Length - 1);
                }
            }


        }

        private void buttonDot_Clicked(object sender, EventArgs e)
        {

            if (!myEntry.Text.Contains('.'))
            {
                myEntry.Text += '.';
            }
        }

        private void buttonPM_Clicked(object sender, EventArgs e)
        {
            if (!myEntry.Text.Contains("-"))
            {
                myEntry.Text = "-" + myEntry.Text;
            }
            else
            {
                myEntry.Text = myEntry.Text.Remove(0, 1);
            }
            
        }
    }
}
