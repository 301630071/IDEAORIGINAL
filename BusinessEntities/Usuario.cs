using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Grado { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }
        public string Correo { get; set; }
        public int IdCampus { get; set; }
        public int IdCarrera { get; set; }
        public Byte Estado { get; set; }

    }
}
