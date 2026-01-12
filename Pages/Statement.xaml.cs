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

namespace PR16.Pages
{
    /// <summary>
    /// Логика взаимодействия для Statement.xaml
    /// </summary>
    public partial class Statement : Page
    {
        public Statement()
        {
            InitializeComponent();
        }

        private void FormStud(object sender, RoutedEventArgs e)
        {
            if (ZaochForm.IsChecked == true) 
            {
                Budget.IsChecked = false;
                Budget.IsEnabled = false;
                Dogovor.IsChecked = true;
            }
            else
            {
                Budget.IsEnabled = true;
            }
        }

        private void TipStud(object sender, RoutedEventArgs e)
        {

        }

        private void Next(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/Education.xaml", UriKind.Relative));
        }
    }
}
