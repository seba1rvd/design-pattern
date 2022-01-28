using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public abstract class Duck
    {
        protected IQuackBehavior quackBehavior;
        protected IFlyBehavior flyBehavior;
        public void setFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public string Display()
        {
            return "Display" + this.GetType() + " " + this.flyBehavior.fly() + " " + this.quackBehavior.quack();
        }
        public void setQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
        public string Swim()
        {
            return "Буль буль буль" + " " + this.GetType();

        }
        public string fly()
        {
            return flyBehavior.fly();
        }
        public string quack()
        {
            return quackBehavior.quack();
        }

    }
}