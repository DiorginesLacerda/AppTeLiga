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
    
    public partial class NewAccountEditView : ContentPage
    {
        NewAccountEditViewModel ViewModel;
        public NewAccountEditView()
        {
            InitializeComponent();
            this.ViewModel = new NewAccountEditViewModel();
            this.BindingContext = this.ViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<NewAccountEditViewModel>(this, "IncorrectPassorrd",
                async(msg) =>
                {
                    await DisplayAlert("Erro de Senha", "As duas senhas não conferem", "Ok");
                });

            MessagingCenter.Subscribe<User>(this, "FailCad",
                async(msg) =>
                {
                    await DisplayAlert("Erro", "Falha ao salvar o cadastro, tente mais tarde", "Ok");
                });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<NewAccountEditViewModel>(this, "IncorrectPassorrd");
        }

    }
}