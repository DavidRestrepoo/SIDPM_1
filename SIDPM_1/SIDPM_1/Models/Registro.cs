using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SIDPM_1.Models
{
    public class Registro
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]
        public string UserName { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        [MaxLength(100)]
        public string Program { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }    

    }
}
