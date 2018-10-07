using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Wikain.Service
{
    public class WordProvider
    {
        /// <summary>
        /// Gets random word from Word Source
        /// </summary>
        /// <returns></returns>
        public static string GetWord(string src= @"Resource/Tagalog.txt")
        {
            string[] lines = File.ReadAllLines(src); //i hope that the file is not too big
            Random rand = new Random();
            return lines[rand.Next(lines.Length)];
        }
    }
}
