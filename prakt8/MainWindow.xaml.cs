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
using prakt8.Pages;
namespace prakt8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void label1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            UserPage p = new UserPage();
            frame.Navigate(p);
        }

        private void label2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}