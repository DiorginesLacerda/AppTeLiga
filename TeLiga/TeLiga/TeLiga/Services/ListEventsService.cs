using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeLiga.Models;

namespace TeLiga.Services
{
    public class ListEventsService: RestService
    {
        const string GETEVENTS_ENDPOINT = "/ApiPost/GetNovos";

        public static async Task<ObservableCollection<EventVo>> GetEvents()
        {

            var uri = new Uri(URL_BASE + GETEVENTS_ENDPOINT);
            var contentResult = await client.GetStringAsync(uri);
            var dataResult = JsonConvert.DeserializeObject <ResultGetEvents>(contentResult);
            ObservableCollection<EventVo> events = new ObservableCollection<EventVo>();
            foreach (ResultEvent item in dataResult.Lista)
            {
                events.Add(item.getEventVo());
            }

            return events;
        }

    }

    class ResultGetEvents
    {
        public string Entidade { get; set; }
        public List<ResultEvent> Lista { get; set; }
        public int Request_Status { get; set; }
        public string Message_Error { get; set; }
    }
}
