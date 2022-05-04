using System;
using System.Collections.Generic;
using System.Text;
using LawFirmContracts.BusinessLogicsContracts;

namespace LawFirmContracts.BusinessLogicsContracts
{
    public interface IWorkProcess
    {
        void DoWork(IImplementerLogic implementerLogic, IOrderLogic orderLogic);
    }
}