
namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;

    public abstract class Furniture : IFurniture
    {
        private const string ErrorMessageForHeight = "Height cannot be less or equal to 0.00 m!";
        private const string ErrorMessageForMaterialType = "Material type cannot be null or empty!";
        private const string ErrorMessageForNullModel = "Model cannot be null or empty!";
        private const string ErrorMessageForModelRange = "Model cannot be less than {0} symbols!";
        private const string ErrorMessageForPrice = "Price cannot be less or equal to $0.00!";
        private const int ModelMaxLenght = int.MaxValue;
        private const int ModelMinLenght = 3;

        private string model;
        private string materialType;
        private decimal price;
        private decimal height;

        public Furniture(string model, string materialType, decimal price, decimal height)
        {
            this.Model = model;
            this.Height = height;
            this.Material = materialType;
            this.Price = price;
            this.Height = height;
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }
            protected set
            {
                Validator.ValidateDecimal(value, ErrorMessageForHeight);
                this.height = value;
            }
        }

        public string Material
        {
            get
            {
                return this.materialType;
            }
            protected set
            {
                Validator.ValidateStringEmptyOrNull(value, ErrorMessageForMaterialType);
                this.materialType = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            protected set
            {
                Validator.ValidateStringEmptyOrNull(value, ErrorMessageForNullModel);
                Validator.ValidateIntRange(value.Length, ModelMinLenght,ModelMaxLenght, 
                    string.Format(ErrorMessageForModelRange ,ModelMinLenght));
                this.model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                Validator.ValidateDecimal(value, ErrorMessageForPrice);
                this.price = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}",
            this.GetType().Name,this.Model,this.Material,this.Price ,this.Height);
        }
    }
}
