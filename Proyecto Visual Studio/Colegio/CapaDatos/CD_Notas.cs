using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Notas
    {
        public int Registrar(Nota objNota, out string mensaje)
        {
            int codigoNota = 0;
            mensaje = string.Empty;
            SqlConnection conexion = null;
            try
            {
                using (conexion = new SqlConnection(Conexion.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRAR_NOTAS", conexion);
                    cmd.Parameters.AddWithValue("nota", objNota.nota);
                    cmd.Parameters.AddWithValue("codigo_alumno", objNota.codigoAlumno);
                    cmd.Parameters.AddWithValue("codigo_curso", objNota.codigoCurso);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 250).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    codigoNota = Convert.ToInt32(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                codigoNota = 0;
                mensaje = ex.Message;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }

            return codigoNota;
        }
    }
}
