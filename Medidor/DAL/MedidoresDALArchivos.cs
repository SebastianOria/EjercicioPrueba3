using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medidor.DAL
{
    public class MedidoresDALArchivos : IMedidoresDAL
    {
        private MedidoresDALArchivos()
        {

        }
        private static MedidoresDALArchivos instancia;
       
        public static IMedidoresDAL GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new MedidoresDALArchivos();
            }
            return instancia;
        }
        public List<Medidor> ObtenerMedidores()
        {
            List<Medidor> lista = new List<Medidor>();
            Medidor medidor1 = new Medidor();
            medidor1.IdMedidor = "1234";
            Medidor medidor2 = new Medidor();
            medidor2.IdMedidor = "5678";
            Medidor medidor3 = new Medidor();
            medidor3.IdMedidor = "9012";

            lista.Add(medidor1);
            lista.Add(medidor2);
            lista.Add(medidor3);

            return lista;
        }
    }
}
