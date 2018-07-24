using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Proyecto.Model
{
    public class Inventario
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Producto { get; set; }
        public string Cantidad { get; set; }
        public string Medida { get; set; }
    }
}
