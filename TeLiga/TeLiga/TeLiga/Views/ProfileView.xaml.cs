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
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfileView : ContentPage
	{
        public User user { get; set; }
        public ProfileViewModel ViewModel { get; private set; }
        public ProfileView (User user)
		{
            this.user = user;
			InitializeComponent ();
            this.ViewModel = new ProfileViewModel(user);
            this.BindingContext = this.ViewModel;
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<ProfileViewModel>(this, "SaveProfile",
                async(msg) =>
                {
                    var confirma = await DisplayAlert("Salvar Perfil", "Deseja salvar as altereções?", "Sim", "Não");

                    if (confirma)
                    {
                        this.ViewModel.SaveProfile();
                    }
                });

            MessagingCenter.Subscribe<ProfileViewModel>(this, "ProfileSaved",
                (msg) =>
                {
                    DisplayAlert("Sucesso!", "Alterações Salvas com Sucesso", "ok");
                });
             

        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<ProfileViewModel>(this, "SaveProfile");
        }
    }
}