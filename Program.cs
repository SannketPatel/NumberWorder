using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberWorder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> errs = new Dictionary<string, string>();
            Console.WriteLine(GetWrittenInteger(input,errs));
            if (errs.Count > 0)
            {
                Console.WriteLine("Errors: You should pass numeric numbers");
                foreach (var item in errs)
                {
                    Console.WriteLine("Position at " + item.Key + " - " + item.Value);
                }
            }
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);

        }
        public static string GetWrittenInteger(string n,Dictionary<string,string> errs)
        {
            
            // n= 3412
            char[] numArray = n.ToCharArray();
            string[] a = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };  
            string output = "";
            
            for (int i = 0; i < numArray.Length; i++)
            {
                string singleNumber = Convert.ToChar(numArray[i]).ToString();
                // logic (too lazy but you get the idea)
                if (char.IsNumber(Convert.ToChar(numArray[i])))
                    output += a[Convert.ToInt32(singleNumber)];
                else
                    errs.Add(i.ToString(), "'"+singleNumber+ "' is not a number");

            }
            return output.ToUpper();
        }
    }
}
