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
        public string UF { get; set; }
        public bool Alert { get; set; }
    }

    public class ResultEvent
    {
        public int Post_Id { get; set; }
        public int Usuario_Id { get; set; }
        public string Guid { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Local { get; set; }
        public string Data_Votacao { get; set; }
        public string Data_Criacao { get; set; }
        public string Data_Alteracao { get; set; }
        public string Post_Semelhante_Repetido { get; set; }
        public string Link { get; set; }
        public string Status_Post { get; set; }
        public string Observacao_Moderador { get; set; }
        public string Endereco { get; set; }
        public string UF { get; set; }
        public string  Cidade { get; set; }

        public EventVo getEventVo()
        {
            return new EventVo
            {
                Title = Titulo,
                DateEvent = Convert.ToDateTime(Data_Votacao),
                Description = Descricao,
                Link = Link,
                Place = Local,
                Adress = Endereco,
                City = Cidade,
                UF = UF
            };

        }
    }
}
