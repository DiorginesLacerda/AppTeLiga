using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeLiga.Models;

namespace TeLiga.ViewModels
{
    public class EventListViewModel
    {
        public EventVo Vo { get; set; }
        public ObservableCollection<EventVo> Events;

        public EventListViewModel()
        {
            this.Events = new ObservableCollection<EventVo>
            {
                new EventVo{ Title = " Evento XPTO", DateEvent = new DateTime(2009, 8, 1, 0, 0, 0)},
                new EventVo{ Title = " Evento XPTO"},
                new EventVo{ Title = " Evento XPTO"},
                new EventVo{ Title = " Evento XPTO"},
                new EventVo{ Title = " Evento XPTO"},
                new EventVo{ Title = " Evento XPTO"},
                new EventVo{ Title = " Evento XPTO"},
                new EventVo{ Title = " Evento XPTO"},
                new EventVo{ Title = " Evento XPTO"},
                new EventVo{ Title = " Evento XPTO"},
                new EventVo{ Title = " Evento XPTO"},
                new EventVo{ Title = " Evento XPTO"},
                new EventVo{ Title = " Evento XPTO"},
                new EventVo{ Title = " Evento XPTO"},
                new EventVo{ Title = " Evento XPTO"},
                new EventVo{ Title = " Evento XPTO"},
                new EventVo{ Title = " Evento XPTO"},
                new EventVo{ Title = " Evento XPTO"},
                new EventVo{ Title = " Evento XPTO"},
                new EventVo{ Title = " Evento XPTO"}

            };
        }
    }
}
