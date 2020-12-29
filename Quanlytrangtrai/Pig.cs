using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlytrangtrai
{
    class Pig:FarmingAnimal
    {
        public Pig()
        {
            Name = Constent.PIG_NAME;
            Eatfood = new Bran();
        }
    }
}
