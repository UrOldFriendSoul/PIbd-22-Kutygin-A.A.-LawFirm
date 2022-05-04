using LawFirmContracts.BusinessLogicsContracts;
using LawFirmContracts.BindingModels;
using LawFirmContracts.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace LawFirmRestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IOrderLogic _order;
        private readonly IDocumentLogic _document;
        public MainController(IOrderLogic order, IDocumentLogic document)
        {
            _order = order;
            _document = document;
        }
        [HttpGet]
        public List<DocumentViewModel> GetDocumentList() => _document.Read(null)?.ToList();
        [HttpGet]
        public DocumentViewModel GetDocument(int documentId) => _document.Read(new DocumentBindingModel { Id = documentId })?[0];
        [HttpGet]
        public List<OrderViewModel> GetOrders(int clientId) => _order.Read(new OrderBindingModel { ClientId = clientId });
        [HttpPost]
        public void CreateOrder(CreateOrderBindingModel model) => _order.CreateOrder(model);
    }

}