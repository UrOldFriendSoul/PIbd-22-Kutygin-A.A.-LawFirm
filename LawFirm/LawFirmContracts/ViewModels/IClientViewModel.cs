using System;
using System.Collections.Generic;
using System.Text;
using LawFirmContracts.Attributes;
using System.ComponentModel;

namespace LawFirmContracts.ViewModels
{
    public class ClientViewModel
    {
        [Column(title: "Номер", width:100)]
        public int Id { get; set; }

        [Column(title: "Клиент", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string ClientFIO { get; set; }

        [Column(title: "Логин", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string Email { get; set; }

        [Column(title: "Пароль", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string Password { get; set; }
    }
}