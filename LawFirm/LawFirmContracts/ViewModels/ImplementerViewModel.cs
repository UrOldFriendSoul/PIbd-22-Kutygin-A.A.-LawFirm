using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using LawFirmContracts.Attributes;

namespace LawFirmContracts.ViewModels
{
    public class ImplementerViewModel
    {
        [Column(title: "Номер", width: 100)]
        public int Id { get; set; }

        [Column(title: "ФИО исполнителя", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string ImplementerFIO { get; set; }

        [Column(title: "Время работы", gridViewAutoSize: GridViewAutoSize.Fill)]
        public int WorkingTime { get; set; }

        [Column(title: "Время отдыха", gridViewAutoSize: GridViewAutoSize.Fill)]
        public int PauseTime { get; set; }
    }
}