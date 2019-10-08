using UnoShowcase.Shared.Views;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UnoShowcase
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void GoChoices_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GoInputs_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(InputsView));
        }

        private void GoButtons_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ButtonsView));
        }
    }
}
