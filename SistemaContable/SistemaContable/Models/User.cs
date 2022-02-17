using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SistemaContable.Models
{
    public class User
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public double? Ahorro { get; set; }
        public double? Sueldo { get; set; }
        public double? Gasto { get; set; }
        public string DescGasto { get; set; }
    }
}
