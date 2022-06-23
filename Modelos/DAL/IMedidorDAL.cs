﻿using System;
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

        void Eliminar(string id);
        List<Medidor> Filtrar(int nivel);
    }
}
