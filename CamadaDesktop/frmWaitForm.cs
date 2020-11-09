using CamadaModel;
using CamadaModel.Entities;
using CamadaModel.Entities.Json.CotacaoApi;
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

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            List<string> listCotacao = new List<string>();
            Carteira carteira = new Carteira();

            label1.Visible = true;
            pictureBox1.Visible = true;
            Negocio negocio = new Negocio();
            
            var retorno2= await Task.Run(() => negocio.GetMoedaAsync());

            var retorno= await Task.Run(()=>negocio.ConverterCriptoParaReal(double.Parse(txtvalor.Text, CultureInfo.InvariantCulture), int.Parse(txtmoeda.Text))); 
           

            label1.Visible = false;
            pictureBox1.Visible = false;

            //fromato real
            lblEtherium.Text = string.Format("{0:c}", retorno);

            //formato bitcoin
            //lblEtherium.Text = string.Format("{0:0.00####}", retorno);
            label5.Text = retorno2.BTC.bid;
        }

        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);
        //    Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        //}
    }
}
