using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlytrangtrai
{
    class Food
    {
        private string name;
        /// <summary>
        /// get or set food name
        /// </summary>
        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }
        /// <summary>
        /// get or set price
        /// </summary>
        private float price;
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        /// <summary>
        /// Calculate total amount of food weight
        /// </summary>
        /// <param name="weight"></param>
        /// <returns></returns>
        public float Amount(float weight)
        {
            return price * weight;
        }
    }
}
