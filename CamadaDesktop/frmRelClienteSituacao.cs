using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaDesktop
{
    public partial class frmRelClienteSituacao : Form
    {
        public frmRelClienteSituacao()
        {
            List<IconButton> listBtn = new List<IconButton>();

            InitializeComponent();


            DefaultLayout defaultLayout = new DefaultLayout();
            defaultLayout.FormDefaultFilha(this, listBtn);
            defaultLayout.LayoutReportViewer(reportViewer);
        }

        private void ReportFisicaOrJuridica(string where)
        {
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();

            if (rbFisica.Checked == true)
            {
                reportDataSource1.Name = "DataSetFisicaAtiva";
                reportDataSource1.Value = this.relFisicaAtivoBindingSource;
                this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
                this.reportViewer.LocalReport.ReportEmbeddedResource = "CamadaDesktop.Relatorios.ReportFisicaAtiva.rdlc";

                // TODO: This line of code loads data into the 'bdLumiaDataSet.RelFisicaAtivo' table. You can move, or remove it, as needed.
                this.relFisicaAtivoTableAdapter.Fill(bdLumiaDataSet.RelFisicaAtivo, where);
            }
            else
            {
                reportDataSource1.Name = "DataSetJuridicaAtiva";
                reportDataSource1.Value = this.RelJuridicaAtivoBindingSource;
                this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
                this.reportViewer.LocalReport.ReportEmbeddedResource = "CamadaDesktop.Relatorios.ReportJuridicaAtiva.rdlc";

                // TODO: This line of code loads data into the 'bdLumiaDataSet.RelFisicaAtivo' table. You can move, or remove it, as needed.
                this.RelJuridicaAtivoTableAdapter.Fill(bdLumiaDataSet.RelJuridicaAtivo, where);               
            }
        }

        private void reportViewer_Load(object sender, EventArgs e)
        {
            FuncoesTela.DesativarPDFReport(reportViewer);
        }
        private void btnAtivo_Click(object sender, EventArgs e)
        {
            reportViewer.Visible = true;

            string where= "T";

            ReportFisicaOrJuridica(where);
            this.reportViewer.RefreshReport();
        }

        private void btnInativo_Click(object sender, EventArgs e)
        {
            reportViewer.Visible = true;

            string where = "F";

            ReportFisicaOrJuridica(where);
            this.reportViewer.RefreshReport();
        }
    }
}
