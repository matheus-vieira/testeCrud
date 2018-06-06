using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudPessoa.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
    }
}
