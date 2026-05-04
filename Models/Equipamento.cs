using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValeAtivos32427421.Models
{
    public class Equipamento
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Tipo { get; set; }

        [Required]
        public string Localizacao { get; set; }

        [Required]
        public double CapacidadeProcessamento { get; set; }

        public DateTime DataUltimaManutencao { get; set; } = DateTime.Now;

        [Required]
        public bool EmOperacao { get; set; }
        


    }
}