using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;

namespace katagaluganAPI.DAL
{
    public class DiksyonaryoContext
    {
        public string ConnectionString { get; set; }
        public DiksyonaryoContext(string _connectionString)
        {
            ConnectionString = _connectionString;
        }
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
