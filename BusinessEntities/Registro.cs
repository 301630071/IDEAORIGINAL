﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Registro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public TimeSpan FechayHora { get; set; }
        public int IdCampus { get; set; }

    }
}
