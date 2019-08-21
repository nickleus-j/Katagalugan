using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace katagaluganAPI.DAL
{
    public class WordEntity
    {
        public int WordId { get; set; }
        public int languageId{get;set;}
        public string word { get; set; }
    }
}
