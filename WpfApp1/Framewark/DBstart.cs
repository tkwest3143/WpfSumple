using System;
using System.Data.SQLite;

namespace Framewark
{
    public class DBstart
    {
        public void Start()
        {
            var sqlConnSb = new SQLiteConnectionStringBuilder { DataSource = ":memory:" };

            using (var conn = new SQLiteConnection(sqlConnSb.ToString()))
            {
                conn.Open();

                using (var cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "select sqlite_version()";
                    Console.WriteLine(cmd.ExecuteScalar());
                }
            }
        }
    }
}
