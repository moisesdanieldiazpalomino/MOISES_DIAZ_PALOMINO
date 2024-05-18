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
    public class CN_Nota
    {
        private CD_Notas objCapaNota = new CD_Notas();
        public int Registar(Nota objNota, out string mensaje)
        {
            mensaje = string.Empty;
            int resultado = 0;

            resultado = objCapaNota.Registrar(objNota, out mensaje);

            return resultado;

        }
    }
}
