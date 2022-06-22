using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DAL
{
    public class MedidorDALMetod : IMedidorDAL
    {
        private static List<Medidor> medidores = new List<Medidor>();
        private MedidorDALMetod() { }
        private static MedidorDALMetod instancia;
        public static IMedidorDAL GetInstancia()
        {
            if (instancia == null)
            {

                instancia = new MedidorDALMetod();


            }
            return instancia;


        }

        private static string url = Directory.GetCurrentDirectory();
        private static string archivo = "~MedidorApp/App_Data/Medidores.txt";

        public List<Medidor> ObtenerMedidores()
        {
            return medidores;

        }
        public void Eliminar(string id)
        {
            Medidor eliminando = medidores.Find(c => c.Id == id);
            medidores.Remove(eliminando);
        }

        public void AgregarMedidor(Medidor medidor)
        {
            medidores.Add(medidor);
        }



    }
}
