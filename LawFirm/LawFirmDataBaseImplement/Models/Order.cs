using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
<<<<<<< Updated upstream
=======
using System.ComponentModel.DataAnnotations.Schema;
>>>>>>> Stashed changes
using LawFirmContracts.Enums;

namespace LawFirmDatabaseImplement.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
<<<<<<< Updated upstream
        public virtual Document document { get; set; }
=======
        public virtual Document Document { get; set; }
>>>>>>> Stashed changes
        [Required]
        public int Count { get; set; }
        [Required]
        public decimal Sum { get; set; }
        [Required]
        public OrderStatus Status { get; set; }
        [Required]
        public DateTime DateCreate { get; set; }
        public DateTime? DateImplement { get; set; }
    }
}