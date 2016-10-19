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
        private Airplane _airforceOne;
        private Ship _titanic;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.InitializeMovables();

            WriteDescription("Moving test");
            WriteStatement(program._titanic.Name, program._titanic.Move(50));
            WriteStatement(program._airforceOne.Name, program._airforceOne.Move(120));

            WriteDescription("Swimming test");
            WriteStatement(program._titanic.Name, program._titanic.TryToSwim());
            WriteStatement(program._airforceOne.Name, program._airforceOne.TryToSwim());

            program.Year1912();

            WriteDescription("Swimming test after 1912");
            WriteStatement(program._titanic.Name, program._titanic.TryToSwim());
            WriteStatement(program._airforceOne.Name, program._airforceOne.TryToSwim());
            Console.ReadKey();
        }

        private void Year1912()
        {
            this._titanic.SetSwimmingAbility(new CantSwim());
        }

        private void InitializeMovables()
        {
            this._airforceOne = new Airplane() { Name ="AirforceOne"};
            this._airforceOne.SetSwimmingAbility(new CantSwim());
            this._titanic = new Ship() { Name = "Titanic" };
            this._titanic.SetSwimmingAbility(new CanSwim());
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
