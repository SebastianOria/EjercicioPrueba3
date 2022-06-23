using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Medidor
    {
        private string id;
        private int nivel;

        public string NivelTxt
        {
            get
            {
                string nivelTxt = "";
                switch (nivel)
                {
                    case 1:
                        nivelTxt = "Agua";
                        break;
                    case 2:
                        nivelTxt = "Luz";
                        break;
                   
                }
                return nivelTxt;
            }
        }




        public string Id { get => id; set => id = value; }
        public int Nivel { get => nivel; set => nivel = value; }
       
        public override string ToString()
        {
            return id + " " + nivel;
        }


    }
}
