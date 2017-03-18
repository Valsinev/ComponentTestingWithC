
namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;

    public class AdjustableChair : Chair, IAdjustableChair
    {

        public AdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            :base(model,materialType,price,height,numberOfLegs)
        {
        }

        public void SetHeight(decimal height)
        {
            if (this.Height != height && height > 0)
            {
                this.Height = height;
            }
        }
    }
}