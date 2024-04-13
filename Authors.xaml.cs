using Practica1;
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
    /// Логика взаимодействия для BooksPage.xaml
    /// </summary>
    public partial class Authors : Page
    {
        AuthorsTableAdapter practica = new AuthorsTableAdapter();
        public Authors()
        {
            InitializeComponent();
            AuthorsDataGrid.ItemsSource = practica.GetData();
        }
        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();
        }
    }
}

