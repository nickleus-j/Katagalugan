using System;
using System.Collections.Generic;
using System.Linq;
using katagaluganAPI.DAL;
using MySql.Data.MySqlClient;

namespace katagaluganAPI.DAL.mysql
{
    public class UserDefinedWordsMyql
    {
        public DiksyonaryoContext Context { get; set; }
        public UserDefinedWordsMyql(DiksyonaryoContext _context)
        {
            Context = _context;
        }
        public IList<UserDefinedWord>GetUserDefinedwords(int wordId)
        {
            IList<UserDefinedWord> result = new List<UserDefinedWord>();
            using (MySqlConnection conn = Context.GetConnection())
            {
                conn.Open();
                string command = @"SELECT wordId,definition FROM diksyonaryo.userdefinedwords WHERE wordId=@wordId;";
                MySqlCommand cmd = new MySqlCommand(command, conn);
                cmd.Parameters.AddWithValue("@wordId", wordId);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        UserDefinedWord uDefinition = new UserDefinedWord();
                        uDefinition.wordId = wordId;
                        uDefinition.definition = reader["definition"].ToString();
                        result.Add(uDefinition);
                    }
                }
            }
            return result;
        }
    }
}
