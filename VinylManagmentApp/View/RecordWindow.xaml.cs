using System;
using System.Windows;
using VinylManagmentApp.Model;

namespace VinylManagmentApp
{
    public partial class RecordWindow : Window
    {
        public RecordWindow()
        {
            InitializeComponent();
        }
        
        private void Save_Button(object sender, RoutedEventArgs e)
        {
            var inputs = new[] { TitleTextBox.Text, ArtistTextBox.Text, YearTextBox.Text };

            if (inputs.All(string.IsNullOrWhiteSpace))
            {
                MessageBox.Show("All fields are empty! Please enter data.");
                return;
            }

            if (!int.TryParse(YearTextBox.Text, out int year))
            {
                MessageBox.Show("Invalid year format!");
                return;
            }

            if (year < 1900 || year > DateTime.Now.Year)
            {
                MessageBox.Show("Invalid year range!");
                return;
            }

             VinylRecord newRecord = new VinylRecord(TitleTextBox.Text, ArtistTextBox.Text, YearTextBox.Text);
      
        }
        private void Cancel_Button(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
