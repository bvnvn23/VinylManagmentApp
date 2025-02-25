using System;

namespace VinylManagmentApp.Model
{
    class VinylRecord
    {
        string Title { get; set; }
        string Artist { get; set; }
        int Year { get; set; }

        public VinylRecord(string title, string artist, int year)
        {
            Title = title;
            Artist = artist;
            Year = year;
        }
    }
}
