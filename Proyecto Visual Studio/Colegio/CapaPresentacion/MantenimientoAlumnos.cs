using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class MantenimientoAlumnos : Form
    {
        int resultado = -1;
        string mensaje = string.Empty;
        string accion = string.Empty;
        string tituloAccion = string.Empty;
        string mensajeAccion = string.Empty;
        DataTable dtListadoNotas = null;
        public MantenimientoAlumnos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(!ValidarDatos())
            {
                MessageBox.Show("Debe de completar los datos solicitados", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Alumno objAlumno = new Alumno();
                CN_Alumno objNegocio = new CN_Alumno();

               
                objAlumno.nombres = txtNombres.Text;
                objAlumno.apellidos = txtApellidos.Text;
                objAlumno.dni = txtDNI.Text;
                objAlumno.fechaNacimiento = dtpFechaNacimiento.Value;
                objAlumno.direccion = txtDireccion.Text;

                if(accion=="nuevo")
                {
                    tituloAccion = "Nuevo Registro";
                    mensajeAccion = "Alumnos registrado exitosament";

                    resultado = objNegocio.Registar(objAlumno, out mensaje);
                }
                else if(accion=="editar")
                {
                    objAlumno.codigo = Convert.ToInt32(txtCodigo.Text);
                    tituloAccion = "Edición de  Registro";
                    mensajeAccion = "Alumnos actualizado exitosament";
                    resultado = objNegocio.Editar(objAlumno, out mensaje);
                }


                if(!string.IsNullOrEmpty(mensaje))
                {
                    MessageBox.Show(mensaje, "Error Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(mensajeAccion,tituloAccion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    ControlesIniciales();

                }

                ListarAlumnos();
            }
        }

        public bool ValidarDatos()
        {
            bool resultado = true;

            if(string.IsNullOrEmpty( txtNombres.Text) ||
                string.IsNullOrEmpty(txtApellidos.Text) ||
                string.IsNullOrEmpty(txtDNI.Text) ||
                string.IsNullOrEmpty(txtDireccion.Text) ||
                txtDNI.TextLength!=8||
                dtpFechaNacimiento.Value==null)
            {
                resultado = false;
            }

            return resultado;

        }
        public void LimpiarControles()
        {
            txtCodigo.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtDNI.Text = string.Empty;
            dtpFechaNacimiento.Value = DateTime.Now;
            txtDireccion.Text = string.Empty;
            txtNombres.Focus();

            
        }

        public void ListarAlumnos()
        {
            CN_Alumno objNegocio = new CN_Alumno();

            DataTable dtAlumnos = null;

            dtAlumnos = objNegocio.Listar(out mensaje);
            dgvAlumnos.DataSource = dtAlumnos;


        }

        public void ControlesIniciales()
        {
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
           
            btnAgregarNota.Enabled = false;
            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
            txtDNI.Enabled = false;
            txtDireccion.Enabled = false;
            dtpFechaNacimiento.Enabled = false;
        }

        public void HabilitarControles()
        {
            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
            txtDNI.Enabled = true;
            txtDireccion.Enabled = true;
            dtpFechaNacimiento.Enabled = true;
        }

        public void CrearTablaNotas()
        {
            dtListadoNotas = new DataTable();
            dtListadoNotas.Columns.Add("codigo_curso", typeof(int));
            dtListadoNotas.Columns.Add("codigo_alumno", typeof(int));
            dtListadoNotas.Columns.Add("nota", typeof(int));
        }


        public bool GuardarNota()
        {

            CN_Nota objNegocioNota = new CN_Nota();
            Nota objNota = new Nota();
            int resultado = 0;

            try
            {
                objNota.codigoAlumno = Convert.ToInt32(txtDatosCodigoAlumno.Text);
                objNota.codigoCurso = Convert.ToInt32(cboCurso.SelectedValue);
                objNota.nota = Convert.ToInt32(txtNota.Text);
                resultado=objNegocioNota.Registar(objNota, out mensaje);
                if(!string.IsNullOrEmpty(mensaje) || resultado==1)
                {
                    return false;
                    MessageBox.Show(mensaje, "Error Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    MessageBox.Show("Nota Registrado con éxito", "Registro Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            

        }
        public bool AgregarNotaListado(int codigoCurso, int codigoAlumno, int nota)
        {

            int cantidadNotas = 0;
            int totalSuma = 0;
            double promedio = 0;

            if(!GuardarNota())
            {
                return false;
            }
            
            DataRow fila = dtListadoNotas.NewRow();



            try
            {
                fila["codigo_curso"] = codigoCurso;
                fila["codigo_alumno"] = codigoAlumno;
                fila["nota"] = nota;

                dtListadoNotas.Rows.Add(fila);

                dgvListadoNotas.DataSource = dtListadoNotas;

                cantidadNotas = dgvListadoNotas.Rows.Count;
                if (cantidadNotas >= 4)
                {
                    for (int i = 0; i < cantidadNotas; i++)
                    {
                        totalSuma += Convert.ToInt32(dgvListadoNotas.Rows[i].Cells["nota"].Value.ToString());
                    }
                    promedio = totalSuma / cantidadNotas;
                    txtNotaPromedio.Text = promedio.ToString();
                }
                txtCantidadNotas.Text = cantidadNotas.ToString();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

        public bool ValidarNota(string valor)
        {
            int nuevoValor=0;

            if(!int.TryParse(valor, out nuevoValor))
            {
                return false;
            }
            else if(nuevoValor<0 || nuevoValor>20)
            {
                return false;
            }
            return true;
        }



        private void MantenimientoAlumnos_Load(object sender, EventArgs e)
        {
            ControlesIniciales();
            ListarAlumnos();

        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            btnAgregarNota.Enabled = true;
            txtCodigo.Text = dgvAlumnos.CurrentRow.Cells[0].Value.ToString();
            txtNombres.Text = dgvAlumnos.CurrentRow.Cells[1].Value.ToString();
            txtApellidos.Text= dgvAlumnos.CurrentRow.Cells[2].Value.ToString();
            txtDNI.Text = dgvAlumnos.CurrentRow.Cells[3].Value.ToString();
            dtpFechaNacimiento.Value = Convert.ToDateTime(dgvAlumnos.CurrentRow.Cells[4].Value.ToString());
            txtDireccion.Text= dgvAlumnos.CurrentRow.Cells[5].Value.ToString();

            if(!string.IsNullOrEmpty(txtCodigo.Text))
            {
                btnEditar.Enabled = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            accion = "nuevo";
            HabilitarControles();
            LimpiarControles();
            txtNombres.Focus();
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            
            btnAgregarNota.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            
            ControlesIniciales();
            LimpiarControles();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            accion = "editar";
            HabilitarControles();
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
           
            btnAgregarNota.Enabled = false;
        }
        public void LimpiarDatosNotas()
        {
            txtCantidadNotas.Text = string.Empty;
            txtNotaPromedio.Text = string.Empty;
            dgvListadoNotas.DataSource = null;
        }

        private void btnAgregarNota_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty( txtCodigo.Text))
            {
                MessageBox.Show("Debe de seleccionar un Alumno");
            }
            else
            {
                tabControl.SelectedIndex = 1;
                txtDatosCodigoAlumno.Text = txtCodigo.Text;
                txtDatosAlumno.Text = txtApellidos.Text.ToUpper() + " "+ txtNombres.Text.ToUpper() ;
            }
            
        }
        
        private void btnNuevaNota_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDatosCodigoAlumno.Text) || string.IsNullOrEmpty(txtDatosAlumno.Text))
            {
                MessageBox.Show("Debe de seleccionar un Alumno", "Registro de Notas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl.SelectedIndex = 0;
            }
            else
            {
                CrearTablaNotas();
                LimpiarDatosNotas();
                gbCurso.Enabled = true;
                
                CN_Curso objCurso = new CN_Curso();

                DataTable dtCursos = null;

                dtCursos = objCurso.Listar(out mensaje);
                if(!string.IsNullOrEmpty(mensaje))
                {
                    MessageBox.Show(mensaje, "Registro de Notas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dtCursos==null)
                {
                    MessageBox.Show("No hay Cursos para Listar", "Registro de Notas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cboCurso.DataSource = dtCursos;
                cboCurso.DisplayMember = "descripcion";
                cboCurso.ValueMember = "codigo";
                cboCurso.SelectedIndex = -1;
            }
        }

        private void btnAgregarNuevaNota_Click(object sender, EventArgs e)
        {
            if(cboCurso.SelectedIndex==-1 || string.IsNullOrEmpty(txtNota.Text))
            {
                MessageBox.Show("Curso y Nota campos obligatorios", "Registro de Notas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!ValidarNota(txtNota.Text))
            {
                MessageBox.Show("Debe de ingresar una Nota válida", "Registro de Notas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int codigoCurso = Convert.ToInt32(cboCurso.SelectedValue);
                int codigoAlumno = Convert.ToInt32(txtDatosCodigoAlumno.Text);
                int nota = Convert.ToInt32(txtNota.Text);
                if(AgregarNotaListado(codigoCurso, codigoAlumno, nota))
                {
                    txtNota.Text = string.Empty;
                    txtNota.Focus();
                }
                
            }
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(cboCurso.SelectedIndex==-1)
            {
                MessageBox.Show("Debe de seleccionar un curso", "Registro de Notas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                gbCurso.Enabled = false;
                gbNota.Enabled = true;
                txtNota.Focus();
            }
        }

        private void btnGuardarNotas_Click(object sender, EventArgs e)
        {
            
        }
    }
}
