using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    class Program
    {
        static void WriteToFile()
        {
            Console.WriteLine("Write To File Method: ");
            string inputData;
            try
            {
                using (StreamWriter SW = new StreamWriter(@"C:\FileOne.txt"))
                {
                    while (!String.IsNullOrWhiteSpace(inputData = Console.ReadLine()))
                    SW.WriteLine(inputData);
                }
            }
            catch(Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }

        static void ReadFromFile()
        {
            Console.WriteLine("Read From File Method: ");
            try
            {
                using (StreamReader SR = new StreamReader(@"C:\FileOne.txt"))
                {
                    Console.WriteLine(SR.ReadToEnd());
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }
        static void Main(string[] args)
        {
            WriteToFile();
            ReadFromFile();
        }
    }
}
