using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TP_Carrito_Fernandez
{
    public partial class productos : System.Web.UI.Page
    {
        public List<Producto> lista { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            cargarLista();
            Session.Add("lista", lista);
        }

        public void cargarLista()
        {
            ProductoNegocio negocio = new ProductoNegocio();

            lista = negocio.Listar(); 
        }
    }
}