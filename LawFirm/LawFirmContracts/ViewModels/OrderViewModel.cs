using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.ComponentModel;
using LawFirmContracts.Enums;


namespace LawFirmContracts.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
<<<<<<< Updated upstream
        [DisplayName("Изделие")]
=======
        [DisplayName("Документ")]
>>>>>>> Stashed changes
        public string DocumentName { get; set; }
        [DisplayName("Количество")]
        public int Count { get; set; }
        [DisplayName("Сумма")]
        public decimal Sum { get; set; }
        [DisplayName("Статус")]
        public string Status { get; set; }
        [DisplayName("Дата создания")]
        public DateTime DateCreate { get; set; }
        [DisplayName("Дата выполнения")]
        public DateTime? DateImplement { get; set; }
    }
}
