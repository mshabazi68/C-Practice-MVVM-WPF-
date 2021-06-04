
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
    /// Interaction logic for ContactDetailWindow.xaml
    /// </summary>
   
    public partial class ContactDetailWindow : Window
    {
        Contact myContact;
       public ContactDetailWindow(Contact myContact)
        {
            InitializeComponent();

            this.myContact = myContact;
            // showing the Data in the update filed 
            nameTextBox.Text = myContact.Name;
            phoneTextBox.Text = myContact.Phone;
            emailTextBox.Text = myContact.Email;

        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            // setting new data into the name phone and email 
            myContact.Name = nameTextBox.Text  ;
            myContact.Phone =phoneTextBox.Text ;
            myContact.Email = emailTextBox.Text;
            using (SQLiteConnection connection = new SQLiteConnection(App.dbPath))
            {
                // opreation for creating table 
                connection.CreateTable<Contact>();
                // Update to the table 
                connection.Update(myContact);
            };


            // close the app           
            this.Close();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(App.dbPath))
            {
                // opreation for creating table 
                connection.CreateTable<Contact>();
                // Deleting to the table 
                connection.Delete(myContact);
            };
            // close the Window
            this.Close();
        }
    }
}
