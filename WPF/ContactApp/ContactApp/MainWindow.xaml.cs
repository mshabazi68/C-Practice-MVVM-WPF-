using ContactApp.Classes;
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

namespace ContactApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ReadDB();
        }




        private void NewContent_Click(object sender, RoutedEventArgs e)
        {
            NewContactWindow newContact = new NewContactWindow();
            // you cannot click on the other window that opened earlier ! 
            newContact.ShowDialog();

            ReadDB();
        }

        void ReadDB()
        {

            List<Contact> myContact;
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.dbPath))
            {
                conn.CreateTable<Contact>();
                myContact = conn.Table<Contact>().ToList(); 
            }
            if( myContact != null)
            {
                // updating the list and adding the new item to the list ! using contactlistvew
                ContactListView.ItemsSource = myContact;
              
              
            }

        }
    }
    
}
