using ControleLocadoraAuto.Entities.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleLocadoraAuto.ArquivosBD
{
    public class Leitura
    {
        public static List<string> ListarVeiculos(String path, Categorias cat, bool disponivel)
        {  
            try
            {
                string[] lines = File.ReadAllLines(path);
                List<string> carrosDisponiveis = new List<string>();
                
                foreach (string line in lines)
                {
                    string[] aux = line.Split(';');
                    if (aux[2] == cat.ToString() && bool.Parse(aux[4]) == disponivel)
                    {
                        carrosDisponiveis.Add(line);
                    }
                }
                return carrosDisponiveis;
            }
            catch (IOException e)
            {
                MessageBox.Show("Aconteceu um erro inesperado no banco de dados: " + e.Message,"ERRO",MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }
        public static List<string> ListarVeiculos(String path, bool disponivel)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                List<string> carrosDisponiveis = new List<string>();

                foreach (string line in lines)
                {
                    string[] aux = line.Split(';');
                    if (bool.Parse(aux[4]) == disponivel)
                    {
                        carrosDisponiveis.Add(line);
                    }
                }
                return carrosDisponiveis;
            }
            catch (IOException e)
            {
                MessageBox.Show("Aconteceu um erro inesperado no banco de dados: " + e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }


        public static string VeiculoAlugado(String path, int id)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    if (int.Parse(line.Split(';')[0]) == id)
                    {
                        return line;
                    }
                }
                return "";
            }
            catch (IOException e)
            {
                MessageBox.Show("Aconteceu um erro inesperado no banco de dados: " + e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return "";
            }
        }
    }
}