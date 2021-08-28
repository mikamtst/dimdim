using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DimDim.Models
{
    public class ContaBancaria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContaBancariaId { get; set; }
        public int Agencia { get; set; }
        public int Cedente { get; set; }
        public int ClienteId { get; set; }
    }
}
