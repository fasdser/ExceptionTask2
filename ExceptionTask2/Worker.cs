using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTask2
{
    class Worker
    {
        public int year;
        public string Name { get; set; }
        public string Post { get; set; }


      public int Year
        {
            get { return year; }
            set
            {
                
                if (value<=DateTime.Now.Year && DateTime.Now.Year -value <=50)
                {
                    year = value;
                }
                else
                {
                    Console.WriteLine("Неверно задан год! Повторите");
                    Year= Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public int Experience()
        {
            return DateTime.Now.Year - year;
        }

        public Worker(string name,string post,int year)
        {
            this.Name = name;
            this.Post = post;
            this.Year = DateTime.Now.Year;
            this.Year = year;
        }
    }
}
