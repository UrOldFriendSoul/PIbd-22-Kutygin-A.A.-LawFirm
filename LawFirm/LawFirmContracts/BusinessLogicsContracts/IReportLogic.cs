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
        List<ReportWarehouseComponentViewModel> GetWarehouseComponent();
        List<ReportOrdersGroupedByDateViewModel> GetOrdersGroupedByDate();
        void SaveDocumentsToWordFile(ReportBindingModel model);
        void SaveWarehousesToWordFile(ReportBindingModel model);

        void SaveDocumentComponentToExcelFile(ReportBindingModel model);
        void SaveWarehouseComponentToExcelFile(ReportBindingModel model);

        void SaveOrdersToPdfFile(ReportBindingModel model);
        void SaveOrdersGroupedByDateToPdfFile(ReportBindingModel model);

    }
}
