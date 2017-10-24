using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeLiga.Models
{
    public class EventVo
    {
        public string Title { get; set; }
        public DateTime DateEvent { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string Place { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public bool Alert { get; set; }
    }
}
