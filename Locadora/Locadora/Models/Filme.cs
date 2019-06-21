using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Models
{
    public class Filme
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Genero { get; set; }
        public string Sinopse { get; set; }
        public double Valor { get; set; }
    }
}
