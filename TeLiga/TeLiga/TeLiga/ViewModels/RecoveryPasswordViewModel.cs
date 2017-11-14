using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TeLiga.ViewModels
{
    public class RecoveryPasswordViewModel
    {
        public ICommand SendCommand { get; set; }

        public RecoveryPasswordViewModel()
        {
            SendCommand = new Command(
                ()=> 
                {
                    MessagingCenter.Send(this, "ReturnLoginView");
                });
        }
    }
}
