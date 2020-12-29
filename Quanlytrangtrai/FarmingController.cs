using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlytrangtrai
{
    class FarmingController
    {
        private FarmingAnimalController cow;
        /// <summary>
        /// get or set value of cow
        /// </summary>
        internal FarmingAnimalController Cow
        {
            get { return cow; }
            set { cow = value; }
        }
        private FarmingAnimalController chicken;
        /// <summary>
        /// get or set value of chicken
        /// </summary>
        internal FarmingAnimalController Chicken
        {
            get { return chicken; }
            set { chicken = value; }
        }
        private FarmingAnimalController pig;
        /// <summary>
        /// get or set value of pig
        /// </summary>
        internal FarmingAnimalController Pig
        {
            get { return pig; }
            set { pig = value; }
        }
        private FarmingAnimalController dog;
        /// <summary>
        /// get or set value of dog
        /// </summary>
        internal FarmingAnimalController Dog
        {
            get { return dog; }
            set { dog = value; }
        }
        /// <summary>
        /// initial value for farming animal
        /// </summary>
        public FarmingController()
        {
            Cow = new FarmingAnimalController();
            Chicken = new FarmingAnimalController();
            Pig = new FarmingAnimalController();
            Dog = new FarmingAnimalController();
        }
        private void Remove(FarmingAnimalController animalController, string name, int number)
        {
            if (animalController.AnimalsList.Count >= number)
            {
                FarmingAnimal newAnimal = new FarmingAnimal();
                if (name.Equals(Constent.COW_NAME))
                {
                    newAnimal = new Cow();
                }
                else
                    if (name.Equals(Constent.CHICKEN_NAME))
                {
                    newAnimal = new Chicken();
                }
                else
                        if (name.Equals(Constent.PIG_NAME))
                {
                    newAnimal = new Pig();
                }
                else
                            if (name.Equals(Constent.DOG_NAME))
                {
                    newAnimal = new Dog();
                }
                else
                    return;

                for (int i = 0; i < number; i++)
                {
                    animalController.Remove(newAnimal);
                }
            }
            else
            {
                animalController.AnimalsList.Clear();
            }    
        }
        private void Add(FarmingAnimalController animalController, string name, int number)
        {
            FarmingAnimal newAnimal = new FarmingAnimal();
            if (name.Equals(Constent.COW_NAME))
            {
                newAnimal = new Cow();
            }
            else
                if (name.Equals(Constent.CHICKEN_NAME))
                {
                    newAnimal = new Chicken();
                }
                else
                    if (name.Equals(Constent.PIG_NAME))
                    {
                        newAnimal = new Pig();
                    }
                    else
                        if (name.Equals(Constent.DOG_NAME))
                        {
                            newAnimal = new Dog();
                        }
                        else 
                            return;

            for (int i = 0; i< number; i++)
            {
                animalController.Add(newAnimal);
            }    
        }
        public void AddAnimal(string animalName, int amount)
        {
            if(animalName.Equals(Constent.COW_NAME))
            {
                Add(Cow, Constent.COW_NAME, amount);
                return;
            }
            if (animalName.Equals(Constent.CHICKEN_NAME))
            {
                Add(Chicken, Constent.CHICKEN_NAME, amount);
                return;
            }
            if (animalName.Equals(Constent.PIG_NAME))
            {
                Add(Pig, Constent.PIG_NAME, amount);
                return;
            }
            if (animalName.Equals(Constent.DOG_NAME))
            {
                Add(Dog, Constent.DOG_NAME, amount);
                return;
            }
        }
        public void RemoveAnimal(string animalName, int amount)
        {
            if (animalName.Equals(Constent.COW_NAME))
            {
                Remove(Cow, Constent.COW_NAME, amount);
                return;
            }
            if (animalName.Equals(Constent.CHICKEN_NAME))
            {
                Remove(Chicken, Constent.CHICKEN_NAME, amount);
                return;
            }
            if (animalName.Equals(Constent.PIG_NAME))
            {
                Remove(Pig, Constent.PIG_NAME, amount);
                return;
            }
            if (animalName.Equals(Constent.DOG_NAME))
            {
                Remove(Dog, Constent.DOG_NAME, amount);
                return;
            }
        }
        public void TotalAmount()
        {
            float sum = Cow.TotalAmount(Constent.FOOD_WEIGHT_COW_EAT_PER_DAY)
                + Chicken.TotalAmount(Constent.FOOD_WEIGHT_CHICKEN_EAT_PER_DAY)
                + Pig.TotalAmount(Constent.FOOD_WEIGHT_PIG_EAT_PER_DAY)
                + Dog.TotalAmount(Constent.FOOD_WEIGHT_DOG_EAT_PER_DAY);

            Cow.PrintTotalAmount(Constent.FOOD_WEIGHT_COW_EAT_PER_DAY);
            Chicken.PrintTotalAmount(Constent.FOOD_WEIGHT_CHICKEN_EAT_PER_DAY);
            Pig.PrintTotalAmount(Constent.FOOD_WEIGHT_PIG_EAT_PER_DAY);
            Dog.PrintTotalAmount(Constent.FOOD_WEIGHT_DOG_EAT_PER_DAY);

            Console.WriteLine("\n Total: {0, 10} price", sum);
        }
        public void Menu()
        {
            Console.WriteLine("1 Them vat nuoi");
            Console.WriteLine("2 Xoa vat nuoi");
            Console.WriteLine("3 Tong chi phi vat nuoi");

            Console.Write("Lua chon: ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Ten con vat can them: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("So luong them: ");
                    int number = int.Parse(Console.ReadLine());
                    AddAnimal(name, number);
                    break;
                case '2':

                    break;
                case 3:
                    TotalAmount();
                    break;
            }
        }
    }
}
