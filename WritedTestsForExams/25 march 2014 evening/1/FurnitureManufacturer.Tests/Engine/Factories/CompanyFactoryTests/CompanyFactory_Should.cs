namespace FurnitureManufacturer.Tests.Engine.Factories.CompanyFactoryTests
{
    using FurnitureManufacturer.Engine.Factories;
    using FurnitureManufacturer.Models;
    using NUnit.Framework;

    [TestFixture]
    public class CompanyFactory_Should
    {
        [Test]
        public void CreateNewCompany_WhenCreateCompanyWithValidDataIsPassed()
        {
            var company = new CompanyFactory();

            var newCompany = company.CreateCompany("Izgrev", "1234567890");

            Assert.IsInstanceOf(typeof(Company), newCompany);
        }
    }
}
