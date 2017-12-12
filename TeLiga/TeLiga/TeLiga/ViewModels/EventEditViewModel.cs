using System;
using System.Collections;
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
    class EventEditViewModel:BaseViewModel
    {
        public List<string> Cities { get; set; }
        public ICommand SubmitEventCommand { get; set; }
        public EventVo eventVo { get; private set; }
        public User user { get; set; }

        public string Title
        {
            get { return this.eventVo.Title; }
            set
            {
                this.eventVo.Title = value;
                OnPropertyChanged();
                ((Command)SubmitEventCommand).ChangeCanExecute();
            }
        }


        public DateTime DateEvent
        {
            get { return DateTime.Now; }
            set { this.eventVo.DateEvent = value; }
        }

        public string Description
        {
            get { return this.eventVo.Description; }
            set
            {
                this.eventVo.Description = value;
                OnPropertyChanged();
                ((Command)SubmitEventCommand).ChangeCanExecute();
            }
        }

       

        public string Link
        {
            get { return this.eventVo.Link; }
            set
            {
                this.eventVo.Link = value;
                OnPropertyChanged();
                ((Command)SubmitEventCommand).ChangeCanExecute();
            }
        }

        
        public string Place
        {
            get { return this.eventVo.Place; }
            set
            {
                this.eventVo.Place = value;
                OnPropertyChanged();
                ((Command)SubmitEventCommand).ChangeCanExecute();
            }
        }


        public string Adress
        {
            get { return street + ", " + number; }
            set
            {
                this.eventVo.Adress = street+", "+number;
                OnPropertyChanged();
                ((Command)SubmitEventCommand).ChangeCanExecute();
            }
        }

        private string street;

        public string Street
        {
            get { return street; }
            set
            {
                street = value;
                OnPropertyChanged();
                ((Command)SubmitEventCommand).ChangeCanExecute();
            }
        }

        private string number;

        public string Number
        {
            get { return number; }
            set
            {
                number = value;
                OnPropertyChanged();
                ((Command)SubmitEventCommand).ChangeCanExecute();
            }
        }

        public string City
        {
            get { return this.eventVo.City; }
            set
            {
                this.eventVo.City = value;
                OnPropertyChanged();
                ((Command)SubmitEventCommand).ChangeCanExecute();
            }
        }






        public async Task SubmitEvent()
        {
            this.eventVo.Adress = street + ", " + number;
            var result = await NewEventService.CreateNewEvent(user, eventVo);

            if(result != null)
            {
                MessagingCenter.Send(this, "SubmitEventSucesss");
            }
            else
            {
                MessagingCenter.Send(this, "FailSubmitEvent");
            }
            

        }

        public EventEditViewModel(User user)
        {
            this.user = user;
            this.eventVo = new EventVo();

            this.Cities = new List<string>
            {
                "Gravataí","Glorinha"
            };

            this.SubmitEventCommand = new Command(() =>
            {

                MessagingCenter.Send(this, "SubmitEvent");
            },()=> 
            {
                return true
                /*
                !string.IsNullOrEmpty(this.eventVo.Title)
                && !string.IsNullOrEmpty(this.eventVo.Description)
                && !string.IsNullOrEmpty(this.eventVo.Link)
                && !string.IsNullOrEmpty(this.eventVo.Place)
                //&& !string.IsNullOrEmpty(this.Adress)
                && !string.IsNullOrEmpty(this.Street)
                && !string.IsNullOrEmpty(this.Number)
                && !string.IsNullOrEmpty(this.eventVo.City)
                */
                ;
            });
        }

    }
}
