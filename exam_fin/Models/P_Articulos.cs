using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace exam_fin.Models
{
    public class P_Articulos
    {
        public DateTime FechaIngreso = DateTime.Now;   
        public int Codigo {get;set;}
        public string Descripcion { get; set; }
        public float PrecioCosto { get; set; }
        public float PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public string Distribuidor { get; set; }

    }
}
