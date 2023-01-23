using System.Globalization;

namespace ControleLocadoraAuto.Entities
{
    class Fatura
    {
        public double PagamentoBasico { get; set; }
        public double Taxa { get; set; }

        public Fatura(double pagamentoBasico, double taxa)
        {
            PagamentoBasico = pagamentoBasico;
            Taxa = taxa;
        }

        public double PagamentoTotal
        {
            get { return PagamentoBasico + Taxa; }
        }

        public override string ToString()
        {
            return "Pagamento básico: "
                + PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTaxa: "
                + Taxa.ToString("F2", CultureInfo.InvariantCulture)
                + "\nPagamento total: "
                + PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
