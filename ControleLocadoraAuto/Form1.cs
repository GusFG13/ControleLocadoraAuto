using ControleLocadoraAuto.ArquivosBD;
using ControleLocadoraAuto.Entities;
using ControleLocadoraAuto.Entities.Enums;
using ControleLocadoraAuto.Services;
using System;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Reflection;
using System.Drawing;
using System.IO;

namespace ControleLocadoraAuto
{
    public partial class Form1 : Form
    {
        string sourcePath = @"c:\temp\LocadoraVeiculos\ListaCarros.csv";
        string imagemPath = @"c:\temp\LocadoraVeiculos\fotosCarros\";
        // variáveis que criadas ao abrir o form
        List<string> ListaCarros = new List<string>();
        string[] modelosDisponiveis;
        int id;

        AluguelCarro aluguelCarro;

        ServicoAluguel servicoAluguel;

        DateTime aberturaApp = DateTime.Now;

        public Form1()
        {
            InitializeComponent();
            rbBasico.Checked = true;
            //cbCarrosDisponiveis.DataSource = Leitura.ListarVeiculos(sourcePath, Categorias.Basico);
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            DateTime inicio = dtpDataHoraInicio.Value;
            DateTime fim = dtpDataHoraFim.Value;


            // teste adicionado
            if (cbCarrosDisponiveis.DataSource != null && fim > inicio && inicio >= aberturaApp)
            {
                double hora = double.Parse(tbValorHora.Text, CultureInfo.InvariantCulture);
                double dia = double.Parse(tbValorDia.Text, CultureInfo.InvariantCulture);

                int indice = cbCarrosDisponiveis.SelectedIndex;
                string[] aux = modelosDisponiveis[indice].Split(';');
                id = int.Parse(aux[0]);
                string modelo = aux[1];
                Categorias categoria;
                Enum.TryParse(aux[2], out categoria);
                int anoFabricacao = int.Parse(aux[3]);
                bool disponivel = bool.Parse(aux[4]);

                Veiculo veiculo = new Veiculo(id, modelo, categoria, anoFabricacao, disponivel);
                //aluguelCarro = new AluguelCarro(inicio, fim, new Veiculo("Civic"));
                aluguelCarro = new AluguelCarro(inicio, fim, veiculo);

                servicoAluguel = new ServicoAluguel(hora, dia, new TaxaServicoBasico());

                if (rbBasico.Checked)
                    servicoAluguel = new ServicoAluguel(hora, dia, new TaxaServicoBasico());
                else if (rbIntermediario.Checked)
                    servicoAluguel = new ServicoAluguel(hora, dia, new TaxaServicoIntermediario());
                else if (rbLuxo.Checked)
                    servicoAluguel = new ServicoAluguel(hora, dia, new TaxaServicoLuxo());

                servicoAluguel.ProcessInvoice(aluguelCarro);

                rtbFaturaCalculada.Text = veiculo.ToString() + "\n\n" + aluguelCarro.Fatura.ToString();
                btAlugar.Enabled = true;
            }

        }

        private void btAlugar_Click(object sender, EventArgs e)
        {
            DateTime inicio = dtpDataHoraInicio.Value;
            Atualizacao.AtualizarRegistro(sourcePath, id, inicio);
            MessageBox.Show("Carro alugado", "Operação concluída", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void rbBasico_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBasico.Checked) // teste adicionado
                CategoriaSelecionada(Categorias.Basico);
        }

