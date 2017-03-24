namespace FurnitureManufacturer.Tests.Models.CompanyTests
{
    using System;

    using FurnitureManufacturer.Models;
    using NUnit.Framework;

    [TestFixture]
    public class Company_Should
    {
        [Test]
        public void CreateAnInstance()
        {
            var company = new Company("Izgrev", "0123456789");

            Assert.IsInstanceOf(typeof(Company), company);
        }

        [Test]
        public void AddFurniture_WhenAddIsCalled()
        {
            var company = new Company("Izgrev", "0123456789");

            var chair = new Chair("Visage", "Wood", 65, 1.20m, 4);

            company.Add(chair);

            Assert.AreEqual(1, company.Furnitures.Count);
        }

        [Test]
        public void ThrowArgumentNullException_WhenAddNullFurniture()
        {
            var company = new Company("Izgrev", "0123456789");

            Assert.Throws<ArgumentNullException>(() => company.Add(null));
        }

        [Test]
        public void RemoveFurniture_WhenRemoveIsCalled()
        {
            var company = new Company("Izgrev", "0123456789");

            var chair = new Chair("Visage", "Wood", 65, 1.20m, 4);

            company.Add(chair);
            company.Remove(chair);

            Assert.AreEqual(0, company.Furnitures.Count);
        }

        [Test]
        public void ThrowArgumentNullException_WhenRemoveNullFurniture()
        {
            var company = new Company("Izgrev", "0123456789");

            Assert.Throws<ArgumentNullException>(() => company.Remove(null));
        }

        [Test]
        public void ThrowIndexOutOfRangeException_WhenCompanyNameIsBellow5Symbols()
        {
            Assert.Throws<IndexOutOfRangeException>(() => new Company("Low", "0123456789"));
        }

        [Test]
        public void ThrowArgumentNullException_WhenCompanyNameIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new Company(null, "0123456789"));
        }

        [TestCase("0123")]
        [TestCase("012345678910")]
        public void ThrowIndexOutOfRangeException_WhenCompanyRegistrationNumberIsntExactly10Symbols(string registrationNumber)
        {
            Assert.Throws<IndexOutOfRangeException>(() => new Company("Izgrev", registrationNumber));
        }

        [Test]
        public void ThrowArgumentException_WhenCompanyRegistrationNumberDoesntContainOnlyDigits()
        {
            Assert.Throws<ArgumentException>(() => new Company("Izgrev", "012345678B"));
        }

        [Test]
        public void FindCorrectFurniture_WhenFindIsCalled()
        {
            var company = new Company("Izgrev", "0123456789");

            var chair = new Chair("Visage", "Wood", 65, 1.20m, 4);
            var secondChair = new Chair("Caprize", "Wood", 65, 1.20m, 4);

            company.Add(chair);
            company.Add(secondChair);

            var result = company.Find("Caprize");

            Assert.AreEqual(secondChair, result);
        }

        [Test]
        public void ThrowNullReferenceException_WhenFindIsCalledWithNullValue()
        {
            var company = new Company("Izgrev", "0123456789");

            var chair = new Chair("Visage", "Wood", 65, 1.20m, 4);

            company.Add(chair);

            Assert.Throws<NullReferenceException>(() => company.Find(null));
        }

        [Test]
        public void ReturnExpectedString_WhenCatalogIsCalledWithOneFurniture()
        {
            var company = new Company("Izgrev", "0123456789");

            var chair = new Chair("Visage", "Wood", 65, 1.20m, 4);

            company.Add(chair);

            var newLine = Environment.NewLine;
            string expected =
                "Izgrev - 0123456789 - 1 furniture" + newLine +
                "Type: Chair, Model: Visage, Material: Wood, Price: 65, Height: 1,20Legs: 4";

            Assert.AreEqual(expected, company.Catalog());
        }

        [Test]
        public void ReturnExpectedSortedByPriceString_WhenCatalogIsCalledWithMoreThanOneFurniture()
        {
            var company = new Company("Izgrev", "0123456789");

            var chair = new Chair("Visage", "Wood", 65, 1.20m, 4);
            var secondChair = new Chair("Caprize", "Wood", 165, 1.00m, 3);

            company.Add(secondChair);
            company.Add(chair);

            var newLine = Environment.NewLine;
            string expected =
                "Izgrev - 0123456789 - 2 furnitures" + newLine +
                "Type: Chair, Model: Visage, Material: Wood, Price: 65, Height: 1,20Legs: 4" + newLine +
                "Type: Chair, Model: Caprize, Material: Wood, Price: 165, Height: 1,00Legs: 3";

            Assert.AreEqual(expected, company.Catalog());
        }

        [Test]
        public void ReturnExpectedSortedByModelString_WhenCatalogIsCalledWithMoreThanOneFurniture()
        {
            var company = new Company("Izgrev", "0123456789");

            var chair = new Chair("Avangard", "Wood", 65, 1.20m, 4);
            var secondChair = new Chair("Caprize", "Wood", 65, 1.00m, 3);

            company.Add(secondChair);
            company.Add(chair);

            var newLine = Environment.NewLine;
            string expected =
                "Izgrev - 0123456789 - 2 furnitures" + newLine +
                "Type: Chair, Model: Avangard, Material: Wood, Price: 65, Height: 1,20Legs: 4" + newLine +
                "Type: Chair, Model: Caprize, Material: Wood, Price: 65, Height: 1,00Legs: 3";

            Assert.AreEqual(expected, company.Catalog());
        }

        [Test]
        public void ReturnExpectedString_WhenCatalogIsCalledWithNoFurnitures()
        {
            var company = new Company("Izgrev", "0123456789");

            var newLine = Environment.NewLine;
            string expected = "Izgrev - 0123456789 - no furnitures";

            Assert.AreEqual(expected, company.Catalog());
        }
    }
}
