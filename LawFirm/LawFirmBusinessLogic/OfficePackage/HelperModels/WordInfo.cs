using System;
using System.Collections.Generic;
using System.Text;
using LawFirmContracts.ViewModels;

namespace LawFirmBusinessLogic.OfficePackage.HelperModels
{
    public class WordInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<DocumentViewModel> Documents { get; set; }
        public List<WarehouseViewModel> Warehouses { get; set; }

    }
}
