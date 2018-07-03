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
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Navigation;
using System.Data;
using System.Windows.Forms;

namespace Jukebox
{
    /// <summary>
    /// Interaction logic for jukeboxEditor.xaml
    /// </summary>
    public partial class jukeboxEditor : Window
    {
        public jukeboxEditor()
        {
            InitializeComponent();
        }

        private static string dbString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=H:\private\CIS 310\final\Jukebox\Jukebox\SongDB.mdf;Integrated Security=True";
        MainWindow mainWindow = new MainWindow();

        private void addBtn_Click(object sender, RoutedEventArgs e) //adds song title, artist name, file path, and image file path to database
        {
            string SongTitle = songTitleTb.Text;
            string ArtistName = artistNameTb.Text;
            string FilePath = filePathTb.Text;
            string ImagePath = imgPathTb.Text;

            if (songTitleTb.Text.Length == 0) // must have a title
            {
                System.Windows.Forms.MessageBox.Show("Enter a Song Title."); 
                songTitleTb.Focus();
            }
            else if (artistNameTb.Text.Length == 0) // must have an artist name
            {
                System.Windows.Forms.MessageBox.Show("Enter an Artist Name.");
                artistNameTb.Focus();
            }
            else if (filePathTb.Text.Length == 0) // must have a song
            {
                System.Windows.Forms.MessageBox.Show("Please Browse for a song.");
                filePathTb.Focus();
            }
            else
            {
                //errormessage.Text = "";
                SqlConnection con = new SqlConnection(dbString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Songs (songTitle,artistName,filePath,imgPath) values('" + SongTitle + "','" + ArtistName + "','" + FilePath + "','" + ImagePath + "')", con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                //errormessage.Text = "You have Registered successfully.";
                System.Windows.Forms.MessageBox.Show("Song is now stored in the library!");
                //Reset();
                Close();
                //jukeboxPlayer.Show();
                mainWindow.Show();
            }
           }
        

        private void browseBtn_Click(object sender, RoutedEventArgs e) //adds song uri to database
        {
            using (FileDialog fileDialog = new OpenFileDialog())
            {

                if (System.Windows.Forms.DialogResult.OK == fileDialog.ShowDialog())
                {
                    string filename = fileDialog.FileName;

                    filePathTb.Text = fileDialog.FileName;
                }
            }
        }

        private void browseImageBtn_Click(object sender, RoutedEventArgs e) //adds image uri to database
        {
            using (FileDialog imageDialog = new OpenFileDialog())
            {
                if (System.Windows.Forms.DialogResult.OK == imageDialog.ShowDialog())
                {
                    string imgFileName = imageDialog.FileName;
                    imgPathTb.Text = imageDialog.FileName;
                }
            }
        }

        private void loginPageBtn_Click(object sender, RoutedEventArgs e) //return to login page
        {
            mainWindow.Show();
            Close();
        }
        
    }
}
