using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace ConsoleApp2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            using (var streamReader = new StreamReader("New.txt"))
            {
                var line = streamReader.ReadLine();
                Console.WriteLine(line);
                Console.ReadKey();
            }


        }
    }
}
