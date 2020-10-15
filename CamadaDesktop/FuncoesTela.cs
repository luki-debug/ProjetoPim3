using CamadaModel.CRUD;
using CamadaModel.Entities;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CamadaDesktop
{
    public class FuncoesTela
    {
        public static void AbrirFormFilha(Form frm, Form p)
        {
            frm.TopLevel = false;
            frm.AutoScroll = true;
            p.Parent.Controls.Add(frm);
            //frm.Parent = p.Parent;
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }
        public static void CarregarTodosClienteFisica(DataGridView dg)
        {
            List<Fisica> list = new List<Fisica>();
            Fisica fisica = new Fisica();
            FisicaCrud fisicaCrud = new FisicaCrud();
            fisica.Nome ="";
            list= fisicaCrud.ConsultarNome(fisica);

            dg.AutoGenerateColumns = false;
            dg.DataSource = null;
            dg.DataSource = list;
            dg.Refresh();
            dg.Update();
        }

        public static void CarregarTodosClienteJuridica(DataGridView dg)
        {
            List<Juridica> list = new List<Juridica>();
            Juridica juridica = new Juridica();
            JuridicaCrud juridicaCrud = new JuridicaCrud();
            juridica.RazaoSocial = "";
            list = juridicaCrud.ConsultarNome(juridica);

            dg.AutoGenerateColumns = false;
            dg.DataSource = null;
            dg.DataSource = list;
            dg.Refresh();
            dg.Update();
        }
    }
}
