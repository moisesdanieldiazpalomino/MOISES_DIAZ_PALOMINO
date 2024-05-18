using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Cursos
    {
        public DataTable Listar(out string mensaje)
        {
            DataTable dtCursos = new DataTable();
            mensaje = string.Empty;
            SqlConnection conexion = null;

            try
            {
                using (conexion = new SqlConnection(Conexion.cadenaConexion))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_LISTAR_CURSOS", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        conexion.Open();
                        da.Fill(dtCursos);
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }

            return dtCursos;
        }
    }
}
