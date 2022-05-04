using System;
using System.Collections.Generic;
using System.Text;
using LawFirmContracts.BindingModels;
using LawFirmContracts.ViewModels;

namespace LawFirmContracts.BusinessLogicsContracts
{
    public interface IReportLogic
    {
        List<ReportDocumentComponentViewModel> GetDocumentComponent();
        List<ReportOrdersViewModel> GetOrders(ReportBindingModel model);
        void SaveDocumentsToWordFile(ReportBindingModel model);
        void SaveDocumentComponentToExcelFile(ReportBindingModel model);
        void SaveOrdersToPdfFile(ReportBindingModel model);
    }
}
