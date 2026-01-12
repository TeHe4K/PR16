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
using Microsoft.Win32;

namespace PR16.Pages
{
    /// <summary>
    /// Логика взаимодействия для Education.xaml
    /// </summary>
    public partial class Education : Page
    {
        public Education()
        {
            InitializeComponent();
        }

        private void Next(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/Status.xaml", UriKind.Relative));
        }

        private void FormStud(object sender, RoutedEventArgs e)
        {

        }

        private void File(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                openFileDialog.Filter = "PDF file (*.)|*.";
                file.Text = openFileDialog.FileName;
            }
        }
    }
}
