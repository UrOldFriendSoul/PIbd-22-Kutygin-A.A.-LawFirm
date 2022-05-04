using System;
using System.Collections.Generic;
using System.Text;
using LawFirmBusinessLogic.OfficePackage.HelperEnums;

namespace LawFirmBusinessLogic.OfficePackage.HelperModels
{
    public class PdfRowParameters
    {
        public List<string> Texts { get; set; }
        public string Style { get; set; }
        public PdfParagraphAlignmentType ParagraphAlignment { get; set; }
    }
}
