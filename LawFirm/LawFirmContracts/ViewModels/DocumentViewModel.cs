using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using LawFirmContracts.Attributes;

namespace LawFirmContracts.ViewModels
{
    public class DocumentViewModel
    {
        [Column(title: "Номер", width: 100)]
        public int Id { get; set; }

        [Column(title: "Название документа", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string DocumentName { get; set; }

        [Column(title: "Цена", gridViewAutoSize: GridViewAutoSize.Fill)]
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> DocumentComponents { get; set; }
    }
}
