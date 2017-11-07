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
    
    public partial class MenuMasterView : ContentPage
    {
        MenuMasterViewModel ViewMovel;
        public MenuMasterView()
        {
            InitializeComponent();
            this.ViewMovel = new MenuMasterViewModel();
            this.BindingContext = this.ViewMovel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<MenuMasterViewModel>(this, "CreateNewEvent",
                async (msg) =>
                {
                    
                    await App.NavigateMasterDetail(new EventEditView());
                   // this.Detail = new NavigationPage(new EventEditView());
                });
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<MenuMasterViewModel>(this, "CreateNewEvent");
        }
    }
}