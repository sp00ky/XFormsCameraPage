using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms;

namespace CustomRenderer
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushPopupAsync(new MyPopupPage());
        }
    }
}
