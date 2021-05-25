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

namespace WpfBasic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"You submit the following text: { this.DescriptionText.Text}");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.welldCheck.IsChecked = this.AssemblyCheck.IsChecked = this.PlasmaCheck.IsChecked = this.LaserCheck.IsChecked = this.PlasmaCheck.IsChecked = this.latheCheck.IsChecked = this.PurchaseCheck.IsChecked= this.DrillCheck.IsChecked = this.FoldCheck.IsChecked = this.RollCheck.IsChecked = this.SawCheck.IsChecked = false;

            this.LengthText.Text = String.Empty;
        }

        private void welldCheck_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Check_Checked(object sender, RoutedEventArgs e)
        {
            this.LengthText.Text += ((CheckBox)sender).Content;

        }

        private void FinishDropdown_selection(object sender, SelectionChangedEventArgs e)
        {
            if (this.NoteText == null)
            {
                return;
            }
            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedValue;
            this.NoteText.Text = (string) value.Content ;
        }
    }
}
