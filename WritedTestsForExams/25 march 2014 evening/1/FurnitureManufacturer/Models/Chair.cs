
namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;
    using FurnitureManufacturer.Models;

    public class Chair : Furniture, IChair
    {
        private int numberOfLegs;

        public Chair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            :base(model,materialType,price,height)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs
        {
            get
            {
                return this.numberOfLegs;
            }
            protected set
            {
                if (value <= 0 )
                {
                    throw new ArgumentException("Chair legs cannot be 0 or less!");
                }
                this.numberOfLegs = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("Legs: {0}", this.NumberOfLegs);
        }
    }
}