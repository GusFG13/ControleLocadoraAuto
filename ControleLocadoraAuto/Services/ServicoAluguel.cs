using ControleLocadoraAuto.Entities;
using System;

namespace ControleLocadoraAuto.Services
{
    class ServicoAluguel
    {
        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }

        private ITaxaServico _taxaServico;

        public ServicoAluguel(double precoPorHora, double precoPorDia, ITaxaServico taxaServico)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _taxaServico = taxaServico;
        }

        public void ProcessInvoice(AluguelCarro aluguelCarro)
        {
            TimeSpan duracao = aluguelCarro.Fim.Subtract(aluguelCarro.Inicio);

            double pagamentoBasico = 0.0;
            if (duracao.TotalHours <= 12.0)
            {
                pagamentoBasico = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                pagamentoBasico = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }

            double taxa = _taxaServico.Taxa(pagamentoBasico);

            aluguelCarro.Fatura = new Fatura(pagamentoBasico, taxa);
        }
    }
}
