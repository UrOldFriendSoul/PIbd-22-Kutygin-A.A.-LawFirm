using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LawFirmDatabaseImplement.Models
{
    public class Component
    {
        public int Id { get; set; }
        [Required] //it is required to fill in component name
        public string ComponentName { get; set; }
        [ForeignKey("ComponentId")]
        public virtual List<DocumentComponent> DocumentComponents { get; set; }
    }
}
