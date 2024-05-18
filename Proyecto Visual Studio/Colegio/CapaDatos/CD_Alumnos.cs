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
    public class CD_Alumnos
    {
        public DataTable Listar(out string mensaje)
        {
            DataTable dtAlumnos = new DataTable();
            mensaje = string.Empty;
            SqlConnection conexion = null;

            try
            {
                using (conexion = new SqlConnection(Conexion.cadenaConexion))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_LISTAR_ALUMNOS", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        conexion.Open();
                        da.Fill(dtAlumnos);
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

            return dtAlumnos;
        }
        public int Registrar(Alumno objAlumno, out string mensaje)
        {
            int codigoAlumno = 0;
            mensaje = string.Empty;
            SqlConnection conexion = null;
            try
            {
                using (conexion = new SqlConnection(Conexion.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRAR_ALUMNOS", conexion);
                    cmd.Parameters.AddWithValue("nombres", objAlumno.nombres);
                    cmd.Parameters.AddWithValue("apellidos", objAlumno.apellidos);
                    cmd.Parameters.AddWithValue("dni", objAlumno.dni);
                    cmd.Parameters.AddWithValue("fecha_nacimiento", objAlumno.fechaNacimiento);
                    cmd.Parameters.AddWithValue("direccion", objAlumno.direccion);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar,250).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    codigoAlumno = Convert.ToInt32(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch(Exception ex)
            {
                codigoAlumno = 0;
                mensaje = ex.Message;
            }
            finally
            {
                if(conexion!=null)
                {
                    conexion.Close();
                }
            }

            return codigoAlumno;
        }

        public int Editar(Alumno objAlumno, out string mensaje)
        {
            int resultado = 0;
            mensaje = string.Empty;
            SqlConnection conexion = null;
            try
            {
                using (conexion = new SqlConnection(Conexion.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITAR_ALUMNOS", conexion);
                    cmd.Parameters.AddWithValue("codigo", objAlumno.codigo);
                    cmd.Parameters.AddWithValue("nombres", objAlumno.nombres);
                    cmd.Parameters.AddWithValue("apellidos", objAlumno.apellidos);
                    cmd.Parameters.AddWithValue("dni", objAlumno.dni);
                    cmd.Parameters.AddWithValue("fecha_nacimiento", objAlumno.fechaNacimiento);
                    cmd.Parameters.AddWithValue("direccion", objAlumno.direccion);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 250).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToInt32(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                resultado = 0;
                mensaje = ex.Message;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }

            return resultado;
        }


    }
}
