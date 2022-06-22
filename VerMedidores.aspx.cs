
using Modelos;
using Modelos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioPrueba3
{
    public partial class VerMedidores : System.Web.UI.Page
    {
        private static IMedidorDAL medidorDAL = MedidorDALMetodos.GetInstancia();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Medidor> medidor = medidorDAL.ObtenerMedidores();

                this.grillaMedidores.DataSource = medidor;
                this.grillaMedidores.DataBind();
            }

        }

        protected void grillaMedidores_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                //significa que el usuario apreto el boton eliminar
                //por tanto, tengo que eliminar el cliente
                string id = Convert.ToString(e.CommandArgument);
                medidorDAL.Eliminar(id);

            }
        }
    }
}
