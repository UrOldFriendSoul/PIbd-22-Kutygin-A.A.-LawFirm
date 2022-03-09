using LawFirmContracts.BindingModels;
using LawFirmContracts.StorageContracts;
using LawFirmContracts.ViewModels;
using LawFirmContracts.BusinessLogicContracts;
using System.Text;

namespace LawFirmBusinessLogic.BusinessLogics
{
    public class DocumentLogic : IDocumentLogic
    {
        private readonly IDocumentStorage _documentStorage;

        public DocumentLogic(IDocumentStorage furnitureStorage)
        {
            _documentStorage = furnitureStorage;
        }

        public List<DocumentViewModel> Read(DocumentBindingModel model)
        {
            if (model == null)
            {
                return _documentStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<DocumentViewModel>
                {
                    _documentStorage.GetElement(model)
                };
            }
            return _documentStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(DocumentBindingModel model)
        {
            var element = _documentStorage.GetElement(new DocumentBindingModel
            {
                DocumentName = model.DocumentName
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть документ с таким названием");
            }
            if (model.Id.HasValue)
            {
                _documentStorage.Update(model);
            }
            else
            {
                _documentStorage.Insert(model);
            }
        }

        public void Delete(DocumentBindingModel model)
        {
            var element = _documentStorage.GetElement(new DocumentBindingModel
            {
                Id = model.Id
            });

            if (element == null)
            {
                throw new Exception("Документы не найдены");
            }

            _documentStorage.Delete(model);
        }
    }
}
