using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeLiga.Models;

namespace TeLiga.ViewModels
{
    public class EventViewModel
    {
        public EventVo EventVo { get; private set; }

        public string Title
        {
            get { return EventVo.Title; }
            private set { }
        }

        public DateTime DateEvent
        {
            get { return this.EventVo.DateEvent; }
            private set { }
        }

        

        public string Description
        {
            get { return this.EventVo.Description; }
            private set {  }
        }

        public string Link
        {
            get { return this.Link; }
            private set {  }
        }

        public string Place
        {
            get { return this.EventVo.Link; }
            private set { }
        }

        public string Adress
        {
            get { return this.EventVo.Adress; }
            private set { }
        }


        public string City
        {
            get { return this.EventVo.City; }
            private set {  }
        }

        

        public bool Alert
        {
            get { return this.EventVo.Alert; }
            set {  }
        }





        public EventViewModel(EventVo eventVo)
        {
            this.EventVo = eventVo;
        }

    }
}
