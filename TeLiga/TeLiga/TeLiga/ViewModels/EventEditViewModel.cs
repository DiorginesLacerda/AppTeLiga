using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeLiga.ViewModels
{
    class EventEditViewModel
    {
        public List<string> Cities { get; set; }

        public EventEditViewModel()
        {
            this.Cities = new List<string>
            {
                "Gravataí","Glorinha"
            };
        }

    }
}
