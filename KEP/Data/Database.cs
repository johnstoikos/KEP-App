using System;
using System.Data.SQLite;
using System.IO;

namespace KEP
{
    public static class Database
    {
        private static readonly string DbPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "kep.db");

        private static readonly string ConnectionString =
            $"Data Source={DbPath};Version=3;";



        public static void Initialize()
        {
            if (!File.Exists(DbPath))
                SQLiteConnection.CreateFile(DbPath);

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Requests (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        FullName TEXT NOT NULL,
                        Email TEXT,
                        Phone TEXT,
                        BirthDate TEXT,
                        RequestType TEXT,
                        Address TEXT,
                        RequestDate TEXT NOT NULL
                    );";
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private static readonly string connString = "Data Source=database.db;Version=3;";
        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connString);
        }
    }
}
