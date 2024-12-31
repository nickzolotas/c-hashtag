using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Security.AccessControl;
using System.IO;


namespace Askhsh1
{
    internal class Data
    {
        public static void StartDB()
        {
            if (!File.Exists(@"..\..\Files\Requests.db"))
            {
                SQLiteConnection.CreateFile(@"..\..\Files\Requests.db");
                using (var connection = new SQLiteConnection($"Data Source ={@"..\..\Files\Requests.db"};Version=3;"))
                {
                    connection.Open();
                    string createTableQuery = @"
                        CREATE TABLE Requests (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name TEXT,
                            Email TEXT,
                            Phone INTEGER,
                            BirthDay TEXT,
                            Request TEXT,
                            Address TEXT,
                            Time TEXT
                        );";
                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText = createTableQuery;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}



