using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TeLiga.Models;

namespace TeLiga.Services
{
    public class LoginService:RestService
    {
        const string POST_LOGIN_ENDPOINT = "/Login";

        public async Task <User> Login(string email, string password)
        {
            //var client = new HttpClient();
            
            var body = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string,string>("Email",email),
                new KeyValuePair<string, string>("Senha", password)
            });

            //var uri = new Uri(URL_POST_LOGIN);
            var uri = new Uri(URL_BASE + POST_LOGIN_ENDPOINT);
            
            var result = await client.PostAsync(uri, body);

            var contentResult = await result.Content.ReadAsStringAsync();

            if (!contentResult.Equals("null") )
            {
                
                var dataResult = JsonConvert.DeserializeObject<ResultLogin>(contentResult);

                var userLogin = dataResult.Entidade;

                var user = new User
                {
                    Name = userLogin.Nome,
                    UF = userLogin.Estado,
                    City = userLogin.Cidade,
                    Email = userLogin.Email,
                    Password = userLogin.Senha,
                };

                return user;
            }
            else
            {
                throw new Exception("Usuário ou senha Incorretos");
            }
        }
    }

    class ResultLogin
    {
        public UserLogin Entidade { get; set; }
        public string Lista { get; set; }
        public int Request_Status { get; set; }
        public string Message_Error { get; set; }
    }

    class UserLogin
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
    }
}
