﻿using System;
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

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<LoginViewModel>(this, "CreateNewAccount",
                (msg) =>
                {
                    Navigation.PushAsync(new NewAccountEditView());
                });

            MessagingCenter.Subscribe<LoginViewModel>(this, "RecoveryPassword",
                (msg) =>
                {
                    Navigation.PushAsync(new RecoveryPasswordView());
                });

            MessagingCenter.Subscribe<string>(this, "FailLogin",
                async(msg) =>
                {
                    await DisplayAlert("Falha no Login", msg+"\nTente Novamente mais tarde", "Ok");
                });
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<LoginViewModel>(this, "CreateNewAccount");
            MessagingCenter.Unsubscribe<LoginViewModel>(this, "RecoveryPassword");
            MessagingCenter.Unsubscribe<LoginViewModel>(this, "FailLogin");
        }

    }
}