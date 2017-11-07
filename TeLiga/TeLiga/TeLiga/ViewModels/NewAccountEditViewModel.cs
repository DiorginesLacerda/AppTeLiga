using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TeLiga.ViewModels
{
    class NewAccountEditViewModel
    {
        public ICommand SaveAccountCommand { get; set; }

        public NewAccountEditViewModel()
        {
            SaveAccountCommand = new Command(
                ()=> 
                {
                    MessagingCenter.Send(this, "SucessLogin");
                });
        }

    }
}
