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
    
    public partial class NewAccountEditView : ContentPage
    {
        NewAccountEditViewModel ViewModel;
        public NewAccountEditView()
        {
            InitializeComponent();
            this.ViewModel = new NewAccountEditViewModel();
            this.BindingContext = this.ViewModel;
        }
    }
}