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

namespace Lab2Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string inputstring, operation, answer;
        double firstdouble, secondouble, output;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            secondouble = Convert.ToDouble(Input.Text);
            return;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            firstdouble = firstdouble + secondouble;
            answer = Convert.ToString(firstdouble);
            Answer.Content = answer;
            Input.Text = String.Empty;
            return;
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            firstdouble = firstdouble - secondouble;
            answer = Convert.ToString(firstdouble);
            Answer.Content = answer;
            Input.Text = String.Empty;
            return;
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "×";
            firstdouble = firstdouble * secondouble;
            answer = Convert.ToString(firstdouble);
            Answer.Content = answer;
            Input.Text = String.Empty;
            return;
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            operation = "÷";
            if (secondouble != 0)
            {
                firstdouble = firstdouble / secondouble;
                answer = Convert.ToString(firstdouble);
            }
            else
            {
                answer = "∞"; 
            }
            Answer.Content = answer;
            Input.Text = String.Empty;
            return;
        }

        private void ClearEntry_Click(object sender, RoutedEventArgs e)
        {
            Input.Text = String.Empty;
            return;
        }

        private void ClearAnswer_Click(object sender, RoutedEventArgs e)
        {
            Answer.Content = "No Answer";
        }

    }
}
