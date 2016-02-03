using System;
using System.Windows;
using System.Windows.Navigation;

namespace Collection.Pages
{
    public partial class Title
    {
        public Title()
        {
            InitializeComponent();
        }

        private void StartMatrix(object sender, RoutedEventArgs e)
        {

        }        
        
        private void StartSnake(object sender, RoutedEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);
            if (nav != null) nav.Navigate(new Uri("Pages/SnakePage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void StartTetris(object sender, RoutedEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);
            if (nav != null) nav.Navigate(new Uri("Pages/TetrisPage.xaml", UriKind.RelativeOrAbsolute));
        }

    }
}
