using System;
using Microsoft.Maui.Controls;

namespace CalculatorMauiApp
{
    public partial class MainPage : ContentPage
    {
        private string currentInput = string.Empty;
        private string currentOperator = string.Empty;
        private double firstNumber = 0;
        private double secondNumber = 0;
        private bool isNewCalculation = true;

        public MainPage()
        {
            InitializeComponent();
        }

        private void NumberButton_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Text;

            if (isNewCalculation)
            {
                Display.Text = buttonText;
                isNewCalculation = false;
            }
            else
            {
                Display.Text += buttonText;
            }
        }

        private void OperatorButton_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentOperator = button.Text;
            firstNumber = double.Parse(Display.Text);
            isNewCalculation = true;
        }

        private void ClearButton_Clicked(object sender, EventArgs e)
        {
            Display.Text = string.Empty;
            currentInput = string.Empty;
            currentOperator = string.Empty;
            firstNumber = 0;
            secondNumber = 0;
            isNewCalculation = true;
        }

        private void EqualsButton_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentOperator) && !isNewCalculation)
            {
                secondNumber = double.Parse(Display.Text);

                switch (currentOperator)
                {
                    case "+":
                        Display.Text = (firstNumber + secondNumber).ToString();
                        break;
                    case "-":
                        Display.Text = (firstNumber - secondNumber).ToString();
                        break;
                    case "*":
                        Display.Text = (firstNumber * secondNumber).ToString();
                        break;
                    case "/":
                        if (secondNumber != 0)
                        {
                            Display.Text = (firstNumber / secondNumber).ToString();
                        }
                        else
                        {
                            Display.Text = "Error";
                        }
                        break;
                }
            }
        }

        private void But_Clear_Clicked(object sender, EventArgs e)
        {
            ClearButton_Clicked(sender, e);
        }

        private void But_Add_Clicked(object sender, EventArgs e)
        {
            OperatorButton_Clicked(sender, e);
        }

        private void But_Subtract_Clicked(object sender, EventArgs e)
        {
            OperatorButton_Clicked(sender, e);
        }

        private void But_Multiply_Clicked(object sender, EventArgs e)
        {
            OperatorButton_Clicked(sender, e);
        }

        private void But_Divide_Clicked(object sender, EventArgs e)
        {
            OperatorButton_Clicked(sender, e);
        }

        private void But_Equals_Clicked(object sender, EventArgs e)
        {
            EqualsButton_Clicked(sender, e);
        }

        private void But_0_Clicked(object sender, EventArgs e)
        {
            NumberButton_Clicked(sender, e);
        }

        private void But_1_Clicked(object sender, EventArgs e)
        {
            NumberButton_Clicked(sender, e);
        }

        private void But_2_Clicked(object sender, EventArgs e)
        {
            NumberButton_Clicked(sender, e);
        }

        private void But_3_Clicked(object sender, EventArgs e)
        {
            NumberButton_Clicked(sender, e);
        }

        private void But_4_Clicked(object sender, EventArgs e)
        {
            NumberButton_Clicked(sender, e);
        }

        private void But_5_Clicked(object sender, EventArgs e)
        {
            NumberButton_Clicked(sender, e);
        }

        private void But_6_Clicked(object sender, EventArgs e)
        {
            NumberButton_Clicked(sender, e);
        }

        private void But_7_Clicked(object sender, EventArgs e)
        {
            NumberButton_Clicked(sender, e);
        }

        private void But_8_Clicked(object sender, EventArgs e)
        {
            NumberButton_Clicked(sender, e);
        }

        private void But_9_Clicked(object sender, EventArgs e)
        {
            NumberButton_Clicked(sender, e);
        }
    }
}
