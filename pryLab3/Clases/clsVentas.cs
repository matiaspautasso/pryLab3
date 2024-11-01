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
    internal class clsVentas
    {
        string cadena;
        public clsVentas() { cadena = "Data Source=MATUTE_NOTEBOOK;Integrated Security=True"; }

        public void MostrarGrillaConDescuento(string nombreTabla, DataGridView dgv, int codigo, int descuento,string tipoOperacion)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = $"SELECT * FROM {nombreTabla} WHERE id = @codigo";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@codigo", codigo);

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    if (tabla.Rows.Count > 0)
                    {
                        DataRow fila = tabla.Rows[0];
                        decimal precioConDescuento = (decimal)fila["precio"] * (1 - (descuento / 100m));

                        dgv.Rows.Add(
                            fila["id"],
                            fila["descripcion"],
                            fila["cantidad"],
                            fila["precio"],
                            descuento,
                            DateTime.Now,
                            tipoOperacion,
                            precioConDescuento
                        );
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el artículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
