using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIConcessionaria
{
    public class EstoqueDeCarros
    {
        [Key, MaxLength(7)]
        public string Placa { get; set; } = string.Empty;
        [MaxLength(50)]
        public string Fabricante { get; set; } = string.Empty;
        [MaxLength(50)]
        public string Modelo { get; set; } = string.Empty;
        [Range(1900, int.MaxValue, ErrorMessage = "Ano invalido")]
        public int Ano { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "A quilometragem deve ser positiva.")]
        public double Quilometragem { get; set; }
        [MaxLength(10)]
        public string Situacao { get; set; } = string.Empty;
        [Range(0, double.MaxValue, ErrorMessage = "O valor da Fipe deve ser positivo.")]
        public double Fipe { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "O valor de compra deve ser positivo.")]
        public double ValorComprado { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "O valor de venda deve ser positivo.")]
        public double ValorVenda { get; set; }
    }

}