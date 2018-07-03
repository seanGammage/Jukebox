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

namespace Jukebox
{
    /// <summary>
    /// Interaction logic for JukeboxPlayer.xaml
    /// </summary>
    public partial class JukeboxPlayer : Window
    {
        // create a varable for the data source
        private static string SongdbString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=H:\private\CIS 310\final\Jukebox\Jukebox\SongDB.mdf;Integrated Security=True";

        public JukeboxPlayer()
        {
            InitializeComponent();
            fill_songListBox();
           
        }

      

        void fill_songListBox() //fills the listbox with database data
        {
            SqlConnection conn = new SqlConnection(SongdbString);
            try
            {
                conn.Open();
                string Query = "SELECT * FROM Songs ";

                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string artist = reader.GetString(1);
                    string title = reader.GetString(0);
                    string filePath = reader.GetString(2);
                    songListBox.Items.Add(filePath);
                }
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e) //remove selected item from listbox
        {
            songListBox2.Items.RemoveAt(songListBox2.Items.IndexOf(songListBox2.SelectedItem));
        }

        private void playBtn_Click(object sender, RoutedEventArgs e) //plays selected song from listbox
        {
            
            SqlConnection conn = new SqlConnection(SongdbString);
            conn.Open();
            string Query = "SELECT * FROM Songs ";
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string filePath = reader.GetString(2);
                string curPath = songListBox2.SelectedItem.ToString();
               
             
                mediaElement1.Source = new Uri(curPath);
            
                mediaElement1.Play();
            }
        }

        private void songListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void addBtn_Click(object sender, RoutedEventArgs e) //adds from first listbox to 2nd listbox
        {
            if (songListBox.SelectedIndex != -1)
            {
                songListBox2.Items.Insert(0, songListBox.SelectedValue);
                songListBox.Items.Remove(songListBox.SelectedValue);
            }
        }

        private void stopBtn_Click(object sender, RoutedEventArgs e) //stop song that is playing
        {
            mediaElement1.Stop();
        }

        private void pauseBtn_Click(object sender, RoutedEventArgs e) //pause song that is playing
        {
            mediaElement1.Pause();
        }
    }
}
