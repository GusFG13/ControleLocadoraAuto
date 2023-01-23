using ControleLocadoraAuto.ArquivosBD;
using ControleLocadoraAuto.Entities;
using ControleLocadoraAuto.Entities.Enums;
using ControleLocadoraAuto.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleLocadoraAuto
{
    public partial class Form1 : Form
    {
        string sourcePath = @"c:\temp\ListaCarros.csv";
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        { 
            //DateTime myDate = datePortionDateTimePicker.Value.Date + timePortionDateTimePicker.Value.TimeOfDay;
            DateTime inicio = dtpDataHoraInicio.Value;
            DateTime fim = dtpDataHoraFim.Value;

            double hora = double.Parse(tbValorHora.Text, CultureInfo.InvariantCulture);
            double dia = double.Parse(tbValorDia.Text, CultureInfo.InvariantCulture);

            AluguelCarro aluguelCarro = new AluguelCarro(inicio, fim, new Veiculo("Civic"));

            ServicoAluguel servicoAluguel = new ServicoAluguel(hora, dia, new TaxaServicoBasico());

            if (rbBasico.Checked)
                servicoAluguel = new ServicoAluguel(hora, dia, new TaxaServicoBasico());
            else if (rbIntermediario.Checked)
                servicoAluguel = new ServicoAluguel(hora, dia, new TaxaServicoIntermediario());
            else if (rbLuxo.Checked)
                servicoAluguel = new ServicoAluguel(hora, dia, new TaxaServicoLuxo());
            
            servicoAluguel.ProcessInvoice(aluguelCarro);

            rtbFaturaCalculada.Text = aluguelCarro.Fatura.ToString();
        }

        private void rbBasico_CheckedChanged(object sender, EventArgs e)
        {
            CategoriaSelecionada(Categorias.Basico);
            
        }

        private void rbIntemediario_CheckedChanged(object sender, EventArgs e)
        {
            CategoriaSelecionada(Categorias.Intermediario);
        }

        private void rbLuxo_CheckedChanged(object sender, EventArgs e)
        {
            CategoriaSelecionada(Categorias.Luxo);
        }

        private void CategoriaSelecionada(Categorias cat)
        {
            switch (cat)
            {
                case Categorias.Basico:
                    tbValorHora.Text = TaxaServicoBasico.ValorPorHora.ToString("F2", CultureInfo.InvariantCulture);
                    tbValorDia.Text = TaxaServicoBasico.ValorPorDia.ToString("F2", CultureInfo.InvariantCulture);
                    cbCarrosDisponiveis.DataSource = Leitura.ListarVeiculos(sourcePath, Categorias.Basico);
                    break;
                case Categorias.Intermediario:
                    tbValorHora.Text = TaxaServicoIntermediario.ValorPorHora.ToString("F2", CultureInfo.InvariantCulture);
                    tbValorDia.Text = TaxaServicoIntermediario.ValorPorDia.ToString("F2", CultureInfo.InvariantCulture);
                    cbCarrosDisponiveis.DataSource = Leitura.ListarVeiculos(sourcePath, Categorias.Intermediario);
                    break;
                case Categorias.Luxo:
                    tbValorHora.Text = TaxaServicoLuxo.ValorPorHora.ToString("F2", CultureInfo.InvariantCulture);
                    tbValorDia.Text = TaxaServicoLuxo.ValorPorDia.ToString("F2", CultureInfo.InvariantCulture);
                    cbCarrosDisponiveis.DataSource = Leitura.ListarVeiculos(sourcePath, Categorias.Luxo);
                    break;
                default: 
                    break;
            }
        }
    }
}
