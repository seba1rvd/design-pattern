﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class Squeak : IQuackBehavior
    {
        public string quack()
        {
            return "Пи пи пи" + this.GetType();
        }
    }
}
