using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stefanini.Domain.Entities
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string NomeProduto { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Valor { get; set; }

        //public ICollection<ItensPedido> ItensPedidos { get; set; }
    }
}
