using StrategyPatternDemo.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo
{
    class Program
    {
        private Airplane airforceOne;
        private Ship titanic;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.InitializeMovables();

            WriteDescription("Moving test");
            WriteStatement(program.titanic.Name, program.titanic.Move(50));
            WriteStatement(program.airforceOne.Name, program.airforceOne.Move(120));

            WriteDescription("Swimming test");
            WriteStatement(program.titanic.Name, program.titanic.TryToSwim());
            WriteStatement(program.airforceOne.Name, program.airforceOne.TryToSwim());

            program.Year1912();

            WriteDescription("Swimming test after 1912");
            WriteStatement(program.titanic.Name, program.titanic.TryToSwim());
            WriteStatement(program.airforceOne.Name, program.airforceOne.TryToSwim());
            Console.ReadKey();
        }

        private void Year1912()
        {
            this.titanic.SetSwimmingAbility(new CantSwim());
        }

        private void InitializeMovables()
        {
            this.airforceOne = new Airplane() { Name ="AirforceOne"};
            this.airforceOne.SetSwimmingAbility(new CantSwim());
            this.titanic = new Ship() { Name = "Titanic" };
            this.titanic.SetSwimmingAbility(new CanSwim());
        }

        private static void WriteStatement(string author, string text)
        {
            Console.WriteLine(author + ": "+ text);
        }

        private static void WriteDescription(string text)
        {
            Console.WriteLine("");
            Console.WriteLine("================"+text+"===============");
        }
    }
}
