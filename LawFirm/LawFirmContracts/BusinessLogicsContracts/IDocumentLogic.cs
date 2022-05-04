using System;
using System.Collections.Generic;
using System.Text;
using LawFirmContracts.BindingModels;
using LawFirmContracts.ViewModels;

namespace LawFirmContracts.BusinessLogicsContracts
{
    public interface IDocumentLogic
    {
        List<DocumentViewModel> Read(DocumentBindingModel model);
        void CreateOrUpdate(DocumentBindingModel model);
        void Delete(DocumentBindingModel model);
    }
}
