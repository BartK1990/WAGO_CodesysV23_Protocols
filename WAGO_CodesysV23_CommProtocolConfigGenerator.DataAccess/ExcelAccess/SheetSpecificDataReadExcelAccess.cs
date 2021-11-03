using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using WAGO_CodesysV23_CommProtocolConfigGenerator.DataAccess.Exceptions;

namespace WAGO_CodesysV23_CommProtocolConfigGenerator.DataAccess.ExcelAccess
{
    public abstract class SheetSpecificDataReadExcelAccess<T,TItem> : SheetDataReadExcelAccess<T>
    {
        protected readonly Dictionary<string, string> columnsNamesToClassDict = new Dictionary<string, string>();

        protected Dictionary<int, string> _columnsNumbersToStructDict;

        protected SheetSpecificDataReadExcelAccess(string sheetName) : base(sheetName)
        {
        }

        protected void ReadSheetSpecificData(ExcelWorksheet worksheet, IList<TItem> sheetDataList)
        {
            int maxRow = worksheet.Dimension.Rows;
            int maxColumn = worksheet.Dimension.Columns;

            // Recognize column number
            _columnsNumbersToStructDict = new Dictionary<int, string>();
            for (int colNumCnt = 1; colNumCnt <= maxColumn; colNumCnt++)
            {
                var cellValue = GetCellValue(worksheet.Cells[1, colNumCnt].Value);
                if (columnsNamesToClassDict.ContainsKey(cellValue))
                {
                    _columnsNumbersToStructDict.Add(colNumCnt, columnsNamesToClassDict[cellValue]);
                }
                if (columnsNamesToClassDict.Count <= _columnsNumbersToStructDict.Count) // If all columns found stop searching
                {
                    break;
                }
            }

            if (columnsNamesToClassDict.Count > _columnsNumbersToStructDict.Count) // If not all columns found file is invalid - return empty collection
            {
                var missingColumns = columnsNamesToClassDict.Values.Except(_columnsNumbersToStructDict.Values);
                var exMessage = missingColumns.Aggregate((a, b) => $"{a}, {b}");
                throw new InvalidExcelSheetException($"There are missing columns in the worksheet: {exMessage}");
            }
            int requiredColumnNumber = RequiredColumnNumber();
            for (int rowNumCnt = 2; rowNumCnt <= maxRow; rowNumCnt++)
            {
                // If required column is empty go next row
                if (string.IsNullOrEmpty(GetCellValue(worksheet.Cells[rowNumCnt, requiredColumnNumber].Value)))
                    continue;

                TItem item = GetItem();
                foreach (int columnNum in _columnsNumbersToStructDict.Keys)
                {
                    string str = GetCellValue(worksheet.Cells[rowNumCnt, columnNum].Value);
                    if (!string.IsNullOrEmpty(str))
                    {
                        // Reflection - allows inner classes - supports string and boolean as destination type
                        // ToDo add helper class or method for setting property in object
                        var property = _columnsNumbersToStructDict[columnNum];
                        var properties = property.Split('.');
                        if (properties.Length == 1)
                        {
                            PropertyInfo rowPI = typeof(TItem).GetProperty(property);
                            if (rowPI == null)
                            {
                                throw new InvalidExcelSheetException($"Wrong property name: {property}");
                            }
                            rowPI.SetValue(item, str);
                        }
                        else
                        {
                            object obj = item;
                            for (int i = 0; i < properties.Length; i++)
                            {
                                Type type = obj.GetType();
                                PropertyInfo rowPI = type.GetProperty(properties[i]);
                                if (rowPI == null)
                                {
                                    throw new InvalidExcelSheetException($"Wrong property name: {property}");
                                }
                                if(i < (properties.Length - 1))
                                {
                                    obj = rowPI.GetValue(obj);
                                }
                                else
                                {
                                    // ToDo add helper class or method for boolean handling
                                    if(rowPI.PropertyType.Name == "Boolean")
                                    {
                                        rowPI.SetValue(obj, Convert.ToBoolean(Convert.ToInt16(str)));
                                    }
                                    else
                                    {
                                        rowPI.SetValue(obj, str);
                                    }
                                }
                            }
                        }
                    }
                }
                sheetDataList.Add(item);
            }
            if (sheetDataList?.Any() == false)
            {
                throw new InvalidExcelSheetException("Worksheet does not contain any data");
            }
        }

        protected abstract int RequiredColumnNumber();

        protected abstract TItem GetItem();

    }
}
