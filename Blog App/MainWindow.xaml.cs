using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.Entity.Core.Objects;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Blog_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DfLessonDbEntities dataEntities = new DfLessonDbEntities(); // MSSQL database
        public MainWindow()
        {
            InitializeComponent();
            string[] testTables = new string[] {"Test","Hello","YAAY" };
            foreach (var x in testTables)
            {
                ListBoxTables.Items.Add(x);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //LoginWin loginWin = new LoginWin(this); // where 'this' is reference of current window
            //loginWin.Show();
        }
    }
}
