using System;
using System.Collections.Generic;
using System.Text;
using LawFirmBusinessLogic.OfficePackage.HelperEnums;

namespace LawFirmBusinessLogic.OfficePackage.HelperModels
{
    public class WordTextProperties
    {
        public string Size { get; set; }
        public bool Bold { get; set; }
        public WordJustificationType JustificationType { get; set; }
    }
}
