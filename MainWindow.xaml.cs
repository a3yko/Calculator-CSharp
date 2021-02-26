using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        string input = string.Empty;
        string number1 = string.Empty;
        string number2 = string.Empty;
        char oper;
        float result = 0.0f;
        public MainWindow()
        {
            InitializeComponent();
            output.FontSize = 16;
            output.IsReadOnly = true;
            output.Text = "0";
        }
        private void dec(object sender, RoutedEventArgs e)
        {
            output.Text = "";
            input += ".";
            output.Text += input;
        }
        private void zero(object sender, RoutedEventArgs e)
        {
            output.Text = "";
            input += "0";
            output.Text += input;
        }
        private void one(object sender, RoutedEventArgs e)
        {
            output.Text = "";
            input += "1";
            output.Text += input;
        }
        private void two(object sender, RoutedEventArgs e)
        {
            output.Text = "";
            input += "2";
            output.Text += input;
        }
        private void three(object sender, RoutedEventArgs e)
        {
            output.Text = "";
            input += "3";
            output.Text += input;
        }
        private void four(object sender, RoutedEventArgs e)
        {
            output.Text = "";
            input += "4";
            output.Text += input;
        }
        private void five(object sender, RoutedEventArgs e)
        {
            output.Text = "";
            input += "5";
            output.Text += input;
        }
        private void six(object sender, RoutedEventArgs e)
        {
            output.Text = "";
            input += "6";
            output.Text += input;
        }
        private void seven(object sender, RoutedEventArgs e)
        {
            output.Text = "";
            input += "7";
            output.Text += input;
        }
        private void eight(object sender, RoutedEventArgs e)
        {
            output.Text = "";
            input += "8";
            output.Text += input;
        }
        private void nine(object sender, RoutedEventArgs e)
        {
            output.Text = "";
            input += "9";
            output.Text += input;
        }
        private void star(object sender, RoutedEventArgs e)
        {
            number1 = input;
            oper = '*';
            input = string.Empty;
        }
        private void add(object sender, RoutedEventArgs e)
        {
            number1 = input;
            oper = '+';
            input = string.Empty;
        }
        private void subtract(object sender, RoutedEventArgs e)
        {
            number1 = input;
            oper = '-';
            input = string.Empty;
        }
        private void divide(object sender, RoutedEventArgs e)
        {
            number1 = input;
            oper = '/';
            input = string.Empty;
        }
        private void equals(object sender, RoutedEventArgs e)
        {
            number2 = input;
            float num1, num2;
            float.TryParse(number1, out num1);
            float.TryParse(number2, out num2);
            switch (oper)
            {
                case '+':
                   result =  num1 + num2;
                    output.Text = result.ToString();
                    break;
                case '-':
                    result = num1 - num2;
                    output.Text = result.ToString();
                    break;
                case '*':
                    result = num1 * num2;
                    output.Text = result.ToString();
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        output.Text = result.ToString();
                    }
                    break;
            }
        }
        private void clear(object sender, RoutedEventArgs e)
        {
            output.Text = "0";
            input = string.Empty;
            number1 = string.Empty;
            number2 = string.Empty;
        }
        private void neg(object sender, RoutedEventArgs e)
        {
            float negative; 
            float.TryParse(input, out negative);
            negative = negative * -1;
            input = negative.ToString();
            output.Text = input;
        }

    }
}
