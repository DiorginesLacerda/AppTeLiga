using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeLiga.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime Birth { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string UF { get; set; }
        //public bool Moderator { get; set; }
    }

    public class UserLogin
    {
        public int Usuario_Id { get; set; }
        public int Tipo_Cadastro { get; set; }
        public string Guid { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Data_Cadastro { get; set; }
        public string Data_Alteracao { get; set; }
        public string CPF { get; set; }
        public string Data_Nascimento { get; set; }
        public int Ativo { get; set; }

        public User getUser()
        {
            User user = new User();
            user.UserId = Usuario_Id;
            user.Name = Nome;
            user.Password = Senha;
            user.Birth = Convert.ToDateTime(Data_Nascimento ?? ("2017 - 12 - 04T21: 16:49.687"));
            user.Cpf = CPF ?? ("000.000.000-00");
            user.Email = Email;
            user.City = Cidade;
            user.UF = UF;

            return user; /*new User
            {
                UserId = Usuario_Id,
                Name = Nome,
                Password = Senha,
            //    Birth = Convert.ToDateTime(Data_Nascimento??("2017 - 12 - 04T21: 16:49.687")),
              //  Cpf = CPF??("000.000.000-00"),
                Email = Email,
                City = Cidade,
                UF = UF
            };*/
        }
    }

}
