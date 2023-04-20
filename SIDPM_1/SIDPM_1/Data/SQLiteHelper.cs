using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SIDPM_1.Models;
using Xamarin.Essentials;
using System.Threading.Tasks;

namespace SIDPM_1.Data
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;
        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Registro>().Wait();
        }

        public Task<int> saveRegistroAsync(Registro registro)
        {
            if (registro.Id == 0)
            {
                return db.InsertAsync(registro);
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Recuperar datos de registro
        /// </summary>
        /// <returns></returns>
        public Task<List<Registro>> GetRegistroAsync()
        {
            return db.Table<Registro>().ToListAsync();
        }
        /// <summary>
        /// Recupera registro por ID
        /// </summary>
        /// <param name="Id">Id del usuario que se requiere</param>
        /// <returns></returns>
        public Task<Registro> GetRegistroByIdAsync(int Id)
        {
            return db.Table<Registro>().Where(a => a.Id == Id).FirstOrDefaultAsync();
        }

        public Task validarLogin(string username, string password)
        {
            var user = db.Table<Registro>().FirstOrDefaultAsync(u => u.UserName == username && u.Password == password);
            return user;
        }
    }
}

