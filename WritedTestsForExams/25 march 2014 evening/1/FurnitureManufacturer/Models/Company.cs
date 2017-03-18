
namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using FurnitureManufacturer.Interfaces;

    public class Company : ICompany
    {
         
        private const string ErrorMessageForNullName = "Name cannot be empty or null!";
        private const string ErrorMessageForNameLenght = "Name cannot be less than {0} symbols!";
        private const int MaxNameLenght = int.MaxValue;
        private const int MinNameLenght = 5;
        private const string ErrorMessageForRegNumber = "Registration number  must contain only digits!";
        private const int RegistrationNumberExactLenght = 10;
        private const string ErrorMessageForRegNumberLenght = "Registration number must be exactly {0} symbols!";

        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;


        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.registrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return new List<IFurniture>(furnitures);
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
               Validator.ValidateStringEmptyOrNull(value, ErrorMessageForNullName);
               Validator.ValidateIntRange(value.Length, MinNameLenght,MaxNameLenght, 
                   string.Format(ErrorMessageForNameLenght,MinNameLenght));
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            protected set
            {
                Validator.VlidateIfDigitOnly(value, ErrorMessageForRegNumber);
                Validator.ValidateIntRange(value.Length,RegistrationNumberExactLenght, RegistrationNumberExactLenght,
                  string.Format(ErrorMessageForRegNumberLenght, RegistrationNumberExactLenght));
                this.registrationNumber = value;
            }
        }

        public void Add(IFurniture furniture)
        {
            Validator.ValidateNullObject(furniture, "Furniture to add cannot be null!");
            this.furnitures.Add(furniture);
            
        }

        public string Catalog()
        {
            var sortedFurnitures = this.furnitures.OrderBy(f => f.Price).ThenBy(f => f.Model);
            string furnituresOrNo = this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no";
            string ifPlural = this.Furnitures.Count != 1 ? "furnitures" : "furniture";
            var output = new StringBuilder();
            output.AppendLine(string.Format("{0} - {1} - {2} {3}", this.Name,this.RegistrationNumber, furnituresOrNo, ifPlural).Trim());
            foreach (var furniture in sortedFurnitures)
            {
                output.AppendLine(furniture.ToString());
            }
            return output.ToString().Trim();
        }

        public IFurniture Find(string model)
        {
            //Validator.ValidateStringEmptyOrNull(model, "Searched model cannot be null or empty!");
            return this.Furnitures.FirstOrDefault(f => f.Model.ToLower() == model.ToLower());
        }

        public void Remove(IFurniture furniture)
        {
            Validator.ValidateNullObject(furniture, "Furniture to remove cannot be null!");
            this.furnitures.Remove(furniture);
        }
    }
}