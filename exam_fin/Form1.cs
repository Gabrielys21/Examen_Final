using exam_fin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_fin
{
    public partial class FormUsuario : Form
    {
       
        Conexion con = new Conexion();
        
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void textBoxPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonIngreso_Click(object sender, EventArgs e)
        {
            Form lib = new BD_Libreria();
            string Usr = textBoxUsr.Text;
            string Pwd = textBoxPwd.Text;
            try
            {
                if (Usr == "Chava" && Pwd == "1234")
                {
                    MessageBox.Show("Bienvenido " + Usr + " 👍👍👍 ");
                    lib.Show();
                    textBoxUsr.Clear();
                    textBoxPwd.Clear();
                }
                else
                {
                    MessageBox.Show("Usuario o Contrasenia incorrecta...😵‍💫😵‍💫");
                    textBoxUsr.Clear();
                    textBoxPwd.Clear();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error... Datos invalidos");
            }
            //Conexion conec = new Conexion();
            //conec.PruebaConexion();
            //conec.Insertar(producto);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
