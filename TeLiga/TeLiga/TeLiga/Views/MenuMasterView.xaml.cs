using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeLiga.Models;
using TeLiga.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeLiga.Views
{
    
    public partial class MenuMasterView : ContentPage
    {
        MenuMasterViewModel ViewMovel;
        public MenuMasterView(User user)
        {
            InitializeComponent();
            this.ViewMovel = new MenuMasterViewModel(user);
            this.BindingContext = this.ViewMovel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<User>(this, "CreateNewEvent",
                async (user) =>
                {
                    await App.NavigateMasterDetail(new EventEditView(user));
                   // this.Detail = new NavigationPage(new EventEditView());
                });
            if(Device.RuntimePlatform == Device.iOS)
            {
                this.btnExit.IsVisible = false;
            }

            MessagingCenter.Subscribe<User>(this, "CallProfileView",
                async(msg) =>
                {
                    await App.NavigateMasterDetail(new ProfileView(msg));
                });
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<MenuMasterViewModel>(this, "CreateNewEvent");
            MessagingCenter.Unsubscribe<MenuMasterViewModel>(this, "CallProfileView");
        }
    }
}