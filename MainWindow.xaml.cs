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
using Practica1.Practica1DataSetTableAdapters;

namespace Practica1
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

        private void Authors_Button_Click(object sender, RoutedEventArgs e)
        {
            Authors AuthorsPage = new Authors();
            this.Content = AuthorsPage;
        }

        private void Books_Button_Click(object sender, RoutedEventArgs e)
        {
            BooksPage BooksPage1 = new BooksPage();
            this.Content = BooksPage1;
        }
    }
}
