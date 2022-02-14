using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SistemaContable.Models;

namespace SistemaContable.Data
{
    public class DatabaseQuery
    {
        readonly SQLiteAsyncConnection _database;

        public DatabaseQuery(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<User>().Wait();
        }

        public Task<List<User>> GetUsers()
        {
            return _database.QueryAsync<User>("Select * From User");
        }

        public Task<List<User>>  getUserLogin(string email, string contraseña)
        {
            return _database.QueryAsync<User>("SELECT * FROM User WHERE Email = '" + email + "' AND Contraseña = '" + contraseña + "'");
        }

        public Task<int> SaveUserAsync(User user)
        {
            if (user.Id != 0)
            {
                return _database.UpdateAsync(user);
            }
            else
            {
                return _database.InsertAsync(user);
            }
        }

        public Task<int> DeleteUserAsync(User user)
        {
            return _database.DeleteAsync(user);
        }
    }
}
