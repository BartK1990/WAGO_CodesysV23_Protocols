﻿using System.Collections.Generic;

namespace WAGO_CodesysV23_CommProtocolConfigGenerator.Model.ItemList
{
    public class ExcelSheetName
    {
        public ExcelSheetName()
        {
            SheetCollection = new List<string>();
        }

        public IList<string> SheetCollection { get; set; }
    }
}
