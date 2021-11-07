using NUnit.Framework;
using OfficeOpenXml;
using System;
using System.Linq;
using WAGO_CodesysV23_Protocols.DataAccess.ExcelAccess.Iec608705;
using WAGO_CodesysV23_Protocols.DataAccess.Exceptions;
using WAGO_CodesysV23_Protocols.Model;
using WAGO_CodesysV23_Protocols.Model.Iec608705ObjType.Type;
using WAGO_CodesysV23_Protocols.Model.Item;
using WAGO_CodesysV23_Protocols.Model.ItemList;

namespace WAGO_CodesysV23_Protocols.Tests.DataAccess
{
    public class Iec608705ObjectsReadExcelAccessTests
    {
        private Iec608705ObjectsReadExcelAccess _iec608705ObjectsReadExcelAccess;

        [SetUp]
        public void Setup()
        {
            _iec608705ObjectsReadExcelAccess = new Iec608705ObjectsReadExcelAccess();
        }

        [Test]
        public void ReadExcelDataTest_ValidSheet1Item_1Item()
        {
            Iec608705AllObjectAttributesList iec608705AllObjectAttributesListResult;
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet ws = package.Workbook.Worksheets.Add(Iec608705104ExcelWorkbookValidation.ObjectsSheetName);

                // Headers
                ws.Cells[1, 1].Value = "Connection";
                ws.Cells[1, 2].Value = "Object";
                ws.Cells[1, 3].Value = "Comment";
                ws.Cells[1, 4].Value = "Address";
                ws.Cells[1, 5].Value = "IEE754/SPI/SCS";
                ws.Cells[1, 6].Value = "AD_IEE754/SPI/SCS";
                ws.Cells[1, 7].Value = "CP56Time";
                ws.Cells[1, 8].Value = "AD_CP56Time";
                ws.Cells[1, 9].Value = "Execute";
                ws.Cells[1, 10].Value = "AD_Execute";
                ws.Cells[1, 11].Value = "OV";
                ws.Cells[1, 12].Value = "AD_OV";
                ws.Cells[1, 13].Value = "BL";
                ws.Cells[1, 14].Value = "AD_BL";
                ws.Cells[1, 15].Value = "SB";
                ws.Cells[1, 16].Value = "AD_SB";
                ws.Cells[1, 17].Value = "NT";
                ws.Cells[1, 18].Value = "AD_NT";
                ws.Cells[1, 19].Value = "IV";
                ws.Cells[1, 20].Value = "AD_IV";

                // row 1
                ws.Cells[2, 1].Value = "Client104-001_ClientConnection104-001";
                ws.Cells[2, 2].Value = "13M_ME_NC";
                ws.Cells[2, 3].Value = "Vestas_CapBank1_NotControllable Comment";
                ws.Cells[2, 4].Value = "15974";
                ws.Cells[2, 5].Value = "Vestas_CapBank1_NotControllable";
                ws.Cells[2, 6].Value = "0";
                ws.Cells[2, 7].Value = "";
                ws.Cells[2, 8].Value = "";
                ws.Cells[2, 9].Value = "Vestas_CapBank1_NotControllable_Exec";
                ws.Cells[2, 10].Value = "1";
                ws.Cells[2, 11].Value = "";
                ws.Cells[2, 12].Value = "1";
                ws.Cells[2, 13].Value = "";
                ws.Cells[2, 14].Value = "1";
                ws.Cells[2, 15].Value = "";
                ws.Cells[2, 16].Value = "1";
                ws.Cells[2, 17].Value = "";
                ws.Cells[2, 18].Value = "1";
                ws.Cells[2, 19].Value = "";
                ws.Cells[2, 20].Value = "1";

                iec608705AllObjectAttributesListResult = _iec608705ObjectsReadExcelAccess.ReadExcelData(package);
            }

            Iec608705AllObjectAttributesList iec608705AllObjectAttributesListExpected = new Iec608705AllObjectAttributesList();
            iec608705AllObjectAttributesListExpected.SourceDataList.Add(
                new Iec608705AllObjectAttributes()
                {
                    ConnectionName = "Client104-001_ClientConnection104-001",
                    ObjectType = "13M_ME_NC",
                    Comment = "Vestas_CapBank1_NotControllable Comment",
                    Address= "15974",
                    MainVariable = new Iec608705TypeChannel() { Assignment= "Vestas_CapBank1_NotControllable", Autoapply = false },
                    CP56Time = new Iec608705TypeChannel() { Autoapply = true },
                    Execute = new Iec608705TypeChannel() { Assignment= "Vestas_CapBank1_NotControllable_Exec", Autoapply = true },
                    OV = new Iec608705TypeChannel() { Autoapply = true },
                    BL = new Iec608705TypeChannel() { Autoapply = true },
                    SB = new Iec608705TypeChannel() { Autoapply = true },
                    NT = new Iec608705TypeChannel() { Autoapply = true },
                    IV = new Iec608705TypeChannel() { Autoapply = true },
                });
            Assert.IsTrue(iec608705AllObjectAttributesListExpected.SourceDataList.SequenceEqual(iec608705AllObjectAttributesListResult.SourceDataList));
        }
        [Test]
        public void ReadExcelDataTest_InvalidPath_Exception()
        {
            Assert.Throws(typeof(InvalidExcelSheetException)
                , () => { _iec608705ObjectsReadExcelAccess.ReadExcelData("<Invalid path string>"); }
                );
        }
    }
}
