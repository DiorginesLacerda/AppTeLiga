using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeLiga.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime Birth { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string UF { get; set; }
        public bool Moderator { get; set; }
    }
}
