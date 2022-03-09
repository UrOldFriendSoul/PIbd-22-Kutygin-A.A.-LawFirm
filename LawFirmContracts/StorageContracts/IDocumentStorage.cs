using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using LawFirmContracts.BindingModels;
using LawFirmContracts.ViewModels;

namespace LawFirmContracts.StorageContracts
{
    public interface IDocumentStorage
    {
        List<DocumentViewModel> GetFullList();
        List<DocumentViewModel> GetFilteredList(DocumentBindingModel model);
        DocumentViewModel GetElement(DocumentBindingModel model);
        void Insert(DocumentBindingModel model);
        void Update(DocumentBindingModel model);
        void Delete(DocumentBindingModel model);
    }
}
