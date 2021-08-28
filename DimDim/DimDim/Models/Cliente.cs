using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DimDim.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AlteradoEm { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string NomeMae { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
    }
}
