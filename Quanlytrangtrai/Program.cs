﻿using System;

namespace Quanlytrangtrai
{
    class Program
    {
        static void Main(string[] args)
        {
            FarmingController Controll = new FarmingController();
            Console.WriteLine("Ten con vat can them: ");
            string name = Console.ReadLine();
            Console.WriteLine("So luong them: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Controll.AddAnimal(name, number);
        }
    }
}