using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using LawFirmContracts.BindingModels;
using LawFirmContracts.ViewModels;

namespace LawFirmContracts.BusinessLogicContracts
{
    public interface IDocumentLogic
    {
        List<DocumentViewModel> Read(DocumentBindingModel model);
        void CreateOrUpdate(DocumentBindingModel model);
        void Delete(DocumentBindingModel model);
    }
}
