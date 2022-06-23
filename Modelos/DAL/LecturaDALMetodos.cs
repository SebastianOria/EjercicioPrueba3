using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.DAL
{
    public class LecturaDALMetodos : ILecturaDAL
    {


        private static List<Lectura> lecturas = new List<Lectura>();
        private LecturaDALMetodos() { }

        private static LecturaDALMetodos instancia;
        public static ILecturaDAL GetInstancia()
        {
            if (instancia == null)
            {

                instancia = new LecturaDALMetodos();


            }
            return instancia;
            

        }

        public List<Lectura> ObtenerLecturas()
        {
            return lecturas;

        }
        public void Eliminar(string idmedidor)
        {
            Lectura eliminando = lecturas.Find(c => c.Idmedidor == idmedidor);
            lecturas.Remove(eliminando);

        }

        public void AgregarLectura(Lectura lectura)
        {
            lecturas.Add(lectura);
        }

        public List<Lectura> Filtrar(string nivel)
        {
            return lecturas.FindAll(c => c.Idmedidor == nivel);
        }




    }
    }
