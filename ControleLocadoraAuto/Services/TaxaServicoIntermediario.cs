namespace ControleLocadoraAuto.Services
{
    class TaxaServicoIntermediario : ITaxaServico
    {
        public const double ValorPorHora = 20.00;
        public const double ValorPorDia = 260.00;
        public double Taxa(double valor)
        {
            if (valor <= 100.0)
            {
                return valor * 0.2;
            }
            else
            {
                return valor * 0.15;
            }
        }


    }
}
