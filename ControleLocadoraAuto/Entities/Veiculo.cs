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



        public Veiculo(string modelo)
        {
            Modelo = modelo;
        }
    }
}
