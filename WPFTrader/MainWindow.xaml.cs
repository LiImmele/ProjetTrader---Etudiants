﻿using System;
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
using GestionnaireBDD;
using MetierTrader;

namespace WPFTrader
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GstBdd ungstbdd;

        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ungstbdd = new GstBdd();
        }

        private void lstTraders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lstTraders.SelectedItem != null)
            {
                lstTraders.ItemsSource = 
            }
            
        }

        private void lstActions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lstActions.SelectedItem != null)
            {
                lstActions.ItemsSource = GstBdd.Equals(lstActions.ItemsSource)
            }
        }

        private void btnVendre_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnAcheter_Click(object sender, RoutedEventArgs e)
        {
            newAcheter frm = new newAcheter(GstBdd);
            frm.Show();
        }
    }
}
