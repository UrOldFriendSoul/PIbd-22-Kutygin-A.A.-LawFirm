using System;
using System.Collections.Generic;
using System.Text;

namespace LawFirmContracts.BindingModels
{
    public class CreateOrderBindingModel
    {
        public int DocumentId { get; set; }
        public int ClientId { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }

    }
}
