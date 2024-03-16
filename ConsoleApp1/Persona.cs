using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }

        public string GetNombreCompleto()
        { 
            return Nombres + " " + Apellidos;
        }

        public bool EsMayorEdad()
        {
            return Edad > 18;
        }


    }
}
