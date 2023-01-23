namespace ControleLocadoraAuto.Services
{
    class TaxaServicoBasico : ITaxaServico
    {
        public const double ValorPorHora = 10.00;
        public const double ValorPorDia = 130.00;
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
