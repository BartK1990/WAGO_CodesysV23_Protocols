﻿using OfficeOpenXml;
using System.Linq;
using WAGO_CodesysV23_CommProtocolConfigGenerator.Model;
using WAGO_CodesysV23_CommProtocolConfigGenerator.Model.Item;
using WAGO_CodesysV23_CommProtocolConfigGenerator.Model.ItemList;

namespace WAGO_CodesysV23_CommProtocolConfigGenerator.DataAccess.ExcelAccess
{
    public class ProtocolConfigurationObjectsReadExcelAccess : SheetSpecificDataReadExcelAccess<Iec608705104AllObjectAttributesList, Iec608705104AllObjectAttributes>
    {
        public ProtocolConfigurationObjectsReadExcelAccess() : base(Iec608705104ExcelWorkbookValidation.ObjectsSheetName)
        {
            //SheetName = MappingSetGenerator.SourceItemDictionarySheetName; // Sheet name used in base class in GetExcelData

            // Excel sheet columns to read
            columnsNamesToClassDict.Add("Comment", "Comment");
            columnsNamesToClassDict.Add("Address", "Tagname");
            columnsNamesToClassDict.Add("IEE754/SPI/SCS", "MainVariable.Assignment");
            columnsNamesToClassDict.Add("AD_IEE754/SPI/SCS", "MainVariable.Autoapply");
            columnsNamesToClassDict.Add("CP56Time", "CP56Time.Assignment");
            columnsNamesToClassDict.Add("AD_CP56Time", "CP56Time.Autoapply");
            columnsNamesToClassDict.Add("Execute", "Execute.Assignment");
            columnsNamesToClassDict.Add("AD_Execute", "Execute.Autoapply");
            columnsNamesToClassDict.Add("OV", "OV.Assignment");
            columnsNamesToClassDict.Add("AD_OV", "OV.Autoapply");
            columnsNamesToClassDict.Add("BL", "BL.Assignment");
            columnsNamesToClassDict.Add("AD_BL", "BL.Autoapply");
            columnsNamesToClassDict.Add("SB", "SB.Assignment");
            columnsNamesToClassDict.Add("AD_SB", "SB.Autoapply");
            columnsNamesToClassDict.Add("NT", "NT.Assignment");
            columnsNamesToClassDict.Add("AD_NT", "NT.Autoapply");
            columnsNamesToClassDict.Add("IV", "IV.Assignment");
            columnsNamesToClassDict.Add("AD_IV", "IV.Autoapply");

        }

        protected override Iec608705104AllObjectAttributesList ReadSheetData(ExcelWorksheet worksheet)
        {
            var iec608705104AllObjectAttributesList = new Iec608705104AllObjectAttributesList();
            var sheetDataList = iec608705104AllObjectAttributesList.SourceDataList;

            ReadSheetSpecificData(worksheet, sheetDataList);
            return iec608705104AllObjectAttributesList;
        }

        protected override Iec608705104AllObjectAttributes GetItem()
        {
            return new Iec608705104AllObjectAttributes();
        }

        protected override int RequiredColumnNumber()
        {
            return _columnsNumbersToStructDict.FirstOrDefault(v => v.Value == "Object").Key;
        }
    }
}
