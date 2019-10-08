using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


namespace UnoShowcase.Shared.Views
{
    public sealed partial class ButtonsView : Page
    {
        public ButtonsView()
        {
            this.InitializeComponent();
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
