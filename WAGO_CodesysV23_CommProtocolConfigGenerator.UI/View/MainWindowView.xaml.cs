using ControlzEx.Theming;
using MahApps.Metro.Controls;
using MahApps.Metro.IconPacks;
using System.Windows;
using System.Windows.Controls;
using WAGO_CodesysV23_CommProtocolConfigGenerator.UI.ViewModel;

namespace WAGO_CodesysV23_CommProtocolConfigGenerator.UI.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowView : MetroWindow
    {
        private readonly App curApp;

        public MainWindowView()
        {
            InitializeComponent();

            // Reference for this application
            curApp = (App)Application.Current;

            // Initialize Page views for Window
            var converterXmlExcelView = new ConverterXmlExcelView
            {
                DataContext = new ViewModel.ConverterXmlExcelViewModel()
            };
            var informationView = new InformationView();

            // Hamburger menu items
            HamburgerMenuControl.ItemsSource = new HamburgerMenuItemCollection()
            {
                new HamburgerMenuIconItem()
                {
                    Label = "Converter",
                    Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.HomeSolid },
                    Tag = converterXmlExcelView
                },
                new HamburgerMenuIconItem()
                {
                    Label = "Info",
                    Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.InfoSolid },
                    Tag = informationView
                }
            };
        }

        private void HamburgerMenuControl_OnItemClick(object sender, ItemClickEventArgs e)
        {
            // set the content
            this.HamburgerMenuControl.SetCurrentValue(ContentProperty, e.ClickedItem);
            this.HamburgerMenuControl.SetCurrentValue(HamburgerMenu.IsPaneOpenProperty, false);
        }

        private void ChangeThemeClick(object sender, RoutedEventArgs e)
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
