using DLWMS.Data;
using DLWMS.Data.IB230046;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        public frmIzvjestaji(Student s, List<dtoStudentiPorukeIB230046> poruke)
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = poruke;
        }
        
    }
}
