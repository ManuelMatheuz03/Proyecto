using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Model
{
    public class Pedido
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Semana { get; set; }
        public string Contrato { get; set; }
    }
}
