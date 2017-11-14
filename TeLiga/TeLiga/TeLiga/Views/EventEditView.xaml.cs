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
    public partial class EventEditView : ContentPage
    {
        EventEditViewModel ViewModel;
        public EventEditView()
        {
            InitializeComponent();
            this.ViewModel = new EventEditViewModel();
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
                        this.ViewModel.SubmitEvent();
                    }
                });

            MessagingCenter.Subscribe<EventEditViewModel>(this, "SubmitEventSucesss",
                async(msg) =>
                {
                    await DisplayAlert("Sucesso", "Seu evento foi enviado para a moderação", "Ok");
                    Navigation.RemovePage(this);
                });
        }


        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<EventEditViewModel>(this, "SubmitEvent");
            MessagingCenter.Unsubscribe<EventEditViewModel>(this, "SubmitEventSucesss");
        }
    }
}