using Stefanini.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stefanini.Domain
{
     public class PedidoDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string NomeCliente { get; set; }

        [Required]
        [StringLength(60)]
        public string EmailCliente { get; set; }

        public DateTime DataCriacao { get; set; }

        public bool Pago { get; set; }

        public ICollection<ItensPedido> ItensPedidos { get; set; }
    }
}
