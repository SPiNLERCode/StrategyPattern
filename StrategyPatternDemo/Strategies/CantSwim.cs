using StrategyPatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo.Strategies
{
    public class CantSwim : ISwim
    {
        public string Swim()
        {
            return "Oops! I'm sinking.";
        }
    }
}