        private void rbIntemediario_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIntermediario.Checked) // teste adicionado
                CategoriaSelecionada(Categorias.Intermediario);
        }

        private void rbLuxo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLuxo.Checked) // teste adicionado
                CategoriaSelecionada(Categorias.Luxo);
        }

        private void CategoriaSelecionada(Categorias cat)
        {
            switch (cat)
            {
                case Categorias.Basico:
                    tbValorHora.Text = TaxaServicoBasico.ValorPorHora.ToString("F2", CultureInfo.InvariantCulture);
                    tbValorDia.Text = TaxaServicoBasico.ValorPorDia.ToString("F2", CultureInfo.InvariantCulture);
                    ListaCarros = Leitura.ListarVeiculos(sourcePath, Categorias.Basico, true);
                    break;
                case Categorias.Intermediario:
                    tbValorHora.Text = TaxaServicoIntermediario.ValorPorHora.ToString("F2", CultureInfo.InvariantCulture);
                    tbValorDia.Text = TaxaServicoIntermediario.ValorPorDia.ToString("F2", CultureInfo.InvariantCulture);
                    ListaCarros = Leitura.ListarVeiculos(sourcePath, Categorias.Intermediario, true);
                    break;
                case Categorias.Luxo:
                    tbValorHora.Text = TaxaServicoLuxo.ValorPorHora.ToString("F2", CultureInfo.InvariantCulture);
                    tbValorDia.Text = TaxaServicoLuxo.ValorPorDia.ToString("F2", CultureInfo.InvariantCulture);
                    ListaCarros = Leitura.ListarVeiculos(sourcePath, Categorias.Luxo, true);
                    break;
                default:
                    break;
            }
            // teste adicionado
            if (ListaCarros.Count > 0)
            {
                List<string> modeloAno = new List<string>();
                modelosDisponiveis = ListaCarros.ToArray();
                foreach (string carro in modelosDisponiveis)
                {
                    string[] aux = carro.Split(';');
                    modeloAno.Add(aux[1] + " " + aux[3]);
                }
                cbCarrosDisponiveis.DataSource = modeloAno;
            }
            else
            {
                cbCarrosDisponiveis.DataSource = null;
                MessageBox.Show("Não há carros disponíveis na categoria selecionada.", "Categoria indisponível!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void cbCarrosDisponiveis_SelectedIndexChanged(object sender, EventArgs e)
        {// teste adicionado
            rtbFaturaCalculada.Text = "";
            btAlugar.Enabled = false;
            int indice = cbCarrosDisponiveis.SelectedIndex;
            string id = modelosDisponiveis[indice].Split(';')[0];
            picFotoCarro.ImageLocation = imagemPath + id + ".png";
        }

        private void btTelaDevolucao_Click(object sender, EventArgs e)
        {
            panAlugar.Visible = false;
            panDevolver.Visible = true;
            btTelaAluguel.BackColor = Color.Transparent;
            btTelaAluguel.ForeColor = Color.LightGray;
            btTelaDevolucao.BackColor = Color.LightGray;
            btTelaDevolucao.ForeColor = Color.Black;

            List<string> listAux = new List<string>();
            //Preencher listBox
            foreach(string item in Leitura.ListarVeiculos(sourcePath, false))
            {
                string[] aux = item.Split(';');
                listAux.Add(aux[0] + "\t" + aux[1] + "\t" + aux[5]);
            }

            lstCrrosAlugados.DataSource = listAux;

        }

        private void btTelaAluguel_Click(object sender, EventArgs e)
        {
            panDevolver.Visible = false;
            panAlugar.Visible = true;
            btTelaDevolucao.BackColor = Color.Transparent;
            btTelaDevolucao.ForeColor = Color.LightGray;
            btTelaAluguel.BackColor = Color.LightGray;
            btTelaAluguel.ForeColor = Color.Black;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            {// evita fechamento do app por engano ao clicar no botão fechar janela ou pressionar Alt + F4
                DialogResult resposta = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void lstCrrosAlugados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idAlugado = int.Parse(lstCrrosAlugados.SelectedItem.ToString().Split('\t')[0]);
            string dadosVeiculo = Leitura.VeiculoAlugado(sourcePath, idAlugado);
            DateTime momentoAluguel = DateTime.Parse(dadosVeiculo.Split(';')[5]);
            Categorias categoria = Categorias.Basico;
            Enum.TryParse(dadosVeiculo.Split(';')[2], out categoria);


            double hora = 0.0;
            double dia = 0.0;
            switch (categoria)
            {
                case Categorias.Basico:
                    hora = TaxaServicoBasico.ValorPorHora;
                    dia = TaxaServicoBasico.ValorPorDia;
                    break;
                case Categorias.Intermediario:
                    hora = TaxaServicoIntermediario.ValorPorHora;
                    dia = TaxaServicoIntermediario.ValorPorDia;
                    break;
                case Categorias.Luxo:
                    hora = TaxaServicoLuxo.ValorPorHora;
                    dia = TaxaServicoLuxo.ValorPorDia;
                    break;
                default:
                    break;
            }

            Veiculo veiculo = new Veiculo(id);

            aluguelCarro = new AluguelCarro(momentoAluguel, DateTime.Now, veiculo);

            servicoAluguel = new ServicoAluguel(hora, dia, new TaxaServicoBasico());

            if (rbBasico.Checked)
                servicoAluguel = new ServicoAluguel(hora, dia, new TaxaServicoBasico());
            else if (rbIntermediario.Checked)
                servicoAluguel = new ServicoAluguel(hora, dia, new TaxaServicoIntermediario());
            else if (rbLuxo.Checked)
                servicoAluguel = new ServicoAluguel(hora, dia, new TaxaServicoLuxo());

            servicoAluguel.ProcessInvoice(aluguelCarro);

            rtbFatura.Text = veiculo.ToString() + "\n\n" + aluguelCarro.Fatura.ToString();
        }
    }
}
