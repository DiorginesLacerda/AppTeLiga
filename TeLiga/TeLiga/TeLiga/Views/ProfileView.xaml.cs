using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeLiga.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeLiga.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfileView : ContentPage
	{
        public ProfileViewModel ViewModel { get; private set; }
        public ProfileView ()
		{
			InitializeComponent ();
            this.ViewModel = new ProfileViewModel();
            this.BindingContext = this.ViewModel;
		}
	}
}