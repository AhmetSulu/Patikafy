using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikafy
{
    internal class Singer

    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MusicGenre { get; set; }
        public int DebutYear { get; set; }
        public long AlbumSales { get; set; }

        public Singer(string firstName, string lastName, string musicGenre, int debutYear, long albumSales)
        {
            FirstName = firstName;
            LastName = lastName;
            MusicGenre = musicGenre;
            DebutYear = debutYear;
            AlbumSales = albumSales;
        }
    }
}
