using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlytrangtrai
{
    /// <summary>
    /// Quản lý danh sách 1 loại động vật
    /// </summary>
    class FarmingAnimalController
    {
        private List<FarmingAnimal> animalsList;
        /// <summary>
        /// get or set value for anmial list
        /// </summary>
        public List<FarmingAnimal> AnimalsList
        {
            get { return animalsList; }
            set { animalsList = value; }
        }
        /// <summary>
        /// initial value for animallist
        /// </summary>
        public FarmingAnimalController()
        {
            AnimalsList = new List<FarmingAnimal>();
        }
        /// <summary>
        /// Add animal into list
        /// </summary>
        /// <param name="animal"></param>
        public void Add(FarmingAnimal animal)
        {
            AnimalsList.Add(animal);
        }
        /// <summary>
        /// Remove animal into list
        /// </summary>
        /// <param name="animal"></param>
        public void Remove(FarmingAnimal animal)
        {
            AnimalsList.Remove(animal);
        }
        /// <summary>
        /// get total amount of food that animal eat
        /// </summary>
        /// <param name="weight"></param>
        /// <returns></returns>
        public float TotalAmount(float weight)
        {
            if(AnimalsList.Count>0)
            {
                return AnimalsList[0].Eatfood.Amount(weight) * AnimalsList.Count;
            }
            return 0;
        }
        public void PrintTotalAmount(float weight)
        {
            if (AnimalsList.Count > 0)
            {
                Console.WriteLine("{0, 5} {1, 10} | eat | {2, 7} {3, 10} | spend | {4, 10} price", AnimalsList.Count, AnimalsList[0].Name, weight * AnimalsList.Count, AnimalsList[0].Eatfood.Name, TotalAmount(weight));
            }
            else
            {
                Console.WriteLine("Trống");
            }    
        }

    }
}
