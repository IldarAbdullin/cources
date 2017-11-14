using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {

        public class Panda
        {
            public string Name { get; set; } = "Petya";
            public int Age { get; set; } = 2;
            public string Gender { get; set; } = "Male";

        }

        static void Main(string[] args)
        {
            var panda = new Panda();
            var serialized = JsonConvert.SerializeObject(panda);
            using (var streamWriter = new StreamWriter("New.txt"))
            {
                streamWriter.WriteLine(serialized);
            }


        }
    }
}
