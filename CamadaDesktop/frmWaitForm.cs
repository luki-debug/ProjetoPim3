using CamadaModel;
using CamadaModel.CRUD;
using CamadaModel.Entities;
using CamadaModel.Entities.Json.CotacaoApi;
using CamadaModel.Servicos;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaDesktop
{
    public partial class frmWaitForm : Form
    {
        //public Action Worker { get; set; }
        public frmWaitForm()//Action worker
        {
            InitializeComponent();

            //if (worker == null)
            //    throw new ArgumentNullException();
            //Worker = worker;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ServicoEmail email = new ServicoEmail();
            try
            {
                UsuarioCrud crud = new UsuarioCrud();
                string result=crud.RecuperarLogin(txtvalor.Text);

                string i =email.EmailRecuperacaoLogin(txtvalor.Text,result);
                MessageBox.Show(i);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);
        //    Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        //}
    }
}
