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
    public partial class LoginView : ContentPage
    {
        public LoginViewModel ViewModel { get; set; }
        public LoginView()
        {
            InitializeComponent();
            this.ViewModel = new LoginViewModel();
            this.BindingContext = this.ViewModel;
        }
    }
}