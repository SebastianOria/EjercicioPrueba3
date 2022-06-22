using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.DAL
{
    public interface ILecturaDAL
    {
        List<Lectura> Filtrar(string nivel);
        void AgregarLectura(Lectura lectura);

            List<Lectura> ObtenerLecturas();

        void Eliminar(string idmedidor);

         
    }
}
