namespace ControleLocadoraAuto.Services
{
    class TaxaServicoLuxo : ITaxaServico
    {
        public const double ValorPorHora = 30.00;
        public const double ValorPorDia = 390.00;
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
