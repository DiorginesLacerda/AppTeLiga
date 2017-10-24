using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeLiga.Views;
using TeLiga.ViewModels;
using Xamarin.Forms;

namespace TeLiga
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new TeLiga.MainPage();
            MainPage = new LoginView();
        }

        protected override void OnStart()
        {
            MessagingCenter.Subscribe<LoginViewModel>(this, "SucessLogin",
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
