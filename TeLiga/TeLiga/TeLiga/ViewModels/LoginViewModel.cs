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
        

        public LoginViewModel()
        {
            LoginCommand = new Command(
                ()=> 
                {
                    MessagingCenter.Send(this, "SucessLogin");
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
