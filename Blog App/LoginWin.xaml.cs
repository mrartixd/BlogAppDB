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

namespace Blog_App
{
    /// <summary>
    /// Interaction logic for LoginWin.xaml
    /// </summary>
    public partial class LoginWin : Window
    {
        MainWindow mainWindow = new MainWindow();
        public LoginWin(MainWindow obj)
        {
            InitializeComponent();
            mainWindow = obj;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(username.Text == "test" && password.Password == "test")
            {
                
                mainWindow.IsEnabled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong password or username", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
