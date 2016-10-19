using StrategyPatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemo
{
    public class Moveable
    {
        private ISwim Swim;

        public string Name { get;set; }

        public string Move(int speed)
        {
            return "I'm moving with "+speed.ToString()+ " kilometers per hour.";
        }

        public string TryToSwim()
        {
            return this.Swim.Swim();
        }

        public void SetSwimmingAbility(ISwim swimmingAbility)
        {
            this.Swim = swimmingAbility;
        }
}
}
