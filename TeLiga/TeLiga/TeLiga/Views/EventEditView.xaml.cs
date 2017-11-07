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
    }
}