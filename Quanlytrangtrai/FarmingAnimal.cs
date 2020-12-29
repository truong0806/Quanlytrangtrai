using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlytrangtrai
{
    class FarmingAnimal
    {
        private string name;
        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }
        private Food eatfood;
        public Food Eatfood
        {
            get { return eatfood; }
            set { eatfood = value; }
        }
    }
}
