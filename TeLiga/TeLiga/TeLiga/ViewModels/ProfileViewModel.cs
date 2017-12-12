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
    public class ProfileViewModel
    {
        public ICommand SaveProfileCommand { get; set; }
        public User user { get; set; }

        

        public string Name
        {
            get { return this.user.Name; }
            set { user.Name = value; }
        }

        public DateTime Birth
        {
            get { return this.user.Birth; }
            set { this.user.Birth = value; }
        }

        public string Cpf
        {
            get { return this.user.Cpf; }
            set { this.user.Cpf = value; }
        }

        public string Email
        {
            get { return this.user.Email; }
            set { this.user.Email = value; }
        }

        public string City
        {
            get { return this.user.City; }
            set { this.user.City = value; }
        }

        public string UF
        {
            get { return this.user.UF; }
            set { this.user.UF = value; }
        }

        private string fisrtPassord;

        public string FirstPassord
        {
            get { return this.user.Password; }
            set { fisrtPassord = value; }
        }

        private string confirmtPassord;

        public string ConfirmPassord
        {
            get { return this.user.Password; }
            set { confirmtPassord = value; }
        }

        public string Password
        {
            get { return this.user.Password; }
            set
            {
                this.user.Password = ValidatePassord()??this.user.Password;
            }
        }

        public string ValidatePassord()
        {
            if (fisrtPassord.Equals(confirmtPassord))
            {
                return fisrtPassord;
            }
            return null;
        }


        public void SaveProfile()
        {
            MessagingCenter.Send(this, "ProfileSaved");
        }


        public ProfileViewModel(User user)
        {
            this.user = user;
            this.SaveProfileCommand = new Command(
                () =>
                {
                    MessagingCenter.Send(this, "SaveProfile");
                });
        }
    }
}
