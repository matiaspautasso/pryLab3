using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // using para sqlsever 
using System.Windows.Forms;

namespace pryLab3.Clases
{
    internal class ClsConexion
    {
        string cadena;
        public ClsConexion() { cadena = "Data Source=MATUTE_NOTEBOOK;Integrated Security=True"; }

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
        public bool VerificarUsuario(string usuario, string contrasena, out string permiso)
        {
            permiso = string.Empty; // Inicializamos la variable de salida

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();

                    // Consulta para verificar el usuario y obtener el permiso
                    string query = "SELECT permiso FROM Usuarios WHERE Nombre = @Nombre AND Contrasena = @Contrasena";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        // Asignamos los valores de los parámetros a la consulta
                        comando.Parameters.AddWithValue("@Nombre", usuario);
                        comando.Parameters.AddWithValue("@Contrasena", contrasena);

                        // Ejecutamos la consulta
                        var resultado = comando.ExecuteScalar();

                        // Verificamos si se obtuvo un resultado
                        if (resultado != null)
                        {
                            // Asignamos el permiso a la variable de salida y retornamos true
                            permiso = resultado.ToString();
                            return true; // Usuario validado con éxito
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos");
                            return false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al intentar conectar con la base de datos: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
                return false;
            }
        }
    }
}
