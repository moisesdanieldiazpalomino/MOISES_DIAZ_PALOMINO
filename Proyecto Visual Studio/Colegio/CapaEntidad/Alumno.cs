﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Alumno
    {
        public int codigo { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string dni { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string direccion { get; set; }
        public string estado { get; set; }

    }
}
