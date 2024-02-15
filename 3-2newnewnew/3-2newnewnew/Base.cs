using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2improved
{
    public abstract class Base
    {
        public bool WayOfInputtingTheArray;
        public abstract void countAverage();
        protected abstract void RandFill();
        public abstract void Output();
        public abstract void Initializ();
        protected abstract void UserFill();
        protected Random rnd = new Random();
    }
}
