using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawFirmContracts.Attributes;

namespace LawFirmContracts.ViewModels
{
    // Сообщения, приходящие на почту
    public class MessageInfoViewModel
    {
        [Column(title: "Номер", width: 100)]
        public string MessageId { get; set; }

        [Column(title: "Отправитель", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string SenderName { get; set; }

        [Column(title: "Дата письма", gridViewAutoSize: GridViewAutoSize.Fill)]
        public DateTime DateDelivery { get; set; }

        [Column(title: "Заголовок", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string Subject { get; set; }

        [DisplayName("Текст")]
        public string Body { get; set; }
    }
}