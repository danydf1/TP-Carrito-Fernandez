using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ItemCarrito 
    {
        public Producto producto { get; set; }
        public int cantidad { get; set; }
        public decimal subTotal { get; set; }
    }
}
