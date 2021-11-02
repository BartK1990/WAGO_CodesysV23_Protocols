using System.Windows;
using System.Windows.Controls;
using WAGO_CodesysV23_CommProtocolConfigGenerator.UI.ViewModel;

namespace WAGO_CodesysV23_CommProtocolConfigGenerator.UI.View
{
    /// <summary>
    /// Interaction logic for ConverterXmlExcelView.xaml
    /// </summary>
    public partial class ConverterXmlExcelView : Page
    {
        public ConverterXmlExcelView()
        {
            InitializeComponent();
        }

        private void TextBox_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if(files.Length > 0)
                {
                    ((ConverterXmlExcelViewModel)this.DataContext).GetProtocolConfigurationCommand.ExecuteAsync(files[0]);
                }
            }
        }

        private void TextBox_PreviewDragOver(object sender, DragEventArgs e)
        {
            e.Handled = true;
        }
    }
}
