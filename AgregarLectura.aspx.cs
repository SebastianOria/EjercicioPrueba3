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
    public partial class AgregarLectura : System.Web.UI.Page
    {
        private static IMedidorDAL medidorDAL = MedidorDALMetodos.GetInstancia();
        private static ILecturaDAL lecturaDAL = LecturaDALMetodos.GetInstancia();

        /// <summary>
        /// Este metodo se ejecuta 
        /// - Cuando es una peticion GET (!PostBack)
        /// - cunado es una peticion POST (PostBack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {


            //1. Obtener los datos del formulario
            string idMedidor = this.idmedidor.Text.Trim(); 
            string fecha  = this.fecha.Text.Trim();
            string hora =  this.hora.Text.Trim();
            string minutos = this.minutos.Text.Trim();
            string valorConsum = this.valorConsum.Text.Trim();

            string horas = hora + ":" + minutos; 

            string fecha2 = fecha + " " + horas;

            //2. construir el objeto de tipo cliente

            Lectura lectura = new Lectura()
            {
                Idmedidor = idMedidor,
                Fecha = (DateTime)Convert.ChangeType(fecha2, typeof(DateTime)),
                Consumo = valorConsum

            };
            //3. Llamar al DAL
            lecturaDAL.AgregarLectura(lectura);
            //4. Mostrar mensajae de exito
            this.mensajeLbl.Text = "Lectura Agregada Exitosamente";
            Response.Redirect("VerLectura.aspx");

        }
    }
}
