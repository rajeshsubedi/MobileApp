﻿using SQLite;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace loginmenu.FeaturesDatabase
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Person>();
        }

        public Task<List<Person>> GetPeopleAsync()
        {
            return _database.Table<Person>().ToListAsync();
        }

        public Task<int> SavePersonAsync(Person person)
        {
            return _database.InsertAsync(person);
        }

        public static implicit operator Database(sqlite v)
        {
            throw new NotImplementedException();
        }
    }
}
