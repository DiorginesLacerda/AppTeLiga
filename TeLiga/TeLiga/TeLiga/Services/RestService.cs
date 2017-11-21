using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TeLiga.Services
{
    public  abstract class RestService
    {
        protected const string URL_BASE = "http://teligaoservatoriosocial-com-br.umbler.net/api/ApiUsuario";

        protected static HttpClient client = new HttpClient();
    }
}
