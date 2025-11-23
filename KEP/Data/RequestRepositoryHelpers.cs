
using KEP.Models;
using System;
using System.Data.SQLite;

namespace KEP
{
    internal static class RequestRepositoryHelpers
    {
        public static int Insert(CitizenRequest r)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(@"
                    INSERT INTO Requests
                    (FullName, Email, Phone, BirthDate, RequestType, Address, RequestDate)
                    VALUES
                    (@FullName, @Email, @Phone, @BirthDate, @RequestType, @Address, @RequestDate);
                    SELECT last_insert_rowid();", conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", r.FullName);
                    cmd.Parameters.AddWithValue("@Email", (object)r.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Phone", (object)r.Phone ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@BirthDate", (object)r.BirthDateIso ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@RequestType", (object)r.RequestType ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Address", (object)r.Address ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@RequestDate", r.RequestDateIso);

                    var result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
        }
    }
}