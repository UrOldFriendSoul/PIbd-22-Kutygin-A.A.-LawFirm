using System;
using System.Collections.Generic;
using System.Text;

namespace LawFirmContracts.ViewModels
{
    public class ReportDocumentComponentViewModel
    {
        public string DocumentName { get; set; }
        public int TotalCount { get; set; }
        public List<Tuple<string, int>> Components { get; set; }
    }
}
