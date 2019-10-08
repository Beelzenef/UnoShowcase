using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UnoShowcase.Shared.Views
{
    public sealed partial class InputsView : Page
    {
        public InputsView()
        {
            this.InitializeComponent();
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
