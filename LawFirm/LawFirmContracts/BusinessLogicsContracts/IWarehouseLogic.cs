using System;
using System.Collections.Generic;
using System.Text;
using LawFirmContracts.BindingModels;
using LawFirmContracts.ViewModels;

namespace LawFirmContracts.BusinessLogicsContracts
{
    public interface IWarehouseLogic
    {
        List<WarehouseViewModel> Read(WarehouseBindingModel model);
        void CreateOrUpdate(WarehouseBindingModel model);
        void Delete(WarehouseBindingModel model);
        void AddComponent(WarehouseBindingModel model, int componentId, int amount);
    }
}