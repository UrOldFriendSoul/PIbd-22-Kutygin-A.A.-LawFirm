using System;
using System.Collections.Generic;
using System.Text;
using LawFirmBusinessLogic.OfficePackage.HelperEnums;

namespace LawFirmBusinessLogic.OfficePackage.HelperModels
{
    public class ExcelCellParameters
    {
        public string ColumnName { get; set; }
        public uint RowIndex { get; set; }
        public string Text { get; set; }
        public string CellReference => $"{ColumnName}{RowIndex}";
        public ExcelStyleInfoType StyleInfo { get; set; }
    }
}
