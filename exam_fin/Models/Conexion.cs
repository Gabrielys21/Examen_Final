using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_fin.Models
{
    internal class Conexion
    {
        //Conexion directa con la base de datos
        string connectionString = "server=localhost;Database=exam;Uid=root;Pwd=pasword";
        MySqlConnection connection;


        //Constructor
        public Conexion()
        {
            connection = new MySqlConnection(connectionString);
           
        }
        //Metodo para probar conexion entre la base de datos y la clase Conexion
        public bool PruebaConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    MessageBox.Show("Simoncho 👍👍👍");
                    connection.Open();
                    return true;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se puede compae 😵‍💫😵‍💫");
                    return false;
                }
            }

        }
        //Funcion para insertar la consulta de los porductos en la base de datos
        public void Insertar(P_Articulos Ar)
        {
            try
            {
                string query = "INSERT INTO productos_ (Descripcion, Precio_Costo, Precio_Venta, Cantidad, Fecha_Ingreso, Distribuidor) VALUES (@Descripcion, @Precio_Costo, @Precio_Venta, @Cantidad, @Fecha_Ingreso, @Distribuidor)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //cmd.Parameters.AddWithValue("@Codigo", Ar.Codigo);
                cmd.Parameters.AddWithValue("@Descripcion", Ar.Descripcion);
                cmd.Parameters.AddWithValue("@Precio_Costo", Ar.PrecioCosto);
                cmd.Parameters.AddWithValue("@Precio_Venta", Ar.PrecioVenta);
                cmd.Parameters.AddWithValue("@Cantidad", Ar.Cantidad);
                cmd.Parameters.AddWithValue("@Fecha_Ingreso", Ar.FechaIngreso);
                cmd.Parameters.AddWithValue("@Distribuidor", Ar.Distribuidor);

                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro realizado exitosamente👍👍");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: 😵‍💫😵‍💫" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        //Funcion para insertar una consulta para modificar o actualizar los articulos por el codigo (PK)
        public void Modificar(P_Articulos Ar)
        {
            try
            {
                string query = "UPDATE productos_ SET Descripcion = @Descripcion, Precio_Costo = @Precio_Costo, Precio_Venta = @Precio_Venta, Cantidad = @Cantidad, Distribuidor = @Distribuidor WHERE Codigo = @Codigo";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Codigo", Ar.Codigo);
                cmd.Parameters.AddWithValue("@Descripcion", Ar.Descripcion);
                cmd.Parameters.AddWithValue("@Precio_Costo", Ar.PrecioCosto);
                cmd.Parameters.AddWithValue("@Precio_Venta", Ar.PrecioVenta);
                cmd.Parameters.AddWithValue("@Cantidad", Ar.Cantidad);
                cmd.Parameters.AddWithValue("@Distribuidor", Ar.Distribuidor);

                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Modificacion realizada exitosamente👍👍");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: 😵‍💫😵‍💫" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        //Funcion para insertar la consuta para eliminar el producto que el usuario desee mediante su codigo
        public void Eliminar(int codigoP)
        {
                
                    string query = "DELETE FROM productos_ WHERE Codigo=@Codigo";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Codigo", codigoP);
                try { 
                connection.Open();
                int rowsAfected = cmd.ExecuteNonQuery();
                if(rowsAfected > 0)
                {
                    MessageBox.Show("Registro eliminado exitosamente 👍👍👍");
                }
                else
                {
                    MessageBox.Show("No se encontro el registro ingresado..😒😒😒");
                }
                }catch(Exception ex)
                {
                MessageBox.Show("Error " + ex.Message);
                }
                finally
                {
                connection.Close();
                }
        }
        //Funcion que inserta la consulta para cargar los datos de la base de datos y estos mostrarlos en el DataGriewView
        public DataTable Buscar(int codigo)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM productos_ WHERE Codigo = @Codigo";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                connection.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el registro 😵‍💫😵‍💫" + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
        //Funcion que sirve para conectar la base de datos exterior con el DataGriewView, seria como insertar la consulta SELECT * FROM productos_
        public DataTable MostrarTabla()
        {

            DataTable inventario = new DataTable();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM productos_";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(inventario);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones: muestra un mensaje de error o realiza otras acciones según sea necesario
                Console.WriteLine("Error al intentar mostrar la tabla: " + ex.Message);
            }

            return inventario;
        }




    }
}
