using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = GetNames();
            //Extension methods are like other methods. so we can use like this.
            Console.WriteLine(MyExtensionMethod.ToDelimitedString(Names, ", "));
           //We referenced this keyword on the first parameter of extension method. so we can call it. like ...
            Console.WriteLine(Names.ToDelimitedString("_ "));

            Console.ReadLine();

        }
       public static List<string> GetNames()
        {
            List<string> Names = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                Names.Add("Name- "+i);
            }
            return Names;
        }
    }
    public static class MyExtensionMethod
    {
        //adding a comment
        public static string ToDelimitedString<T>(this IEnumerable<T> input, string delimiter)
        {
            var output = new StringBuilder();
            foreach (var itm in input) { if (output.Length > 0) output.Append(delimiter); output.Append(itm.ToString()); }
            return output.ToString();
        }
    }
}
