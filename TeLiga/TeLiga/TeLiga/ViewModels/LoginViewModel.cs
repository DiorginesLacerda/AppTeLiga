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
    public class LoginViewModel
    {
        public ICommand LoginCommand { get; set; }
        public ICommand NewAccountCommand { get; set; }
        public ICommand RecoveryAccountCommand { get; set; }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string password;

        public string Pasword
        {
            get { return password; }
            set { password = value; }
        }




        public LoginViewModel()
        {
            LoginCommand = new Command(
                ()=> 
                {

                    MessagingCenter.Send<User>(new User {Email=email,Password=password}, "SucessLogin");
                });

            NewAccountCommand = new Command(
                ()=> 
                {
                    //Mensagem para teste, deve ser Alterada
                    MessagingCenter.Send(this,"CreateNewAccount");
                });
            RecoveryAccountCommand = new Command(
                ()=> 
                {
                });

        }
    }
}
