﻿using LawFirmContracts.BusinessLogicsContracts;
using LawFirmContracts.BindingModels;
using LawFirmContracts.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LawFirmRestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientLogic _clientLogic;
        private readonly IMessageInfoLogic _messageLogic;
        public ClientController(IClientLogic clientLogic, IMessageInfoLogic messageLogic)
        {
            _clientLogic = clientLogic;
            _messageLogic = messageLogic;
        }
        [HttpGet]
        public ClientViewModel Login(string login, string password)
        {
            var list = _clientLogic.Read(new ClientBindingModel
            {
                Email = login,
                Password = password
            });
            return (list != null && list.Count > 0) ? list[0] : null;
        }
        [HttpPost]
        public void Register(ClientBindingModel model) => _clientLogic.CreateOrUpdate(model);
        [HttpPost]
        public void UpdateData(ClientBindingModel model) => _clientLogic.CreateOrUpdate(model);
        [HttpGet]
        public List<MessageInfoViewModel> GetClientsMessagesInfo(int clientId) => _messageLogic.Read(new MessageInfoBindingModel { ClientId = clientId });
    }
}