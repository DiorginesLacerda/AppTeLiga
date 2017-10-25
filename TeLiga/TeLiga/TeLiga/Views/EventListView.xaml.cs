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
    public partial class EventListView : ContentPage
    {
        public EventListViewModel ViewModel { get; set; }
        public EventListView()
        {
            InitializeComponent();
            this.ViewModel = new EventListViewModel();
            this.BindingContext = this.ViewModel;
            this.ListEvent.ItemsSource = ViewModel.Events;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<EventVo>(this, "SelectedEvent",
                (msg)=> 
                {
                    Navigation.PushAsync(new EventView(msg));
                });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}