using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines;
            var list = new List<string>();
            var fileStream = new FileStream(@"c:\file.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
            lines = list.ToArray();
            DataSet dataSet = new DataSet("OnlineStore");
 
        }
        public static void CreateTables(DataSet dataSet)
        {
          
 

        }


    }
}
