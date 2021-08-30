using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DimDim.Models
{
    public class Ted
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TedId { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AlteradoEm { get; set; }
        public string FavorecidoNome { get; set; }
        public string FavorecidoDocumento { get; set; }
        public int FavorecidoCodigoBanco { get; set; }
        public string FavorecidoNomeBanco { get; set; }
        public int FavorecidoAgenciaBanco { get; set; }
        public int FavorecidoCedente { get; set; }
        public int Valor { get; set; }
        public string Canal { get; set; }
        public int ClienteId { get; set; }
        public int ContaBancariaId { get; set; }
        public DateTime EfetuadoEm { get; set; }
    }
}
