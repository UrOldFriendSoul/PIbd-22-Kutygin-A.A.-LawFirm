using System;
using System.Collections.Generic;
using LawFirmContracts.BindingModels;

namespace LawFirmContracts.BusinessLogicsContracts
{
    public interface IBackUpLogic
    {
        void CreateBackUp(BackUpSaveBinidngModel model);
    }
}
