using System;
using System.Linq;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            return strings.Where(s => s.Length == 4).ToArray();
        }
    }
}
