﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LawFirmContracts.ViewModels
{
    public class ReportOrdersViewModel
    {   
        public DateTime DateCreate { get; set; }
        public string DocumentName { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }
        public string Status { get; set; }
    }
}
