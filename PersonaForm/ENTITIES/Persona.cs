using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaForm.ENTITIES
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Sueldo { get; set; }
        public DateTime Fecha { get; set; }

        public Persona()
        {
            Id = 0;
            Nombre = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
            Sueldo = string.Empty;
            Fecha = DateTime.Now;
        }
    }

}
