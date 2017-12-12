using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TeLiga.Resources;
using TeLiga.Models;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace TeLiga.ViewModels
{
    class MenuMasterViewModel
    {
        public ICommand NewEventCommand { get; set; }
        public ICommand ProfileCommand { get; set; }
        public ICommand ExitCommand { get; set; }

        public MenuMasterViewModel(User user)
        {
            this.NewEventCommand = new Command(
                () =>
                {
                    MessagingCenter.Send<User>(user, "CreateNewEvent");
                });

            this.ProfileCommand = new Command(
                () =>
                {
                    MessagingCenter.Send<User>(user, "CallProfileView");
                });

            this.ExitCommand = new Command(
                () => 
                {
                    DependencyService.Get<IAction>().Close();
                });
            
        }

    }
}
