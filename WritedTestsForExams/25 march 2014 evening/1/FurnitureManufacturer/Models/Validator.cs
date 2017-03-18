using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public static class Validator
    {
        public static void ValidateDecimal(decimal input, string message = null)
        {
            if (input <= 0.00m)
            {
                throw new ArgumentException(message);
            }
        }
        public static void ValidateStringEmptyOrNull(string input, string message = null)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(message);
            }
        }
        public static void ValidateIntRange(int input,int minLenght = int.MinValue, int maxLenght = int.MaxValue, string message = null)
        {
            if (input < minLenght || input > maxLenght)
            {
                throw new IndexOutOfRangeException(message);
            }
        }
        public static void VlidateIfDigitOnly(string input,string message = null)
        {
            if (!input.All(char.IsDigit))
            {
                throw new ArgumentException(message);
            }
        }
        public static void ValidateNullObject(object input,string message = null)
        {
            if (input == null)
            {
                throw new ArgumentNullException(message);
            }
        }
    }
}
