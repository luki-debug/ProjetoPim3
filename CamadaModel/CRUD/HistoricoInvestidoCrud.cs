using CamadaControler.AcessoBancoDados;
using CamadaModel.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace CamadaModel.CRUD
{
    public class HistoricoInvestidoCrud
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();


        public string Inserir(HistoricoInvestido historicoInvestido)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@IdCarteira", historicoInvestido._carteira.IdCarteira);
                acessoDados.AdicionarParametros("@DtInicio", historicoInvestido.DtInicio);
                acessoDados.AdicionarParametros("@ValorInvestido", historicoInvestido.ValorInvestido);
                
                string retornoHistorico = acessoDados.ExecutarManipulacao(CommandType.Text, "BEGIN " +
                    "INSERT INTO HistoricoInvestido " +
                    "(IdCarteira,DtInicio,ValorInvestido) " +
                    "VALUES (@IdCarteira,@DtInicio,@ValorInvestido) " +
                    "SELECT @@IDENTITY as RETORNO " +
                    "END").ToString();

                return retornoHistorico;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
    }
}
