using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace TeLiga.ViewModels
{
    class MenuMasterViewModel
    {
        public ICommand NewEventCommand { get; set; }
        public ICommand ProfileCommand { get; set; }
        public ICommand ExitCommand { get; set; }

        public MenuMasterViewModel()
        {
            this.NewEventCommand = new Command(
                () =>
                {
                    MessagingCenter.Send(this, "CreateNewEvent");
                });

            this.ProfileCommand = new Command(
                () =>
                {
                    MessagingCenter.Send(this, "CallProfileView");
                });

            this.ExitCommand = new Command(
                () => 
                {
                    
                });
            
        }

    }
}
