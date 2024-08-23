using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stefanini.Domain.Entities
{
        public class ItensPedido
        {
            [Key]
            public int Id { get; set; }

            [ForeignKey("Pedido")]
            public int IdPedido { get; set; }

            [ForeignKey("Produto")]
            public int IdProduto { get; set; }

            public int Quantidade { get; set; }
            
            public Pedido Pedido { get; set; }
        }
}
