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
    public class NewAccountService : RestService
    {
        const string NEWACCOUNT_ENDPOINT = "/ApiUsuario/Criar";
        

        public static async Task<User> CreateNewAccount( User user)
        {
            var body = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string,string>("Nome",user.Name),
                new KeyValuePair<string,string>("Estado",user.UF),
                new KeyValuePair<string,string>("Cidade",user.City),
                new KeyValuePair<string,string>("Email",user.Email),
                new KeyValuePair<string,string>("Senha",user.Password)
            });
            var uri = new Uri(URL_BASE+NEWACCOUNT_ENDPOINT);

            var result = await client.PostAsync(uri, body);
            

            if (result.IsSuccessStatusCode)
            {
                var contentResult = await result.Content.ReadAsStringAsync();
                var dataResult = JsonConvert.DeserializeObject<UserLogin>(contentResult);
                return dataResult.getUser();
            }
            throw new Exception("Erro ao conectar com o servidor");
        }

    }
}
