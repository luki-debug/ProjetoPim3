using CamadaModel.CRUD;
using CamadaModel.Entities.Json.CotacaoApi;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CamadaModel.Entities
{
    public class ReportDashBoard
    {
        public double ValorCursoFBitCoin { get; set; }
        public double ValorCursoFEtherium { get; set; }
        public double ValorCursoJBitCoin { get; set; }
        public double ValorCursoJEtherium { get; set; }
        public CotacaoApi CotacaoApi { get; set; }
        public List<InvestidorFBitCoin> InvestidoresFTopBitCoin { get; set; }
        public List<InvestidorFEtherium> InvestidoresFTopEtherium { get; set; }
        public List<InvestidorJBitCoin> InvestidoresJTopBitCoin { get; set; }
        public List<InvestidorJEtherium> InvestidoresJTopEtherium { get; set; }
        public List<UltimoLoginMes> LoginMeses { get; set; }

        public void CarregarPropriedadesReport()
        {
            DashBoardSelect select = new DashBoardSelect();
            var selectInvestidorFTopBitCoin = select.InvestimentoFisicaTop(2);
            var selectInvestidorJTopBitCoin = select.InvestimentoJuridicaTop(2);
            var selectInvestidorFTopEtherium = select.InvestimentoFisicaTop(1);
            var selectInvestidorJTopEtherium = select.InvestimentoJuridicaTop(1);
            var selectLoginMes = select.TotalMesUltimoLogin();
            var valorCursoFBitCoin = select.InvestimentoFisica(new DateTime(1800, 01, 01), DateTime.Now, "IS NULL", 2);
            var valorCursoFEtherium = select.InvestimentoFisica(new DateTime(1800, 01, 01), DateTime.Now, "IS NULL", 1);
            var valorCursoJBitCoin = select.InvestimentoJuridico(new DateTime(1800, 01, 01), DateTime.Now, "IS NULL", 2);
            var valorCursoJEtherium = select.InvestimentoJuridico(new DateTime(1800, 01, 01), DateTime.Now, "IS NULL", 1);

            Negocio negocio = new Negocio();

            ValorCursoFBitCoin = 0;
            foreach (System.Data.DataRow row in valorCursoFBitCoin.Rows)
            {
                double valorTemp = Convert.ToDouble(row[2], CultureInfo.InvariantCulture);
                ValorCursoFBitCoin += negocio.ConverterCriptoParaReal(valorTemp, 2);
            }

            ValorCursoJBitCoin = 0;
            foreach (System.Data.DataRow row in valorCursoJBitCoin.Rows)
            {
                double valorTemp = Convert.ToDouble(row[2], CultureInfo.InvariantCulture);
                ValorCursoJBitCoin += negocio.ConverterCriptoParaReal(valorTemp, 2);
            }

            ValorCursoFEtherium = 0;
            foreach (System.Data.DataRow row in valorCursoFEtherium.Rows)
            {
                double valorTemp = Convert.ToDouble(row[2], CultureInfo.InvariantCulture);
                ValorCursoFEtherium += negocio.ConverterCriptoParaReal(valorTemp, 1);
            }

            ValorCursoJEtherium = 0;
            foreach (System.Data.DataRow row in valorCursoJEtherium.Rows)
            {
                double valorTemp = Convert.ToDouble(row[2], CultureInfo.InvariantCulture);
                ValorCursoJEtherium += negocio.ConverterCriptoParaReal(valorTemp, 1);
            }



            InvestidoresFTopBitCoin = new List<InvestidorFBitCoin>();
            int i = 0;
            foreach (System.Data.DataRow row in selectInvestidorFTopBitCoin.Rows)
            {
                InvestidorFBitCoin investidor = new InvestidorFBitCoin();
                string[] nomeCompleto = Convert.ToString(row[0]).Split(' ');
                if (nomeCompleto.Length > 1)
                    investidor.Nome = $"{i}." + nomeCompleto[0] + ' ' + nomeCompleto[1].Substring(0, 1);
                else
                    investidor.Nome = $"{i}." + nomeCompleto[0];
                investidor.ValorTotal = Convert.ToDouble(row[2], CultureInfo.InvariantCulture);
                investidor.ValorTotal = negocio.ConverterCriptoParaReal(investidor.ValorTotal, 2);

                i++;
                InvestidoresFTopBitCoin.Add(investidor);
            }

            InvestidoresJTopBitCoin = new List<InvestidorJBitCoin>();
            i = 0;
            foreach (System.Data.DataRow row in selectInvestidorJTopBitCoin.Rows)
            {
                InvestidorJBitCoin investidor = new InvestidorJBitCoin();
                investidor.RazaoSocial = Convert.ToString($"{i}." + row[0]).Substring(0,8);
                investidor.ValorTotal = Convert.ToDouble(row[2], CultureInfo.InvariantCulture);
                investidor.ValorTotal = negocio.ConverterCriptoParaReal(investidor.ValorTotal, 2);

                i++;
                InvestidoresJTopBitCoin.Add(investidor);
            }

            InvestidoresFTopEtherium = new List<InvestidorFEtherium>();
            i = 0;
            foreach (System.Data.DataRow row in selectInvestidorFTopEtherium.Rows)
            {
                InvestidorFEtherium investidor = new InvestidorFEtherium();
                string[] nomeCompleto = Convert.ToString(row[0]).Split(' ');
                if (nomeCompleto.Length > 1)
                    investidor.Nome = $"{i}." + nomeCompleto[0] + ' ' + nomeCompleto[1].Substring(0,1);
                else
                    investidor.Nome = $"{i}." + nomeCompleto[0];
                investidor.ValorTotal = Convert.ToDouble(row[2], CultureInfo.InvariantCulture);
                investidor.ValorTotal = negocio.ConverterCriptoParaReal(investidor.ValorTotal, 1);

                i++;
                InvestidoresFTopEtherium.Add(investidor);
            }

            InvestidoresJTopEtherium = new List<InvestidorJEtherium>();
            i = 0;
            foreach (System.Data.DataRow row in selectInvestidorJTopEtherium.Rows)
            {
                InvestidorJEtherium investidor = new InvestidorJEtherium();
                investidor.RazaoSocial = Convert.ToString($"{i}." + row[0]).Substring(0, 8);
                investidor.ValorTotal = Convert.ToDouble(row[2], CultureInfo.InvariantCulture);
                investidor.ValorTotal = negocio.ConverterCriptoParaReal(investidor.ValorTotal, 1);

                i++;
                InvestidoresJTopEtherium.Add(investidor);
            }



            CotacaoApi = negocio.GetMoedaAsync();


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
