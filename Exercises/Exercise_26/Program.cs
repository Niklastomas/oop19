using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_26
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();
            string fileName = "MyFile.txt";

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Console.WriteLine($"Path - My documents: {path}");
            myList.Add($"Path - My documents: { path}");

            path = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            Console.WriteLine($"Path - My pictures: {path}");
            myList.Add($"Path - My documents: { path}");

            path = Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
            Console.WriteLine($"Path - Cookies: {path}");
            myList.Add($"Path - My Cookies: {path}");

            path = Environment.CurrentDirectory;
            Console.WriteLine($"Path - Current directory: {path}");
            myList.Add($"Path - Current directory: {path}");

            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter sw = new StreamWriter(Path.Combine(fileName, path)))
            {
                foreach (var item in myList)
                {
                    sw.WriteLine(item);
                }

            }
            Console.ReadLine();

        }
    }
}
