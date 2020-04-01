using Rg.Plugins.Popup.Contracts;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomRenderer
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyPopupPage : PopupPage
    {
		public MyPopupPage ()
		{
			InitializeComponent ();
		}


        protected override bool OnBackgroundClicked()
        {
           
            return base.OnBackgroundClicked();
        }

        private void PopupPage_BackgroundClicked(object sender, EventArgs e)
        {
            Navigation.PopPopupAsync();
        }
        // ### Overrided methods which can prevent closing a popup page ###

        // Invoked when a hardware back button is pressed
        //protected  override bool OnBackButtonPressed()
        //{
        //    // Return true if you don't want to close this popup page when a back button is pressed

        //  //  Navigation.PopAsync();

        //     Navigation.PopPopupAsync();
        //    return false;
        //}

        //// Invoked when background is clicked
        //protected  override bool OnBackgroundClicked()
        //{

        //     Navigation.PopPopupAsync();
        //    // Return false if you don't want to close this popup page when a background of the popup page is clicked
        //    return true;
        //}
    }
}