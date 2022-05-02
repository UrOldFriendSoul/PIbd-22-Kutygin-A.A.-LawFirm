using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawFirmContracts.ViewModels
{
    public class DocumentViewModel
    {
        public int Id { get; set; }
<<<<<<< Updated upstream
        [DisplayName("Название изделия")]
=======
        [DisplayName("Название документа")]
>>>>>>> Stashed changes
        public string DocumentName { get; set; }
        [DisplayName("Цена")]
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> DocumentComponents { get; set; }

    }
}
