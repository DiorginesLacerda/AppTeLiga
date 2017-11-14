using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TeLiga.ViewModels
{
    public class ProfileViewModel
    {
        public ICommand SaveProfileCommand { get; set; }

        public ProfileViewModel()
        {
            this.SaveProfileCommand = new Command(
                () =>
                {

                });
        }
    }
}
