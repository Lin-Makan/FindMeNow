using FindMeNow.Models;
using FindMeNow.Repositories;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace FindMeNow
{
    public class LocationRepository : ILocationRepository
    {
        public async Task Save(Location location)
        {
            await CreateConnection();
            await connection.InsertAsync(location);
        }
        private SQLiteAsyncConnection connection;
        private async Task CreateConnection()
        {
            if (connection != null)
            {
                return;
            }
            var databasePath =
            Path.Combine(Environment.GetFolderPath
            (Environment.SpecialFolder.MyDocuments), "Locations.db");
            connection = new SQLiteAsyncConnection(databasePath);
            await connection.CreateTableAsync<Location>();
        }
    }
}
