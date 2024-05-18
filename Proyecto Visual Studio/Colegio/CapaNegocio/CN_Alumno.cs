using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Alumno
    {
        private CD_Alumnos objCapaAlumno = new CD_Alumnos();

        public DataTable Listar(out string mensaje)
        {

            mensaje = string.Empty;
            return objCapaAlumno.Listar(out mensaje);
        }
        public int Registar(Alumno objAlumno, out string mensaje)
        {
            mensaje = string.Empty;
            int resultado = 0;

            resultado = objCapaAlumno.Registrar(objAlumno, out mensaje);

            return resultado;

        }

        public int Editar(Alumno objAlumno, out string mensaje)
        {
            mensaje = string.Empty;
            int resultado = 0;

            resultado = objCapaAlumno.Editar(objAlumno, out mensaje);

            return resultado;

        }


    }
}
