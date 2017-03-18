using System;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private const decimal ConvertedHeight = 0.10m;

        private bool isConverted;
        private decimal innitialHeight;

        public ConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            :base(model,materialType,price,height,numberOfLegs)
        {
            this.isConverted = false;
            this.innitialHeight = this.Height;
        }

        public bool IsConverted
        {
            get
            {
                return this.isConverted;
            }
        }

        public void Convert()
        {
            if (this.isConverted)
            {
                this.Height = ConvertedHeight;
                this.isConverted = !this.isConverted;
            }
            else
            {
                this.Height = this.innitialHeight;
                this.isConverted = !this.isConverted;
            }
        }
        public override string ToString()
        {
            var convertedToString = this.IsConverted ? "Converted" : "Normal";
            return base.ToString() + string.Format("State: {0}", convertedToString);
        }
    }
}