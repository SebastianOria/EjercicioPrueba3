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
    public partial class VerLectura : System.Web.UI.Page
    {
        private static IMedidorDAL medidorDAL = MedidorDALMetodos.GetInstancia();
        private static ILecturaDAL lecturaDAL = LecturaDALMetodos.GetInstancia();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Medidor> medidor = medidorDAL.ObtenerMedidores();
                this.nivelDdl.DataSource = medidor;
                this.nivelDdl.DataTextField = "Id";
                this.nivelDdl.DataValueField = "Id";
                this.nivelDdl.DataBind();
                cargaGrilla();
            }

        }
        private void cargaGrilla()
        {
            List<Lectura> lectura = lecturaDAL.ObtenerLecturas();

            this.grillaLecturas.DataSource = lectura;
            this.grillaLecturas.DataBind();
        }
        private void cargaGrilla(List<Lectura> filtrada)
        {
            List<Lectura> lectura = lecturaDAL.ObtenerLecturas();

            this.grillaLecturas.DataSource = filtrada;
            this.grillaLecturas.DataBind();

        }

        protected void grillaLecturas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
          
        }


        protected void nivelDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.nivelDdl.SelectedItem != null)
            {
                string nivel = this.nivelDdl.SelectedItem.Value;
             
                List<Lectura> filtrada = lecturaDAL.Filtrar(nivel);
                cargaGrilla(filtrada);
            }
        }

        protected void actualizarBtn_Click(object sender, EventArgs e)
        {
            cargaGrilla();

        }



    }

}