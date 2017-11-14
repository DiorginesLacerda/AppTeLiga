using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TeLiga.ViewModels
{
    class EventEditViewModel
    {
        public List<string> Cities { get; set; }
        public ICommand SubmitEventCommand { get; set; }


        public void SubmitEvent()
        {
            MessagingCenter.Send(this, "SubmitEventSucesss");
        }

        public EventEditViewModel()
        {
            this.Cities = new List<string>
            {
                "Gravataí","Glorinha"
            };

            this.SubmitEventCommand = new Command(() =>
            {
                MessagingCenter.Send(this, "SubmitEvent");
            });
        }

    }
}
