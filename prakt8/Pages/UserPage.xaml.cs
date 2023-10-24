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
using System.Windows.Navigation;
using System.Windows.Shapes;
using prakt8.Classes;

namespace prakt8.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        private User user { get; set; } = new User();
        public UserPage()
        {
            InitializeComponent();
            user.Username = "Vasya";
            user.Status = "Manager";
            user.LastLogin = new DateTime(2023, 10, 23);
            DataContext = user;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            user.Username = "Natashya";
            user.Status = "Admin";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string pattern = "Username: {0}; Status: {1}";
            MessageBox.Show(string.Format(pattern, user.Username, user.Status));
        }
    }
}
