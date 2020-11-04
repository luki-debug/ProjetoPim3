using CamadaModel.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaModel.Entities
{
    public class ReportDashBoard
    {
        public double ValorCursoF { get; set; }
        public double ValorDisponivelF { get; set; }
        public double ValorRetidoF { get; set; }
        public double ValorCursoJ { get; set; }
        public double ValorDisponivelJ { get; set; }
        public double ValorRetidoJ { get; set; }
        public List<InvestidorF> InvestidoresFTop { get; set; }
        public List<InvestidorJ> InvestidoresJTop { get; set; }
        public List<UltimoLoginMes> LoginMeses { get; set; }

        public void CarregarPropriedadesReport()
        {
            DashBoardSelect select = new DashBoardSelect();
            var selectInvestidorFTop = select.InvestimentoFisicaTop();
            var selectInvestidorJTop = select.InvestimentoJuridicaTop();
            var selectLoginMes = select.TotalMesUltimoLogin();
            var valorCursoF = select.InvestimentoFisica(new DateTime(1800, 01, 01), DateTime.Now, "IS NULL");
            var valorDisponivelF = select.InvestimentoFisica(new DateTime(1800, 01, 01), DateTime.Now.AddMonths(-1), "IS NULL");
            var valorRetidoF = select.InvestimentoFisica(DateTime.Now.AddMonths(-1), DateTime.Now, "IS NULL");
            var valorCursoJ = select.InvestimentoJuridico(new DateTime(1800, 01, 01), DateTime.Now, "IS NULL");
            var valorDisponivelJ = select.InvestimentoJuridico(new DateTime(1800, 01, 01), DateTime.Now.AddMonths(-1), "IS NULL");
            var valorRetidoJ = select.InvestimentoJuridico(DateTime.Now.AddMonths(-1), DateTime.Now, "IS NULL");

            ValorCursoF = 0;
            foreach (System.Data.DataRow row in valorCursoF.Rows)
            {
                ValorCursoF += Convert.ToDouble(row[2]);
            }

            ValorDisponivelF = 0;
            foreach (System.Data.DataRow row in valorDisponivelF.Rows)
            {
                ValorDisponivelF += Convert.ToDouble(row[2]);
            }
            ValorRetidoF = 0;
            foreach (System.Data.DataRow row in valorRetidoF.Rows)
            {
                ValorRetidoF += Convert.ToDouble(row[2]);
            }

            ValorCursoJ = 0;
            foreach (System.Data.DataRow row in valorCursoJ.Rows)
            {
                ValorCursoJ += Convert.ToDouble(row[2]);
            }

            ValorDisponivelJ = 0;
            foreach (System.Data.DataRow row in valorDisponivelJ.Rows)
            {
                ValorDisponivelJ += Convert.ToDouble(row[2]);
            }
            ValorRetidoJ = 0;
            foreach (System.Data.DataRow row in valorRetidoJ.Rows)
            {
                ValorRetidoJ += Convert.ToDouble(row[2]);
            }


            InvestidoresFTop = new List<InvestidorF>();
            foreach (System.Data.DataRow row in selectInvestidorFTop.Rows)
            {
                InvestidorF investidor = new InvestidorF();
                string[] nomeCompleto= Convert.ToString(row[0]).Split(' ');
                if (nomeCompleto.Length > 1)
                    investidor.Nome = nomeCompleto[0] + ' ' + nomeCompleto[1];
                else
                    investidor.Nome = nomeCompleto[0];
                investidor.ValorTotal = Convert.ToDouble(row[2]);

                InvestidoresFTop.Add(investidor);
            }
            InvestidoresJTop = new List<InvestidorJ>();
            foreach (System.Data.DataRow row in selectInvestidorJTop.Rows)
            {
                InvestidorJ investidor = new InvestidorJ();
                investidor.RazaoSocial = Convert.ToString(row[0]);
                investidor.ValorTotal = Convert.ToDouble(row[2]);

                InvestidoresJTop.Add(investidor);
            }

            LoginMeses = new List<UltimoLoginMes>();
            foreach (System.Data.DataRow row in selectLoginMes.Rows)
            {
                int mes = 0;
                UltimoLoginMes loginMes = new UltimoLoginMes();
                loginMes.Quantidade = Convert.ToInt32(row[0]);
                mes = Convert.ToInt32(row[1]);
                if (mes == 1)
                    loginMes.Mes = "Janeiro";
                if (mes == 2)
                    loginMes.Mes = "Fevereiro";
                if (mes == 3)
                    loginMes.Mes = "Março";
                if (mes == 4)
                    loginMes.Mes = "Abril";
                if (mes == 5)
                    loginMes.Mes = "Maio";
                if (mes == 6)
                    loginMes.Mes = "Junho";
                if (mes == 7)
                    loginMes.Mes = "Julho";
                if (mes == 8)
                    loginMes.Mes = "Agosto";
                if (mes == 9)
                    loginMes.Mes = "Setembro";
                if (mes == 10)
                    loginMes.Mes = "Outubro";
                if (mes == 11)
                    loginMes.Mes = "Novembro";
                if (mes == 12)
                    loginMes.Mes = "Dezembro";

                LoginMeses.Add(loginMes);
            }
        }
    }
}
