using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeLiga.Models;
using TeLiga.Services;
using Xamarin.Forms;

namespace TeLiga.ViewModels
{
    public class EventListViewModel: BaseViewModel
    {
        public User User { get; private set; }
        public ObservableCollection<EventVo> Events;

        private EventVo selectedItem;

        public EventVo SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged();
                if(value!=null)
                    MessagingCenter.Send<EventVo>(selectedItem, "SelectedEvent");
            }
        }

        public async Task GetListEvents()
        {
            Events = await ListEventsService.GetEvents(User);
        }

        public EventListViewModel(User user)
        {
            ListEventsService service = new ListEventsService();
            this.User = user;

            
        }
    }
}

/*this.Events = new ObservableCollection<EventVo>
            {
                new EventVo
                {
                    Title = " Evento XPTO",
                    DateEvent = new DateTime(2009, 8, 1, 0, 0, 0),
                    Description = "Caros amigos, a execução dos pontos do programa" +
                    " prepara-nos para enfrentar situações atípicas decorrentes das " +
                    "condições financeiras e administrativas exigidas. ",
                    Link = "www.google.com",
                    Place = "Câmara de Vereadores",
                    Adress = "Rua dos bobos, 0",
                    City = "TownsVile",
                    Alert = false
                },
                new EventVo
                {
                    Title = " Evento XPTO",
                    DateEvent = new DateTime(2009, 8, 1, 0, 0, 0),
                    Description = "Caros amigos, a execução dos pontos do programa" +
                    " prepara-nos para enfrentar situações atípicas decorrentes das " +
                    "condições financeiras e administrativas exigidas. ",
                    Link = "www.google.com",
                    Place = "Câmara de Vereadores",
                    Adress = "Rua dos bobos, 0",
                    City = "TownsVile",
                    Alert = false
                },
                new EventVo
                {
                    Title = " Evento XPTO",
                    DateEvent = new DateTime(2009, 8, 1, 0, 0, 0),
                    Description = "Caros amigos, a execução dos pontos do programa" +
                    " prepara-nos para enfrentar situações atípicas decorrentes das " +
                    "condições financeiras e administrativas exigidas. ",
                    Link = "www.google.com",
                    Place = "Câmara de Vereadores",
                    Adress = "Rua dos bobos, 0",
                    City = "TownsVile",
                    Alert = false
                },
                new EventVo
                {
                    Title = " Evento XPTO",
                    DateEvent = new DateTime(2009, 8, 1, 0, 0, 0),
                    Description = "Caros amigos, a execução dos pontos do programa" +
                    " prepara-nos para enfrentar situações atípicas decorrentes das " +
                    "condições financeiras e administrativas exigidas. ",
                    Link = "www.google.com",
                    Place = "Câmara de Vereadores",
                    Adress = "Rua dos bobos, 0",
                    City = "TownsVile",
                    Alert = false
                },
                new EventVo
                {
                    Title = " Evento XPTO",
                    DateEvent = new DateTime(2009, 8, 1, 0, 0, 0),
                    Description = "Caros amigos, a execução dos pontos do programa" +
                    " prepara-nos para enfrentar situações atípicas decorrentes das " +
                    "condições financeiras e administrativas exigidas. ",
                    Link = "www.google.com",
                    Place = "Câmara de Vereadores",
                    Adress = "Rua dos bobos, 0",
                    City = "TownsVile",
                    Alert = false
                },
                new EventVo
                {
                    Title = " Evento XPTO",
                    DateEvent = new DateTime(2009, 8, 1, 0, 0, 0),
                    Description = "Caros amigos, a execução dos pontos do programa" +
                    " prepara-nos para enfrentar situações atípicas decorrentes das " +
                    "condições financeiras e administrativas exigidas. ",
                    Link = "www.google.com",
                    Place = "Câmara de Vereadores",
                    Adress = "Rua dos bobos, 0",
                    City = "TownsVile",
                    Alert = false
                },
                new EventVo
                {
                    Title = " Evento XPTO",
                    DateEvent = new DateTime(2009, 8, 1, 0, 0, 0),
                    Description = "Caros amigos, a execução dos pontos do programa" +
                    " prepara-nos para enfrentar situações atípicas decorrentes das " +
                    "condições financeiras e administrativas exigidas. ",
                    Link = "www.google.com",
                    Place = "Câmara de Vereadores",
                    Adress = "Rua dos bobos, 0",
                    City = "TownsVile",
                    Alert = false
                },
                new EventVo
                {
                    Title = " Evento XPTO",
                    DateEvent = new DateTime(2009, 8, 1, 0, 0, 0),
                    Description = "Caros amigos, a execução dos pontos do programa" +
                    " prepara-nos para enfrentar situações atípicas decorrentes das " +
                    "condições financeiras e administrativas exigidas. ",
                    Link = "www.google.com",
                    Place = "Câmara de Vereadores",
                    Adress = "Rua dos bobos, 0",
                    City = "TownsVile",
                    Alert = false
                },
                new EventVo
                {
                    Title = " Evento XPTO",
                    DateEvent = new DateTime(2009, 8, 1, 0, 0, 0),
                    Description = "Caros amigos, a execução dos pontos do programa" +
                    " prepara-nos para enfrentar situações atípicas decorrentes das " +
                    "condições financeiras e administrativas exigidas. ",
                    Link = "www.google.com",
                    Place = "Câmara de Vereadores",
                    Adress = "Rua dos bobos, 0",
                    City = "TownsVile",
                    Alert = false
                },
                new EventVo
                {
                    Title = " Evento XPTO",
                    DateEvent = new DateTime(2009, 8, 1, 0, 0, 0),
                    Description = "Caros amigos, a execução dos pontos do programa" +
                    " prepara-nos para enfrentar situações atípicas decorrentes das " +
                    "condições financeiras e administrativas exigidas. ",
                    Link = "www.google.com",
                    Place = "Câmara de Vereadores",
                    Adress = "Rua dos bobos, 0",
                    City = "TownsVile",
                    Alert = false
                },
                new EventVo
                {
                    Title = " Evento XPTO",
                    DateEvent = new DateTime(2009, 8, 1, 0, 0, 0),
                    Description = "Caros amigos, a execução dos pontos do programa" +
                    " prepara-nos para enfrentar situações atípicas decorrentes das " +
                    "condições financeiras e administrativas exigidas. ",
                    Link = "www.google.com",
                    Place = "Câmara de Vereadores",
                    Adress = "Rua dos bobos, 0",
                    City = "TownsVile",
                    Alert = false
                },
                new EventVo
                {
                    Title = " Evento XPTO",
                    DateEvent = new DateTime(2009, 8, 1, 0, 0, 0),
                    Description = "Caros amigos, a execução dos pontos do programa" +
                    " prepara-nos para enfrentar situações atípicas decorrentes das " +
                    "condições financeiras e administrativas exigidas. ",
                    Link = "www.google.com",
                    Place = "Câmara de Vereadores",
                    Adress = "Rua dos bobos, 0",
                    City = "TownsVile",
                    Alert = false
                },
                new EventVo
                {
                    Title = " Evento XPTO",
                    DateEvent = new DateTime(2009, 8, 1, 0, 0, 0),
                    Description = "Caros amigos, a execução dos pontos do programa" +
                    " prepara-nos para enfrentar situações atípicas decorrentes das " +
                    "condições financeiras e administrativas exigidas. ",
                    Link = "www.google.com",
                    Place = "Câmara de Vereadores",
                    Adress = "Rua dos bobos, 0",
                    City = "TownsVile",
                    Alert = false
                },
                new EventVo
                {
                    Title = " Evento XPTO",
                    DateEvent = new DateTime(2009, 8, 1, 0, 0, 0),
                    Description = "Caros amigos, a execução dos pontos do programa" +
                    " prepara-nos para enfrentar situações atípicas decorrentes das " +
                    "condições financeiras e administrativas exigidas. ",
                    Link = "www.google.com",
                    Place = "Câmara de Vereadores",
                    Adress = "Rua dos bobos, 0",
                    City = "TownsVile",
                    Alert = false
                },
                new EventVo
                {
                    Title = " Evento XPTO",
                    DateEvent = new DateTime(2009, 8, 1, 0, 0, 0),
                    Description = "Caros amigos, a execução dos pontos do programa" +
                    " prepara-nos para enfrentar situações atípicas decorrentes das " +
                    "condições financeiras e administrativas exigidas. ",
                    Link = "www.google.com",
                    Place = "Câmara de Vereadores",
                    Adress = "Rua dos bobos, 0",
                    City = "TownsVile",
                    Alert = false
                },
                new EventVo
                {
                    Title = " Evento XPTO",
                    DateEvent = new DateTime(2009, 8, 1, 0, 0, 0),
                    Description = "Caros amigos, a execução dos pontos do programa" +
                    " prepara-nos para enfrentar situações atípicas decorrentes das " +
                    "condições financeiras e administrativas exigidas. ",
                    Link = "www.google.com",
                    Place = "Câmara de Vereadores",
                    Adress = "Rua dos bobos, 0",
                    City = "TownsVile",
                    Alert = false
                },
                new EventVo
                {
                    Title = " Evento XPTO",
                    DateEvent = new DateTime(2009, 8, 1, 0, 0, 0),
                    Description = "Caros amigos, a execução dos pontos do programa" +
                    " prepara-nos para enfrentar situações atípicas decorrentes das " +
                    "condições financeiras e administrativas exigidas. ",
                    Link = "www.google.com",
                    Place = "Câmara de Vereadores",
                    Adress = "Rua dos bobos, 0",
                    City = "TownsVile",
                    Alert = false
                },
                new EventVo
                {
                    Title = " Evento XPTO",
                    DateEvent = new DateTime(2009, 8, 1, 0, 0, 0),
                    Description = "Caros amigos, a execução dos pontos do programa" +
                    " prepara-nos para enfrentar situações atípicas decorrentes das " +
                    "condições financeiras e administrativas exigidas. ",
                    Link = "www.google.com",
                    Place = "Câmara de Vereadores",
                    Adress = "Rua dos bobos, 0",
                    City = "TownsVile",
                    Alert = false
                },
                new EventVo
                {
                    Title = " Evento XPTO",
                    DateEvent = new DateTime(2009, 8, 1, 0, 0, 0),
                    Description = "Caros amigos, a execução dos pontos do programa" +
                    " prepara-nos para enfrentar situações atípicas decorrentes das " +
                    "condições financeiras e administrativas exigidas. ",
                    Link = "www.google.com",
                    Place = "Câmara de Vereadores",
                    Adress = "Rua dos bobos, 0",
                    City = "TownsVile",
                    Alert = false
                },
                new EventVo
                {
                    Title = " Evento XPTO",
                    DateEvent = new DateTime(2009, 8, 1, 0, 0, 0),
                    Description = "Caros amigos, a execução dos pontos do programa" +
                    " prepara-nos para enfrentar situações atípicas decorrentes das " +
                    "condições financeiras e administrativas exigidas. ",
                    Link = "www.google.com",
                    Place = "Câmara de Vereadores",
                    Adress = "Rua dos bobos, 0",
                    City = "TownsVile",
                    Alert = false
                }
            };*/
