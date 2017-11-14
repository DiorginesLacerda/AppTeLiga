using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TeLiga.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeLiga.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecoveryPasswordView : ContentPage
	{
        public RecoveryPasswordViewModel ViewModel { get; private set; }
        
        public RecoveryPasswordView ()
		{
			InitializeComponent ();
            ViewModel = new RecoveryPasswordViewModel();
            this.BindingContext = this.ViewModel;

		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<RecoveryPasswordViewModel>(this, "ReturnLoginView",
                (msg) =>
                {
                    Navigation.RemovePage(this);
                });
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<RecoveryPasswordViewModel>(this, "ReturnLoginView");
        }
    }
}