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
    
    public partial class MasterDetailView : MasterDetailPage
    {
        
        public MasterDetailView(User user)
        {
            InitializeComponent();
            this.Master = new MenuMasterView(user);
            this.Detail = new NavigationPage(new EventListView(user));
            App.MasterDetail = this;
        }

        
    }
}