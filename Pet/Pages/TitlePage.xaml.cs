using System;
using System.Drawing;
using System.Threading;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace Pet.Pages
{
    /// <summary>
    /// Interaction logic for Title.xaml
    /// </summary>
    public partial class Title
    {
        public Title()
        {
            InitializeComponent();
        }

        private void StartMatrix(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            if (nav != null) nav.Navigate(new Uri("Pages/MatrixPage.xaml", UriKind.RelativeOrAbsolute));
        }        
        
        private void StartSnake(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            if (nav != null) nav.Navigate(new Uri("Pages/SnakePage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {

        }

    }
}
