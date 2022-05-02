using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawFirmContracts.ViewModels
{
    public class ReportDocumentComponentViewModel
    {
        public string DocumentName { get; set; }
        public int TotalCount { get; set; }
        public List<Tuple<string, int>> Components { get; set; }

    }
}
