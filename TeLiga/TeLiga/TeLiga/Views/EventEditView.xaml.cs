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
    public partial class EventEditView : ContentPage
    {
        EventEditViewModel ViewModel;
        public EventEditView(User user)
        {
            InitializeComponent();
            this.ViewModel = new EventEditViewModel(user);
            this.BindingContext = this.ViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<EventEditViewModel>(this, "SubmitEvent",
                async (msg) =>
                {
                    var confirm = await DisplayAlert("Enviar Evento", "Confirma o envio das informações para moderação?",
                        "Sim", "Não");
                    if (confirm)
                    {
                        await ViewModel.SubmitEvent();
                    }
                });

            MessagingCenter.Subscribe<EventEditViewModel>(this, "SubmitEventSucesss",
                async(msg) =>
                {
                    await DisplayAlert("Sucesso", "Seu evento foi enviado para a moderação", "Ok");
                    Navigation.RemovePage(this);
                });

            MessagingCenter.Subscribe<EventEditViewModel>(this, "FailSubmitEvent",
                async (msg) =>
                {
                    await DisplayAlert("Falha", "Seu evento não pode ser enviado, por favor, tente mais tarde", "Ok");
                });
        }


        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<EventEditViewModel>(this, "SubmitEvent");
            MessagingCenter.Unsubscribe<EventEditViewModel>(this, "SubmitEventSucesss");
            MessagingCenter.Unsubscribe<EventEditViewModel>(this, "FailSubmitEvent");
        }
    }
}