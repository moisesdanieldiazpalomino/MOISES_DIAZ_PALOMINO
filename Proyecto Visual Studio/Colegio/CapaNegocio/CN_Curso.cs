using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Curso
    {
        private CD_Cursos objCurso = new CD_Cursos();

        public DataTable Listar(out string mensaje)
        {

            mensaje = string.Empty;
            return objCurso.Listar(out mensaje);
        }
    }
}
