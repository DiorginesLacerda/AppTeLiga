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
    class NewAccountEditViewModel: BaseViewModel
    {
        public ICommand SaveAccountCommand { get; set; }
        public User User { get; set; }

        public string Name
        {
            get { return this.User.Name; }
            set
            {
                this.User.Name = value;
                OnPropertyChanged();
                ((Command)SaveAccountCommand).ChangeCanExecute();
            }
        }

        
        public DateTime Birth
        {
            get { return this.User.Birth; }
            set { this.User.Birth = value; }
        }

        
        public string Cpf
        {
            get { return this.User.Cpf; }
            set
            {
                this.User.Cpf = value;
                OnPropertyChanged();
                ((Command)SaveAccountCommand).ChangeCanExecute();
            }

        }


        public string Email
        {
            get { return this.User.Email; }
            set
            {
                this.User.Email = value;
                OnPropertyChanged();
                ((Command)SaveAccountCommand).ChangeCanExecute();
            }
        }
        

        public  string City
        {
            get { return this.User.City; }
            set
            {
                this.User.City = value;
                OnPropertyChanged();
                ((Command)SaveAccountCommand).ChangeCanExecute();
            }
        }

        public string UF
        {
            get { return this.User.UF; }
            set
            {
                this.User.UF = value;
                OnPropertyChanged();
                ((Command)SaveAccountCommand).ChangeCanExecute();
            }
        }

        

        public bool setPassword()
        {
            if (!string.IsNullOrEmpty(firstPassword) && firstPassword.Equals(confirmPassword))
            {
                User.Password = firstPassword;
                return true;
            }
            else
            {
                MessagingCenter.Send(this, "IncorrectPassorrd");
                return false;
            }
        }

        private string firstPassword;

        public string FirstPassword
        {
            get { return firstPassword; }
            set
            {
                firstPassword = value;
                OnPropertyChanged();
                ((Command)SaveAccountCommand).ChangeCanExecute();
            }
        }



        private string confirmPassword;

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                confirmPassword = value;
                OnPropertyChanged();
                ((Command)SaveAccountCommand).ChangeCanExecute();
            }
        }

        public NewAccountEditViewModel()
        {
            this.User = new User();
            this.User.Birth = DateTime.Now;
            SaveAccountCommand = new Command(
                async()=> 
                {
                    if (setPassword())
                    {
                        var resultUser = await NewAccountService.CreateNewAccount(this.User);
                        if (resultUser != null)
                        {
                            MessagingCenter.Send<User>(resultUser, "SucessLogin");
                        }
                        else
                        {
                           // MessagingCenter.Send<User>(this.User, "SucessLogin");
                             MessagingCenter.Send<User>(this.User, "FailCad");
                        }
                    }
                }, ()=>
                {
                    return !string.IsNullOrEmpty(this.Name)
                    && !string.IsNullOrEmpty(this.Cpf)
                    && !string.IsNullOrEmpty(this.Email)
                    && !string.IsNullOrEmpty(this.City)
                    && !string.IsNullOrEmpty(this.UF)
                    && !string.IsNullOrEmpty(this.FirstPassword)
                    && !string.IsNullOrEmpty(this.ConfirmPassword);
                });
        }

    }
}
