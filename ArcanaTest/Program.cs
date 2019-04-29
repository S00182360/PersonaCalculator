using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcanaTest
{

    class Program
    {
        static public PersonasEntities db = new PersonasEntities();
        
        static void Main(string[] args)
        {
            FusionResult Child;
            Arcana ChildResult;
            Arcana Parent1 = new Arcana();
            Arcana Parent2 = new Arcana();
            string formatString = "Parent 2: {0,-15}\tResult : {1}\n";

            for (int i = 1; i < 21; i++)
            {
                Parent1 = db.Arcanas.Where(id => id.Id == i).First();
                Console.WriteLine("Parent 1:\t{0}\n", Parent1.ArcanaName);
                for (int j = 1; j  < 21; j ++)
                {
                    Parent2 = db.Arcanas.Where(id => id.Id == j).First();

                    Child = new FusionResult(Parent1, Parent2);
                    ChildResult = Child.CheckResult1();
                    Console.Write(formatString, Parent2.ArcanaName, ChildResult.ArcanaName);
                }
                Console.WriteLine("------------------------");
                Console.WriteLine("------------------------");
            }

            Console.ReadKey();
        }
    }
}
