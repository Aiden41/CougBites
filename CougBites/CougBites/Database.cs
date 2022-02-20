using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CougBites.Models;
using SQLite;

namespace CougBites
{
    public class Database
    {
        public SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<FoodItem>();
        }

        public Task<List<Models.FoodItem>> GetFoodAsync()
        {
            return _database.Table<Models.FoodItem>().ToListAsync();
        }

        public Task<int> SaveFoodAsync(Models.FoodItem food)
        {
            return _database.InsertAsync(food);
        }

    }
}
