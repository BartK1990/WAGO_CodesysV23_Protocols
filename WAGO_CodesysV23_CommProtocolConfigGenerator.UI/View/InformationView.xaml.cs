using System.Text;
using System.Windows.Controls;

namespace WAGO_CodesysV23_CommProtocolConfigGenerator.UI.View
{
    /// <summary>
    /// Interaction logic for InformationView.xaml
    /// </summary>
    public partial class InformationView : Page
    {
        public InformationView()
        {
            InitializeComponent();

            var sb = new StringBuilder();
            sb.AppendLine("Converter supports:");
            sb.AppendLine("- IEC 60870-5-104");
            sb.AppendLine("  - M_SP_NA (01)");
            sb.AppendLine("  - M_ME_NC (13)");
            sb.AppendLine("  - C_SC_NA (45)");
            sb.AppendLine("  - C_SE_NC (50)");

            InormationTextBox.Text = sb.ToString();
        }
    }
}
