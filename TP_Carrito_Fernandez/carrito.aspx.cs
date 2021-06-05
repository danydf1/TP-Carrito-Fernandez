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

    public partial class carrito : System.Web.UI.Page
    {
        public Carrito lista { get; set; }

        int contador;


        protected void Page_Load(object sender, EventArgs e)
        {
            ItemCarrito item = new ItemCarrito();  
          //  int id = int.Parse(Request.QueryString["id"]);
            List<Producto> lista = (List<Producto>)Session["lista"];
            
            Producto seleccionado = new Producto();

            //item.producto = lista.Find(x => x.Id == id);

        }

    }
}