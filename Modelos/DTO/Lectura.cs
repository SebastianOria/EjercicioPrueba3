﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
   public class Lectura
        {
            private string idmedidor;
            private DateTime fecha;
            private string consumo;


            public string Idmedidor { get => idmedidor; set => idmedidor = value; }
            public DateTime Fecha { get => fecha; set => fecha = value; }
            public string Consumo { get => consumo; set => consumo = value; }


            public override string ToString()
            {
                return idmedidor + " " + fecha + " " + consumo;
            }


        }
    }

