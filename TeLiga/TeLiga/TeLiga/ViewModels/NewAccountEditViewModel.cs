using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TeLiga.Models;
using Xamarin.Forms;

namespace TeLiga.ViewModels
{
    class NewAccountEditViewModel
    {
        public ICommand SaveAccountCommand { get; set; }
        public User User { get; set; }

        public string Nome
        {
            get { return this.User.Name; }
            set { this.User.Name = value; }
        }


        public string Password
        {
            get { return this.User.Password; }
            set { this.User.Password = value; }
        }





        public NewAccountEditViewModel()
        {
            this.User = new User();
            SaveAccountCommand = new Command(
                ()=> 
                {
                    MessagingCenter.Send<User>(this.User, "SucessLogin");
                });
        }

    }
}
