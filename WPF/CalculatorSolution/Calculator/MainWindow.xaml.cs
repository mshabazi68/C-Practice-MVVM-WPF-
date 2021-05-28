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
        public MainWindow()
        {
            InitializeComponent();
            btnAC.Click += BtnAC_Click;
            btnPlusmin.Click += BtnPlusmin_Click;
            btnMod.Click += BtnMod_Click;
            btnEqual.Click += BtnEqual_Click;
          

        }

        private void BtnMod_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber / 100;
                resultLabel.Content = lastNumber.ToString();


            }
        }

        private void BtnEqual_Click(object sender, RoutedEventArgs e)
        {
           // code here
        }

        private void BtnAC_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }

        private void BtnDiv_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }

        private void BtnPlusmin_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * -1;
                resultLabel.Content = lastNumber.ToString();
            }

        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "7";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content }7";
            }
        }


        
    }
}
