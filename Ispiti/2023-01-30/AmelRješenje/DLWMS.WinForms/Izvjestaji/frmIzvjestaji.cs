using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        public frmIzvjestaji()
        {
            InitializeComponent();         
        }

        public frmIzvjestaji(ReportParameterCollection parameters) : this()
        {
            reportViewer1.LocalReport.SetParameters(parameters); 
            
        }
        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
        }
    }
}
