using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TeLiga.Models;

namespace TeLiga.Services
{
    public class ListEventsService: RestService
    {
        const string GETEVENTS_ENDPOINT = "/ApiPost/GetPosts";

        public static async Task<ObservableCollection<EventVo>> GetEvents(User user)
        {
            var json = JsonConvert.SerializeObject(new
            {
                UsuarioLogadoId = user.UserId,
                Status_Post = "NOVO" // Deve Ser mudado para APROVADO
            });
            var body = new StringContent(json, Encoding.UTF8, "application/json");

            var uri = new Uri(URL_BASE + GETEVENTS_ENDPOINT);
            var result = await client.PostAsync(uri, body);
            var contentResult = await result.Content.ReadAsStringAsync();

            
            
            //Gambiarra para tratar strings nulas
            string getNewString(String s)
            {
                var posicao = s.IndexOf("null");
                while (posicao>=0)
                {
                    var antes = s.Substring(0, posicao);
                    int corte = posicao + 4;
                    var depois = s.Substring(corte);
                    var teste = '\u0022';
                    s = antes + teste + teste + depois;
                    posicao = s.IndexOf("null");
                }
                return s;  
            }


            
            var dataResult = JsonConvert.DeserializeObject <ResultGetEvents>(getNewString(contentResult));
            ObservableCollection<EventVo> events = new ObservableCollection<EventVo>();
            foreach (ResultEvent item in dataResult.Posts)
            {
                events.Add(item.getEventVo());
            }

            return events;
        }

    }

    class ResultGetEvents
    {
        
        public List<ResultEvent> Posts { get; set; }
        public bool Resultado { get; set; }
        public string Mensagem { get; set; }
    }
}
