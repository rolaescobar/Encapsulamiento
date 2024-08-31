using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class Persona
    {

        private string? nombre;
        private int edad = 35;

        public string GetNombre()
        { 
            
        
           return nombre ?? string.Empty;
        
        }

        public void SetNombre(string nuevoNombre)
        { 
            nombre = nuevoNombre;
        
        }

        public int GetEdad()
        {
            return edad;
        }

        public void Cumpleanos()
        {

            edad++;
        }


    }
}
