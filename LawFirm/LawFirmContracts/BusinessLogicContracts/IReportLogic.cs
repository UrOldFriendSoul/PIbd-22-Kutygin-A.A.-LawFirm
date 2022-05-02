using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawFirmContracts.BindingModels;
using LawFirmContracts.ViewModels;


namespace LawFirmContracts.BusinessLogicContracts
{
    public interface IReportLogic
    {
        List<ReportDocumentComponentViewModel> GetDocumentComponent();

        List<ReportOrdersViewModel> GetOrders(ReportBindingModel model);

        void SaveComponentsToWordFile(ReportBindingModel model);

        void SaveDocumentComponentToExcelFile(ReportBindingModel model);
 
        void SaveOrdersToPdfFile(ReportBindingModel model);
    }
}
