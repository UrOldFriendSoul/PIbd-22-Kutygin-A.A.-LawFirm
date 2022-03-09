﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LawFirmContracts.BindingModels
{
    public class DocumentBindingModel
    {
        public int? Id { get; set; }
        public string DocumentName { get; set; }
        public decimal Price { get; set; }
    public Dictionary<int, (string, int)> DocumentComponents { get; set; }
    }
}
