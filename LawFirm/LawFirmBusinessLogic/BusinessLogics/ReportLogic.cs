using LawFirmBusinessLogic.OfficePackage;
using LawFirmBusinessLogic.OfficePackage.HelperModels;
using LawFirmContracts.BindingModels;
using LawFirmContracts.BusinessLogicsContracts;
using LawFirmContracts.StoragesContracts;
using LawFirmContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LawFirmBusinessLogic.BusinessLogics
{
    public class ReportLogic : IReportLogic
    {
        private readonly IComponentStorage _componentStorage;
        private readonly IWarehouseStorage _warehouseStorage;
        private readonly IDocumentStorage _documentStorage;
        private readonly IOrderStorage _orderStorage;
        private readonly AbstractSaveToExcel _saveToExcel;
        private readonly AbstractSaveToWord _saveToWord;
        private readonly AbstractSaveToPdf _saveToPdf;
        public ReportLogic(IWarehouseStorage warehouseStorage, IDocumentStorage documentStorage, IComponentStorage componentStorage, IOrderStorage orderStorage,
        AbstractSaveToExcel saveToExcel, AbstractSaveToWord saveToWord, AbstractSaveToPdf saveToPdf)
        {
            _documentStorage = documentStorage;
            _componentStorage = componentStorage;
            _orderStorage = orderStorage;
            _warehouseStorage = warehouseStorage;
            _saveToExcel = saveToExcel;
            _saveToWord = saveToWord;
            _saveToPdf = saveToPdf;
        }
        public List<ReportDocumentComponentViewModel> GetDocumentComponent()
        {
            var documents = _documentStorage.GetFullList();
            var list = new List<ReportDocumentComponentViewModel>();
            foreach (var document in documents)
            {
                var record = new ReportDocumentComponentViewModel
                {
                    DocumentName = document.DocumentName,
                    Components = new List<Tuple<string, int>>(),
                    TotalCount = 0
                };
                foreach (var component in document.DocumentComponents)
                {
                    record.Components.Add(new Tuple<string, int>(component.Value.Item1, component.Value.Item2));
                    record.TotalCount += component.Value.Item2;
                }
                list.Add(record);
            }
            return list;
        }
        public List<ReportWarehouseComponentViewModel> GetWarehouseComponent()
        {
            var warehouses = _warehouseStorage.GetFullList();
            var list = new List<ReportWarehouseComponentViewModel>();
            foreach (var warehouse in warehouses)
            {
                var record = new ReportWarehouseComponentViewModel
                {
                    WarehouseName = warehouse.WarehouseName,
                    Components = new List<Tuple<string, int>>(),
                    TotalCount = 0
                };
                foreach (var component in warehouse.WarehouseComponents)
                {
                    record.Components.Add(new Tuple<string, int>(component.Value.Item1, component.Value.Item2));
                    record.TotalCount += component.Value.Item2;
                }
                list.Add(record);
            }
            return list;
        }

        public List<ReportOrdersGroupedByDateViewModel> GetOrdersGroupedByDate()
        {
            return _orderStorage.GetFullList()
            .GroupBy(rec => rec.DateCreate.ToShortDateString())
            .Select(x => new ReportOrdersGroupedByDateViewModel
            {
                DateCreate = Convert.ToDateTime(x.Key),
                Count = x.Count(),
                Sum = x.Sum(rec => rec.Sum)
            })
           .ToList();
        }
        public List<ReportOrdersViewModel> GetOrders(ReportBindingModel model)
        {
            return _orderStorage.GetFilteredList(new OrderBindingModel
            {
                DateFrom = model.DateFrom,
                DateTo = model.DateTo
            }).Select(x => new ReportOrdersViewModel
            {
                DateCreate = x.DateCreate,
                DocumentName = x.DocumentName,
                Count = x.Count,
                Sum = x.Sum,
                Status = x.Status
            }).ToList();
        }
        public void SaveWarehousesToWordFile(ReportBindingModel model)
        {
            _saveToWord.CreateDocWarehouse(new WordInfo
            {
                FileName = model.FileName,
                Title = "Список складов",
                Warehouses = _warehouseStorage.GetFullList()
            });
        }
        public void SaveDocumentsToWordFile(ReportBindingModel model)
        {
            _saveToWord.CreateDoc(new WordInfo
            {
                FileName = model.FileName,
                Title = "Список документов", 
                Documents = _documentStorage.GetFullList()
            });
        }
        public void SaveWarehouseComponentToExcelFile(ReportBindingModel model)
        {
            _saveToExcel.CreateReportWarehouse(new ExcelInfo
            {
                FileName = model.FileName,
                Title = "Загруженность складов",
                WarehouseComponents = GetWarehouseComponent()
            });
        }
        public void SaveDocumentComponentToExcelFile(ReportBindingModel model)
        {
            _saveToExcel.CreateReport(new ExcelInfo
            {
                FileName = model.FileName,
                Title = "Список документов и содержащихся в них компонентов",
                DocumentComponents = GetDocumentComponent()
            });
        }
        public void SaveOrdersGroupedByDateToPdfFile(ReportBindingModel model)
        {
            _saveToPdf.CreateDocOrdersGroupedByDate(new PdfInfo
            {
                FileName = model.FileName,
                Title = "Список заказов, объединенных по датам",
                OrdersGroupedByDate = GetOrdersGroupedByDate()
            });
        }
        public void SaveOrdersToPdfFile(ReportBindingModel model)
        {
            _saveToPdf.CreateDoc(new PdfInfo
            {
                FileName = model.FileName,
                Title = "Список заказов",
                DateFrom = model.DateFrom.Value,
                DateTo = model.DateTo.Value,
                Orders = GetOrders(model)
            });
        }

    }
}
