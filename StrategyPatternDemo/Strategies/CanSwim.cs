using StrategyPatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo.Strategies
{
    public class CanSwim : ISwim
    {
        public string Swim()
        {
            return "Hooray! I'm swimming.";
        }
    }
}
