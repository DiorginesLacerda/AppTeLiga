using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeLiga.Views;
using TeLiga.ViewModels;
using Xamarin.Forms;
using System.Threading.Tasks;

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
            InitializeComponent();

            //MainPage = new TeLiga.MainPage();
            MainPage = new NavigationPage(new LoginView());
        }

        protected override void OnStart()
        {
            MessagingCenter.Subscribe<LoginViewModel>(this, "SucessLogin",
                (msg) =>
                {
                    MainPage = new MasterDetailView();
                });
            MessagingCenter.Subscribe<NewAccountEditViewModel>(this, "SucessLogin",
                (msg) =>
                {
                    MainPage = new MasterDetailView();
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
