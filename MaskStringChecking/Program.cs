using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MaskStringChecking
{
    class Program
    {
        static void Main(string[] args)
        {
            string mask = "*.csv";
            string s = "file.csv";
            string pattern = "";
            pattern += @"^";
            for (int i = 0; i < mask.Length; i++)
            {
                switch (mask[i])
                {
                    case '.': pattern += @"\."; break;
                    case '?': pattern += @"."; break;
                    case '*': pattern += @".*"; break;
                    default: pattern += mask[i]; break;
                }
            }
            pattern += @"$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(s)) Console.WriteLine("Correct");
            else Console.WriteLine("Incorrect");
            Console.ReadLine();
        }
    }
}
