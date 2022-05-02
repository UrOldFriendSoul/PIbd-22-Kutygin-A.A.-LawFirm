using LawFirmBusinessLogic.OfficePackage;
using LawFirmBusinessLogic.OfficePackage.HelperModels;
using LawFirmContracts.BindingModels;
using LawFirmContracts.BusinessLogicContracts;
using LawFirmContracts.StorageContracts;
using LawFirmContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LawFirmBusinessLogic.BusinessLogics
{
    public class ReportLogic : IReportLogic
    {
        private readonly IComponentStorage _componentStorage;
        private readonly IDocumentStorage _documentStorage;
        private readonly IOrderStorage _orderStorage;
        private readonly AbstractSaveToExcel _saveToExcel;
        private readonly AbstractSaveToWord _saveToWord;
        private readonly AbstractSaveToPdf _saveToPdf;
        public ReportLogic(IDocumentStorage documentStorage, IComponentStorage componentStorage, IOrderStorage orderStorage, 
        AbstractSaveToExcel saveToExcel, AbstractSaveToWord saveToWord, AbstractSaveToPdf saveToPdf)
        {
            _documentStorage = documentStorage;
            _componentStorage = componentStorage;
            _orderStorage = orderStorage;
            _saveToExcel = saveToExcel;
            _saveToWord = saveToWord;
            _saveToPdf = saveToPdf;
        }
        public List<ReportDocumentComponentViewModel> GetDocumentComponent()
        {
            var documents = _documentStorage.GetFullList();
            var components = _componentStorage.GetFullList();
            var list = new List<ReportDocumentComponentViewModel>();
            foreach (var document in documents)
            {
                var record = new ReportDocumentComponentViewModel
                {
                    DocumentName = document.DocumentName,
                    Components = new List<Tuple<string, int>>(),
                    TotalCount = 0
                };
                foreach (var component in components)
                {
                    if (document.DocumentComponents.ContainsKey(component.Id))
                    {
                        record.Components.Add(new Tuple<string, int>(component.ComponentName, document.DocumentComponents[component.Id].Item2));
                        record.TotalCount += document.DocumentComponents[component.Id].Item2;
                    }
                }
                list.Add(record);
            }
            return list;
        }

        public List<ReportOrdersViewModel> GetOrders(ReportBindingModel model)
        {
            return _orderStorage.GetFilteredList(new OrderBindingModel
            {
                DateFrom = model.DateFrom,
                DateTo = model.DateTo
            })
            .Select(x => new ReportOrdersViewModel
            {
                DateCreate = x.DateCreate,
                DocumentName = x.DocumentName,
                Count = x.Count,
                Sum = x.Sum,
                Status = x.Status
            })
           .ToList();
        }

        public void SaveComponentsToWordFile(ReportBindingModel model)
        {
            _saveToWord.CreateDoc(new WordInfo
            {
                FileName = model.FileName,
                Title = "Список компонент",
                Documents = _documentStorage.GetFullList()
            });
        }

        public void SaveDocumentComponentToExcelFile(ReportBindingModel model)
        {
            _saveToExcel.CreateReport(new ExcelInfo
            {
                FileName = model.FileName,
                Title = "Список компонент",
                DocumentComponents = GetDocumentComponent()
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
