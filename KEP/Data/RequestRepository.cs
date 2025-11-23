using System;
using System.Data;
using System.Data.SQLite;
using KEP.Models;

namespace KEP
{
    public static class RequestRepository
    {
        private static readonly string connString = "Data Source=database.db;Version=3;";

        public static void InitDatabase()
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string sql = @"
                    CREATE TABLE IF NOT EXISTS Requests (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        FullName TEXT NOT NULL,
                        Email TEXT,
                        Phone TEXT,
                        BirthDate TEXT,
                        RequestType TEXT,
                        Address TEXT,
                        RequestDate TEXT
                    );";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }



        public static int Insert(CitizenRequest model)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(@"
                    INSERT INTO Requests 
                    (FullName, Email, Phone, BirthDate, RequestType, Address, RequestDate)
                    VALUES (@FullName, @Email, @Phone, @BirthDate, @RequestType, @Address, @RequestDate);
                    SELECT last_insert_rowid();", conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", model.FullName);
                    cmd.Parameters.AddWithValue("@Email", model.Email);
                    cmd.Parameters.AddWithValue("@Phone", model.Phone);
                    cmd.Parameters.AddWithValue("@BirthDate", model.BirthDate);
                    cmd.Parameters.AddWithValue("@RequestType", model.RequestType);
                    cmd.Parameters.AddWithValue("@Address", model.Address);
                    cmd.Parameters.AddWithValue("@RequestDate", model.RequestDate);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public static void Update(CitizenRequest model)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(@"
                    UPDATE Requests
                    SET FullName = @FullName,
                        Email = @Email,
                        Phone = @Phone,
                        BirthDate = @BirthDate,
                        RequestType = @RequestType,
                        Address = @Address,
                        RequestDate = @RequestDate
                    WHERE Id = @Id;", conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", model.FullName);
                    cmd.Parameters.AddWithValue("@Email", model.Email);
                    cmd.Parameters.AddWithValue("@Phone", model.Phone);
                    cmd.Parameters.AddWithValue("@BirthDate", model.BirthDate);
                    cmd.Parameters.AddWithValue("@RequestType", model.RequestType);
                    cmd.Parameters.AddWithValue("@Address", model.Address);
                    cmd.Parameters.AddWithValue("@RequestDate", model.RequestDate);
                    cmd.Parameters.AddWithValue("@Id", model.Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(int id)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("DELETE FROM Requests WHERE Id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable GetAll()
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(@"
                    SELECT Id, FullName, Email, Phone, BirthDate, RequestType, Address, RequestDate
                    FROM Requests
                    ORDER BY datetime(RequestDate) DESC;", conn))
                using (var da = new SQLiteDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public static DataTable Search(string keyword)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT * FROM Requests
                    WHERE FullName LIKE @kw
                       OR Email LIKE @kw
                       OR Phone LIKE @kw
                       OR Address LIKE @kw
                       OR RequestType LIKE @kw
                    ";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                    using (var da = new SQLiteDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

    }
}
