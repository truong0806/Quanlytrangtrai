using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlytrangtrai
{
    class Cow : FarmingAnimal
    {
        public Cow()
        {
            Name = Constent.COW_NAME;
            Eatfood = new Grass();
        }
    }
}
