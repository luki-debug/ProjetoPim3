namespace CamadaWebApi.Models
{
    public class Investimento
    {
        public double TotalRetido { get; set; }
        public double TotalDisponivel { get; set; }
        public double PatrimonioTotal { get; set; }
        public Investimento() { }
        public Investimento(double totalRetido, double totalDisponivel, double patrimonioTotal)
        {
            TotalRetido = totalRetido;
            TotalDisponivel = totalDisponivel;
            PatrimonioTotal = patrimonioTotal;
        }
    }
}