using ContactApp.Classes;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ContactApp
{
    /// <summary>
    /// Interaction logic for NewContactWindow.xaml
    /// </summary>
    public partial class NewContactWindow : Window
    {
        public NewContactWindow()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // Save button

            Contact mycontact = new Contact()
            {
                Name = nametxtBox.Text,
                Email = emailtxtBox.Text,
                Phone = emailtxtBox.Text
            };
            // Using here is a disposing method! after this block will end the connection

            using (SQLiteConnection connection = new SQLiteConnection(App.dbPath))
            {
                // opreation for creating table 
                connection.CreateTable<Contact>();
                // Inserting to the table 
                connection.Insert(mycontact);
            };

          
            /// close the connection 
            ///connection.Close(); this woks but not very good 


            this.Close();
        }
    }
}
