using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TeLiga.ViewModels
{
    class MenuMasterViewModel
    {
        public ICommand NewEventCommand { get; set; }
        public ICommand ExitCommand { get; set; }

        public MenuMasterViewModel()
        {
            this.NewEventCommand = new Command(
                () =>
                {
                    MessagingCenter.Send(this, "CreateNewEvent");
                });
            this.ExitCommand = new Command(() => { });
        }

    }
}
