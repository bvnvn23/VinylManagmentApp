﻿using System.Windows;
using VinylManagmentApp.Model;

namespace VinylManagmentApp;

public partial class MainWindow : Window
{
    private void Button_Add(object sender, RoutedEventArgs e)
    {
        var recordWindow = new RecordWindow();
        recordWindow.Show();
    }

    private void Button_Edit(object sender, RoutedEventArgs e)
    {

    }

    private void Button_Delete(object sender, RoutedEventArgs e)
    {
        
    }

}