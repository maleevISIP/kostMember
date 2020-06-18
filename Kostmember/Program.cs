using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kostmember
{
    class kostMembers
    {
        private string sname;
        public string name;
        private string othestvo;
        private string adress;
        internal long cNumber;
        internal long bankSchetNum;
    }
    class Program
    {
        static void Main(string[] args)
        {
            kostMembers kostMemOne = new kostMembers();
            kostMembers kostMemTwo = new kostMembers();

            kostMemOne.name = "Vitaly";
            kostMemOne.cNumber = 880055545;

            kostMemTwo.name = "Gosha";
            kostMemTwo.cNumber = 777666999;

            Console.WriteLine(kostMemOne.name + " " + kostMemOne.cNumber);
            Console.WriteLine(kostMemTwo.name + " " + kostMemTwo.cNumber);
            Console.ReadKey();
        }
    }
}
