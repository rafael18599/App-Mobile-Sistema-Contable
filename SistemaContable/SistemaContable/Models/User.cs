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
        public float Ahorro { get; set; }
        public float Sueldo { get; set; }
        public float Gasto{ get; set; }
        public string DescGasto { get; set; }
    }
}
