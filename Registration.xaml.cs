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
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Data;

namespace Jukebox
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private static string dbString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=H:\private\CIS 310\final\Jukebox\Jukebox\userDB.mdf;Integrated Security=True";
        MainWindow mainWindow = new MainWindow();
        JukeboxPlayer jukeboxPlayer = new JukeboxPlayer();

       

        private void submitBtn_Click(object sender, RoutedEventArgs e) //adds username in password into the database
        {
            string username = rUsernameTB.Text;
            string password = rPasswordBox.Password;

            if (rPasswordBox.Password.Length == 0) //password textbox must contain something
            {
                errormessage.Text = "Enter password.";
                rPasswordBox.Focus();
            }
            else if (rPasswordBoxConfirm.Password.Length == 0) //pasword confirm textbox must contain something
            {
                errormessage.Text = "Enter Conformation password.";
                rPasswordBoxConfirm.Focus();
            }
            else if (rPasswordBox.Password != rPasswordBoxConfirm.Password) // both password boxes content must match
            {
                errormessage.Text = "Passwords must match.";
                rPasswordBoxConfirm.Focus();
            }
            else
            {
                errormessage.Text = "";
                SqlConnection con = new SqlConnection(dbString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Users (Username,Password) values('" + username + "','" + password + "')", con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                //errormessage.Text = "You have Registered successfully.";
                MessageBox.Show("You are now registered.");
                //Reset();
                Close();
                jukeboxPlayer.Show();
            }
        }

        public void Reset() // clear all text boxes
        {
            rUsernameTB.Text = "";
            rPasswordBox.Password = "";
            rPasswordBoxConfirm.Password = "";
            errormessage.Text = "";
        }

        private void resetBtn_Click(object sender, RoutedEventArgs e) //clears all text boxes with reset method
        {
            Reset();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e) //return to the main window
        {
            Close();
            mainWindow.Show();   
        }
    }
}
