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
    class NewEventService:RestService
    {
        const string NEWEVENT_ENDPOINT = "/ApiPost/Criar";

        public static async Task<EventVo> CreateNewEvent(User user, EventVo eventVo)
        {


            
            
            var json = JsonConvert.SerializeObject(new
            {
                Usuario_Id = user.UserId,
                Titulo = eventVo.Title,
                Descricao = eventVo.Description,
                Local = eventVo.Place,
                DescricaoLocal = eventVo.Adress,
                Data_Votacao = String.Format("{0:yyyy-MM-dd}", eventVo.DateEvent)
            });

            
        var body = new StringContent(json, Encoding.UTF8, "application/json");

            var uri = new Uri(URL_BASE + NEWEVENT_ENDPOINT);

            var result = await client.PostAsync(uri, body);

            if (result.IsSuccessStatusCode)
            {
                var contentResult = await result.Content.ReadAsStringAsync();
                var dataResult = JsonConvert.DeserializeObject<ResultEvent>(contentResult);
                return dataResult.getEventVo();
            }
            throw new Exception("Erro ao conectar com o servidor");
        }
    }
}
