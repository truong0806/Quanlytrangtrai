using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlytrangtrai
{
    class Dog: FarmingAnimal
    {
        public Dog()
        {
            Name = Constent.DOG_NAME;
            Eatfood = new Meat();
        }
    }
}
