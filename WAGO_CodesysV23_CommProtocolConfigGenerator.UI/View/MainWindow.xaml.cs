using ControlzEx.Theming;
using MahApps.Metro.Controls;
using System.Windows;

namespace WAGO_CodesysV23_CommProtocolConfigGenerator.UI.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private readonly ConverterXmlExcelView converterXmlExcelView;
        private readonly App curApp;

        public MainWindow()
        {
            InitializeComponent();

            // Reference for this application
            curApp = (App)Application.Current;

            // Initialize views for Window
            converterXmlExcelView = new ConverterXmlExcelView();

            // Initialize ViewModel and assign to DataContext for window/page
            converterXmlExcelView.DataContext = new ViewModel.ConverterXmlExcelViewModel();

            //Only one view for now
            WindowContent.Navigate(converterXmlExcelView);
        }


        private void DeployCupCakes(object sender, RoutedEventArgs e)
        {
            var themeName = ThemeManager.Current.DetectTheme(curApp).Name;
            if(themeName == "Light.Blue")
            {
                ThemeManager.Current.ChangeTheme(curApp, "Dark.Blue");
                return;
            }
            if (themeName == "Dark.Blue")
            {
                ThemeManager.Current.ChangeTheme(curApp, "Light.Blue");
                return;
            }
            ThemeManager.Current.ChangeTheme(curApp, "Dark.Blue");
        }
    }
}
