using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
                // Note that you can have more than one file.
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                var s = sender as TextBox;
                if (files.Length == 1)
                    s.Text = files[0];
            }
        }

        private void TextBox_PreviewDragOver(object sender, DragEventArgs e)
        {
            e.Handled = true;
        }
    }
}
