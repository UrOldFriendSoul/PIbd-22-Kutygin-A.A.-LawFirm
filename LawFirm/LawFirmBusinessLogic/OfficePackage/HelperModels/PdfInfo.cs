using System;
using System.Collections.Generic;
using System.Text;
using LawFirmContracts.ViewModels;

namespace LawFirmBusinessLogic.OfficePackage.HelperModels
{
    public class PdfInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public List<ReportOrdersViewModel> Orders { get; set; }
        public List<ReportOrdersGroupedByDateViewModel> OrdersGroupedByDate { get; set; }

    }
}
