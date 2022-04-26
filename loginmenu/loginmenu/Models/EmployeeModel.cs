 using SQLite;
using System;
using System.Collections.Generic;
using System.Text;


namespace loginmenu.Models
{
    public class EmployeeModel

    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string Address { get; set; }


    }
}
