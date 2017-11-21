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

    public class UserLogin
    {
        public int Usuario_Id { get; set; }
        public int Tipo_Cadastro { get; set; }
        public string Guid { get; set; }
        public string Nome { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Data_Cadastro { get; set; }
        public string Data_Alteracao { get; set; }
        public int Ativo { get; set; }

        public User getUser()
        {
            return new User
            {
                Name = Nome,
                UF = Estado,
                City = Cidade,
                Email = Email,
                Password =Senha,
            };
        }
    }

}
