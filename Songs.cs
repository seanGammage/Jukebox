using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Jukebox
{
    class Songs
    {
      

        private string artistName;
        private string songTitle;
        private string filePath;


         public string ArtistName
        {
            get { return artistName; }
            set {artistName = value;}
        }

        public string Songtitle
        {
            get {return songTitle;}
            set {songTitle = value;}
        }

        public string FilePath
        {
            get {return filePath;}
            set {filePath = value;}
        }


        }
    
}
