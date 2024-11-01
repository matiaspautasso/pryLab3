using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLab3.Clases
{
    internal class clsCaja
    {
        public clsCaja() { cadena = "Data Source=MATUTE_NOTEBOOK;Integrated Security=True"; }

        public void Insertar(string nombreTabla, TextBox txtNombre)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = $"INSERT INTO {nombreTabla} (Nombre) VALUES (@Nombre)";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro insertado con éxito");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de inserción: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }

        public void Eliminar(string nombreTabla, TextBox txtId)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = $"DELETE FROM {nombreTabla} WHERE Id = @Id";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Id", txtId.Text);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro eliminado con éxito");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de eliminación: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }

        public void Actualizar(string nombreTabla, TextBox txtId, TextBox txtNombre)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = $"UPDATE {nombreTabla} SET Nombre = @Nombre WHERE Id = @Id";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Id", txtId.Text);
                    comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro actualizado con éxito");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de actualización: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }

        public void MostrarGrilla(string nombreTabla, DataGridView dgv)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = $"SELECT * FROM {nombreTabla}";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgv.DataSource = tabla;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de consulta: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }
    }
}
