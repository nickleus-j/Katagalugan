using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Wikain.Service
{
    public class WordProvider
    {
        public static string GetWord()
        {
            string[] lines = File.ReadAllLines(@"Resource/Tagalog.txt"); //i hope that the file is not too big
            Random rand = new Random();
            return lines[rand.Next(lines.Length)];
        }
    }
}
