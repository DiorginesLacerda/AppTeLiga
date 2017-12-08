using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeLiga.Views;
using TeLiga.ViewModels;
using Xamarin.Forms;
using System.Threading.Tasks;
using TeLiga.Models;

namespace TeLiga
{
    public partial class App : Application
    {
        
        public static MasterDetailView MasterDetail { get; set; }

        public async static Task NavigateMasterDetail(Page page)
        {
            App.MasterDetail.IsPresented = false;
            await App.MasterDetail.Detail.Navigation.PushAsync(page);
        }
        public App()
        {
            //InitializeComponent();
            MainPage = new NavigationPage(new LoginView());
        }

        protected override void OnStart()
        {
            MessagingCenter.Subscribe<User>(this, "SucessLogin",
                (user) =>
                {
                    MainPage = new MasterDetailView(user);
                });
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
