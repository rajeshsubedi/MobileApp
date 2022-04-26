using SQLite;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace loginmenu.FeaturesDatabase
{
   public class Database1
    {
        readonly SQLiteAsyncConnection _database1;

        public Database1(string dbPath)
        {
            _database1 = new SQLiteAsyncConnection(dbPath);
            _database1.CreateTableAsync<Person1>().Wait();
        }

        public Task<List<Person1>> GetPeopleAsync()
        {
            return _database1.Table<Person1>().ToListAsync();
        }

        public Task<int> SavePerson1Async(Person1 person1)
        {
            return _database1.InsertAsync(person1);
        }

    }
}
