using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // using para sqlsever 
using System.Windows.Forms;
using System.Data;

namespace pryLab3.Clases
{
    internal class ClsUsuario
    {
        string cadena;

        public class clsUsuario
        {
            public string NombreUsuario { get; set; }
            public string Contrasena { get; set; }
            public string Permiso { get; set; }
        }

        public ClsUsuario() { cadena = "Data Source=MATUTE_NOTEBOOK;Integrated Security=True"; }

        public bool VerificarConexion()
        {
            bool result = false;

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    result = true;
                    MessageBox.Show("Conectado");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }

            return result;
        }
        public bool VerificarUsuario(string usuario, string contrasena)
        {
            bool usuarioValido = false;
            // Establecer la conexión
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
             
                conexion.Open();

                // Preparar el comando
                 SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;

                // Consulta SQL parametrizada para verificar usuario y contraseña
                comando.CommandText = "SELECT * FROM Usuarios WHERE usuario = @usuario AND contrasena = @contrasena";

                // Agregar parámetros para prevenir inyección SQL
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contrasena", contrasena);

                // Crear un DataTable para almacenar los resultados
                DataTable tabla = new DataTable();

                // Usar SqlDataAdapter para llenar el DataTable
                 SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);

                // Verificar si se encontró algún registro
                if (tabla.Rows.Count > 0)
                {
                    usuarioValido = true;

                    // Obtener información adicional del usuario si es necesario
                    int id = Convert.ToInt32(tabla.Rows[0]["id"]);
                    string permiso = tabla.Rows[0]["permiso"].ToString();

                    MessageBox.Show($"Inicio de sesión exitoso\nUsuario: {usuario}\nPermiso: {permiso}",
                        "Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de base de datos: {ex.Message}",
                    "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return usuarioValido;
        }


    }

}

