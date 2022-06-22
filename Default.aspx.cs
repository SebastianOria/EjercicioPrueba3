
using Modelos;
using Modelos.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioPrueba3
{
    public partial class Default : Page
    {
        //Gabriel Escriba - Sebastian Oria//
        private static IMedidorDAL medidorDAL = MedidorDALMetodos.GetInstancia();
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
            string id = this.nombreTxt.Text.Trim();

            //2. construir el objeto de tipo cliente

            Medidor medidor = new Medidor()
            {
                Id = id,

            };
            //3. Llamar al DAL
            medidorDAL.AgregarMedidor(medidor);
            //4. Mostrar mensajae de exito
            this.mensajeLbl.Text = "Medidor Agregar Exitosamente";
            Response.Redirect("VerMedidores.aspx");

        }
    }
}   