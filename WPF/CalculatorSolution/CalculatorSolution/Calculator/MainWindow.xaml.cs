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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double lastNumber, result ;
        SelectedOperator selectedOperator;
        public MainWindow()
        {
            InitializeComponent();
            btnAC.Click += BtnAC_Click;
            btnPlusmin.Click += BtnPlusmin_Click;
            btnMod.Click += BtnMod_Click;
            btnEqual.Click += BtnEqual_Click;
          

        }

        private void BtnEqual_Click(object sender, RoutedEventArgs e)
        {
            double newNumber;
            if (double.TryParse(resultLabel.Content.ToString(), out newNumber))
            {
                switch (selectedOperator)
                {
                    case SelectedOperator.Addition:
                        result = CalculateMath.Add(lastNumber, newNumber);
                        break;

                    case SelectedOperator.Subtraction:
                        result = CalculateMath.Subtract(lastNumber, newNumber);
                        break;

                    case SelectedOperator.Multiplication:
                        result = CalculateMath.Multiply(lastNumber, newNumber);
                        break;

                    case SelectedOperator.Division:
                        result = CalculateMath.Divid(lastNumber, newNumber);
                        break;
                }
                resultLabel.Content = result.ToString();
            }


        }

        private void BtnMod_Click(object sender, RoutedEventArgs e)
        {
            double tempNumber;
            if (double.TryParse(resultLabel.Content.ToString(), out tempNumber))
            {
                tempNumber = tempNumber / 100;
                if ( lastNumber != 0)
                {
                    tempNumber *= lastNumber;
                }
                resultLabel.Content = tempNumber.ToString();


            }
        }



        private void BtnPlusmin_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * -1;
                resultLabel.Content = lastNumber.ToString();
            }

        }


        private void BtnAC_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }

        private void OperationBtn_click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {

                resultLabel.Content = "0";
            }
            if (sender == btnMulti)
                selectedOperator = SelectedOperator.Multiplication;
            if (sender == btnDiv)
                selectedOperator = SelectedOperator.Division;
            if (sender == btnAdd)
                selectedOperator = SelectedOperator.Addition;
            if (sender == btnSub)
                selectedOperator = SelectedOperator.Subtraction;

        }
        private void btnDot_click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString().Contains("."))
            {
                //Do noting
            }
            else
            {
                resultLabel.Content = $" {resultLabel.Content}.";
            }
        }


        private void BtnDiv_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }
     
        private void NumberBtn_Click(object sender, RoutedEventArgs e)
        {

            int selectedValue = int.Parse((sender as Button).Content.ToString());

            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = $"{selectedValue}";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}{selectedValue}";
            }
        }
        
    }

  
    public enum SelectedOperator
    {
        Addition,
        Subtraction,
        Multiplication,
        Division

    }

    public class CalculateMath
    {
        public static double Add ( double num1 , double num2)
        {
            return num1 + num2;
        }
        public static double Subtract (double num1 , double num2)
        {
            return num1 - num2;
        }
        public static double Divid (double num1, double num2)
        {
            if ( num2 == 0)
            {
                MessageBox.Show("Can Not Divid By 0 ", "Opps! Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return 0;
                
            }
            return num1 / num2;
        }
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}
