using System;

namespace VinylManagmentApp.Model
{
    class VinylRecord
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Year { get; set; }

        public VinylRecord(string title, string artist, string year)
        {
            Title = title;
            Artist = artist;
            Year = year;
        }
    }
}
