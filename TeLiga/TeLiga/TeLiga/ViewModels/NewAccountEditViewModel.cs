using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TeLiga.Models;
using TeLiga.Services;
using Xamarin.Forms;

namespace TeLiga.ViewModels
{
    class NewAccountEditViewModel
    {
        public ICommand SaveAccountCommand { get; set; }
        public User User { get; set; }

        public string Name
        {
            get { return this.User.Name; }
            set { this.User.Name = value; }
        }

        
        public DateTime Birth
        {
            get { return this.User.Birth; }
            set { this.User.Birth = value; }
        }

        
        public string Cpf
        {
            get { return this.User.Cpf; }
            set { this.User.Cpf = value; }
        }


        public string Email
        {
            get { return this.User.Email; }
            set { this.User.Email = value; }
        }
        

        public  string City
        {
            get { return this.User.City; }
            set { this.User.City = value; }
        }

        public string UF
        {
            get { return this.User.UF; }
            set { this.User.UF = value; }
        }



        public string Password
        {
            get { return this.User.Password; }
            set { this.User.Password = value; }
        }

        public string ConfirmPassword { get; set; }






        public NewAccountEditViewModel()
        {
            this.User = new User();
            this.User.Birth = DateTime.Now;
            SaveAccountCommand = new Command(
                async()=> 
                {
                    var resultUser = await NewAccountService.CreateNewAccount(this.User);
                    if (resultUser!=null)
                    {
                        MessagingCenter.Send<User>(resultUser, "SucessLogin");
                    }
                    else
                    {
                        MessagingCenter.Send<User>(this.User, "SucessLogin");
                       // MessagingCenter.Send<User>(this.User, "FailCad");
                    }
                });
        }

    }
}
