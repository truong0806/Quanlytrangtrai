using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlytrangtrai
{
    class Chicken : FarmingAnimal
    {
        public Chicken()
        {
            Name = Constent.CHICKEN_NAME;
            Eatfood = new Corn();
        }
    }
}
