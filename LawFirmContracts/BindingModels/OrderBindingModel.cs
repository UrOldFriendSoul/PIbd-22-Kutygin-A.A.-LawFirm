﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawFirmContracts.Enums;
using System;


namespace LawFirmContracts.BindingModels
{
    public class OrderBindingModel
    {
        public int? Id { get; set; }
        public int DocumentId { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? DateImplement { get; set; }

    }
}
