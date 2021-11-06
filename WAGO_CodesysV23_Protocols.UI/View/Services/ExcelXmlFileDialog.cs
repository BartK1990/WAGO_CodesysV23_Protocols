using Microsoft.Win32;

namespace WAGO_CodesysV23_Protocols.UI.View.Services
{
    public class ExcelXmlFileDialog : IExcelXmlFileDialog
    {
        private const string Filter = "Excel or XML documents|*.xlsx;*.xls;*.xlsm;*.xml";

        public string OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = Filter; // Filter files by extension
            openFileDialog.ValidateNames = false;
            bool? result = openFileDialog.ShowDialog();
            if (result == true)
            {
                return openFileDialog.FileName;
            }
            return null;
        }

        public string SaveFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = Filter; // Filter files by extension
            saveFileDialog.ValidateNames = false;
            bool? result = saveFileDialog.ShowDialog();
            if (result == true)
            {
                return saveFileDialog.FileName;
            }
            return null;
        }
    }
}
