using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleLocadoraAuto.ArquivosBD
{
    public class Atualizacao
    {
        public static bool AtualizarRegistro(string path, int id, DateTime dataHoraAluguel, string operacao) 
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                if (operacao == "alugar")
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (int.Parse(lines[i].Split(';')[0]) == id)
                        {
                            string[] aux = lines[i].Split(';');
                            aux[4] = "false";
                            aux[5] = dataHoraAluguel.ToString("dd/MM/yyyy HH:mm");

                            lines[i] = String.Join(";", aux);
                        }
                    }
                }
                else if (operacao == "devolver")
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (int.Parse(lines[i].Split(';')[0]) == id)
                        {
                            string[] aux = lines[i].Split(';');
                            aux[4] = "true";
                            aux[5] = "";

                            lines[i] = String.Join(";", aux);
                        }
                    }
                }


                StringBuilder sb = new StringBuilder();
                foreach (string line in lines)
                {
                    sb.AppendLine(line);
                }
                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    writer.Write(sb.ToString());
                }
                return true;
            }
            catch (IOException e)
            {             
                MessageBox.Show("Aconteceu um erro inesperado no banco de dados: " + e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
    }
}
