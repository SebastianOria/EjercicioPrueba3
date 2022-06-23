using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.DAL
{
    public class MedidorDALMetodos : IMedidorDAL
    { 
        private static List<Medidor> medidores = new List<Medidor>();
        private MedidorDALMetodos() { }

        private static MedidorDALMetodos instancia;
        public static IMedidorDAL GetInstancia()
        {
            if (instancia == null)
            {

                instancia = new MedidorDALMetodos();


            }
            return instancia;


        }

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


        public List<Medidor> Filtrar(int nivel)
        {
            return medidores.FindAll(c => c.Nivel == nivel);
        }

    }
}

