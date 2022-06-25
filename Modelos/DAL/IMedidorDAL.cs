using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.DAL
{
    public interface IMedidorDAL
    {
        List<Medidor> ObtenerMedidores();
        void AgregarMedidor(Medidor medidor);

        
        List<Medidor> Filtrar(int nivel);
        List<Medidor> Buscar(string id);

    }
}
