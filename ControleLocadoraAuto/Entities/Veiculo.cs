using ControleLocadoraAuto.Entities.Enums;
using System;

namespace ControleLocadoraAuto.Entities
{
    class Veiculo
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public Categorias Categoria { get; set; }
        public int AnoFabricacao { get; set; }
        public bool Disponivel { get; set; }

        public Veiculo(int id, string modelo, Categorias categoria, int anoFabricacao, bool disponivel)
        {
            Id = id;
            Modelo = modelo;
            Categoria = categoria;
            AnoFabricacao = anoFabricacao;
            Disponivel = disponivel;
        }


        public Veiculo(string modelo)
        {
            Modelo = modelo;
        }

        public override string ToString()
        {
            return Id 
                + ";" + Modelo
                + ";" + Categoria.ToString()
                + ";" + AnoFabricacao
                + ";" + Disponivel;

        }
    }
}
