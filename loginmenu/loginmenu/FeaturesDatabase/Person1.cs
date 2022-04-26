using SQLite;
using System.Collections.Generic;
using System.Text;

namespace loginmenu.FeaturesDatabase
{
   public class Person1
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
