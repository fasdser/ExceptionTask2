using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            Console.WriteLine(company[5]);
            
            Console.ReadLine();
        }
    }
}
