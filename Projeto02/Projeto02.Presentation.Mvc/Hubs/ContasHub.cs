using Microsoft.AspNetCore.SignalR;
using Projeto02.Application.Interfaces;
using Projeto02.Application.Models.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto02.Presentation.Mvc.Hubs
{
    //Hub do SignalR
    public class ContasHub : Hub
    {
        private readonly IContaApplicationService _contaApplicationService;

        public ContasHub(IContaApplicationService contaApplicationService)
        {
            _contaApplicationService = contaApplicationService;
        }

        //método para que a página de cadastro possa
        //envia uma notificação para o Hub contendo
        //os dados de uma conta
        public async Task SendMessage(AddContasModel model)
        {
            //cadastrar a conta
            _contaApplicationService.Add(model);

            //consultar as contas agrupadas por categoria
            var result = _contaApplicationService.GroupByCategoria();

            //criando uma rotina para as páginas que irão 'ouvir'
            //os eventos (mensagens / notificações) que chegam no hub
            await Clients.All.SendAsync("ReceiveMessage", new { model, result });
        }
    }
}
