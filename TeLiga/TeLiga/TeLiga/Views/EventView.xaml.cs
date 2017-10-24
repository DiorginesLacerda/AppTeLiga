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
    public partial class EventView : ContentPage
    {
        public EventViewModel ViewModel { get; set; }
        
        public EventView(EventVo eventVo)
        {
            InitializeComponent();
            this.ViewModel = new EventViewModel(eventVo);
            this.BindingContext = this.ViewModel;
        }
    }
}