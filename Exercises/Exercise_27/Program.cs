using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_27
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "MyRecepit.txt";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


            using (StreamReader sr = new StreamReader(Path.Combine(fileName, path)))
            {
                string line = sr.ReadToEnd();
                Console.WriteLine(line);
            }
            Console.ReadLine();
              
        }
    }
}
