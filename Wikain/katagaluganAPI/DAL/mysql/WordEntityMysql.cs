using System;
using System.Collections.Generic;
using System.Linq;
using katagaluganAPI.DAL;
using MySql.Data.MySqlClient;

namespace katagaluganAPI.DAL.mysql
{
    public class WordEntityMysql
    {
        public DiksyonaryoContext Context { get; set; }
        public WordEntityMysql(DiksyonaryoContext _context)
        {
            Context = _context;
        }
        public string GetRandomWord()
        {
            string result = String.Empty;
            using (MySqlConnection conn = Context.GetConnection())
            {
                conn.Open();
                string command = @"SELECT * FROM diksyonaryo.words
                    ORDER BY RAND()
                    LIMIT 1;";
                MySqlCommand cmd = new MySqlCommand(command, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result = reader["word"].ToString();
                    }
                }
            }
            return result;
        }
    }
}
