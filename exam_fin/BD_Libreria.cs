using exam_fin.Models;
using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_fin
{
    public partial class BD_Libreria : Form
    {//Instancias de las clases P_Articulos y Conexion para poder usarlas en esta nueva clase BD_Libreria
        P_Articulos Ar = new P_Articulos();
        Conexion tab = new Conexion();
        public BD_Libreria()
        {
            InitializeComponent();
            
        }

        
       
        private void BD_Libreria_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Boton Agregar Producto
                //Ar.Codigo = int.Parse(textBoxCod.Text);
                Ar.Descripcion = textBoxDescrip.Text;
                Ar.PrecioCosto = float.Parse(textBoxPrecioCost.Text);
                Ar.PrecioVenta = float.Parse(textBoxPrecioVen.Text);
                Ar.FechaIngreso = DateTime.Parse(textBoxFecha.Text);
                Ar.Cantidad = int.Parse(textBoxCant.Text);
                Ar.Distribuidor = textBoxDist.Text;
                tab.Insertar(Ar);
                textBoxCant.Clear();
                textBoxFecha.Clear();
                textBoxDescrip.Clear();
                textBoxPrecioCost.Clear();
                textBoxPrecioVen.Clear();
                textBoxDist.Clear();
            }catch (Exception ex)
            {
                MessageBox.Show("Perame compae, ha ocurrido un error 😵‍💫😵‍💫😵‍💫 "+ ex.Message );
                textBoxCant.Clear();
                textBoxFecha.Clear();
                textBoxDescrip.Clear();
                textBoxPrecioCost.Clear();
                textBoxPrecioVen.Clear();
                textBoxDist.Clear();
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el valor del TextBox
                string codigoTexto = textBoxBusq.Text;

                // Convertir el valor a entero
                int codigo;
                if (int.TryParse(codigoTexto, out codigo))
                {
                    // Llamar a la función Buscar
                    DataTable dt = tab.Buscar(codigo);

                    if (dt.Rows.Count > 0)
                    {
                        // Si se encontró al menos un registro, mostrar los datos en el DataGridView
                        DTabla.DataSource = dt;
                        textBoxBusq.Clear();
                    }
                    else
                    {
                        // Si no se encontró ningún registro, limpiar el DataGridView
                        DTabla.DataSource = null;
                        MessageBox.Show("No se encontró ningún registro con ese código");
                        textBoxBusq.Clear();
                    }
                }
                else
                {
                    // Si el valor del TextBox no es un número entero válido
                    MessageBox.Show("Ingrese un código numérico válido");
                    textBoxBusq.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Has echo algo mal como siempre, hay un error... " + ex.Message);
            }

        }

        private void buttoMosT_Click(object sender, EventArgs e)
        {
            try
            {
                // OBTIENE LOS DATOS DE LA TABLA DE INVENTARIO DESDE LA BASE DE DATOS
                DataTable dt = tab.MostrarTabla();

                // ASIGNA LOS DATOS AL DATAGRIDVIEW
                DTabla.DataSource = dt;
            }
            catch (Exception ex)
            {
                // MUESTRA UN MENSAJE DE ERROR SI OCURRE UNA EXCEPCIÓN AL MOSTRAR LA TABLA
                MessageBox.Show("Error al mostrar la tabla: " + ex.Message);
            }

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Ar.Codigo = int.Parse(textBoxBusq.Text);
                Ar.Descripcion = textBoxDescrip.Text;
                Ar.PrecioCosto = float.Parse(textBoxPrecioCost.Text);
                Ar.PrecioVenta = float.Parse(textBoxPrecioVen.Text);
                Ar.Cantidad = int.Parse(textBoxCant.Text);
                Ar.Distribuidor = textBoxDist.Text;
                tab.Modificar(Ar);
                textBoxBusq.Clear();
                textBoxCant.Clear();
                textBoxDescrip.Clear();
                textBoxPrecioCost.Clear();
                textBoxPrecioVen.Clear();
                textBoxDist.Clear();
            }catch(Exception ex)
            {
                MessageBox.Show("Has echo algo mal como siempre, hay un error... " + ex.Message);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigoTexto = textBoxElimCod.Text;

                // Convertir el código a entero
                int codigoProducto;
                if (int.TryParse(codigoTexto, out codigoProducto))
                {
                    // Llamar a la función Eliminar
                    tab.Eliminar(codigoProducto);
                    DataTable dt = tab.MostrarTabla();
                    DTabla.DataSource = dt;
                    textBoxElimCod.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un código numérico válido.");
                    textBoxElimCod.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Has echo algo mal como siempre, hay un error... " + ex.Message);
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo del sistema...");
            this.Close();
        }

        private void buttonPruebaCon_Click(object sender, EventArgs e)
        {
            Conexion conec = new Conexion();
            conec.PruebaConexion();
        }
    }
}
