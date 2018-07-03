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

namespace Jukebox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private User cUser = null;
        //MainWindow mainWindow = new MainWindow();
        JukeboxPlayer jukeboxPlayer = new JukeboxPlayer();

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Reset() //reset username textbox and password box to nothing
        {
            usernameTB.Text = "";
            passwordTB.Password = "";
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e) //login with already stored data in database
        {
             cUser = Login.login(usernameTB.Text, passwordTB.Password);

             if (cUser == null)
             {
                 
                 MessageBox.Show("The username or password is incorrect.");
                 passwordTB.Password = "";
                 usernameTB.Text = "";
             }
             else
             {
                 

                 usernameTB.Clear();
                 passwordTB.Clear();

                 MessageBox.Show("You are now logged in as "  + cUser.Name);
                 Close();
                 jukeboxPlayer.Show();
                 
                
             }
        }

      

        private void jukeboxBtn_Click(object sender, RoutedEventArgs e)
        {
            

           // mainWindow.Close();
            jukeboxPlayer.Show();
        }

        private void registerPageBtn_Click(object sender, RoutedEventArgs e) // button to register as new user
        {
            
            Registration registration = new Registration();
            registration.Show();
            Close();
        }

        private void unregisteredBtn_Click(object sender, RoutedEventArgs e)// button to login as unresistered user
        {
            jukeboxPlayer.Show();
            Close();
        }

        private void adminLoginBtn_Click(object sender, RoutedEventArgs e) //admin login to enter editor page
        {
            string admin = "admin";
            string password = "admin";

            if (usernameTB.Text == admin && passwordTB.Password == password)
            {

                jukeboxEditor jukeboxEditor = new jukeboxEditor();
                jukeboxEditor.Show();
                Close();
                
            }
            else
            {
                MessageBox.Show("Admin name or password is incorrect. Please try again.");
                Reset();
            }
            
        }
    }
}
