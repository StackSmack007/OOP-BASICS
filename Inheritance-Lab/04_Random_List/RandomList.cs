using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public  class RandomList:List<string>
    {

        public string RandomString()
        {
            if (base.Count==0)
            {
                throw new AccessViolationException("List is Empty");
            }
            var rnd = new Random();
            int index = rnd.Next(0, this.Count - 1);
            return base[index];
        }
    }
}