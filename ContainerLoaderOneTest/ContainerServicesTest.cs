using ContainerLoaderOne.Services;
using NUnit.Framework;

namespace ContainerLoaderOneTest
{
    public class ContainerServicesTest
    {
        private ContainerServices _containerServices;

        [SetUp]
        public void Setup()
        {
            _containerServices = new ContainerServices();    
        }

        [Test]
        public void Given_ContainersInASortedDescendingOrder_When_CheckingIsSorted_Returns_True()
        {
            var containerInput = new char []{'C', 'C', 'C', 'C','B', 'B', 'B', 'B', 'A', 'A', 'A', 'A' };
            var expected = true;

            var actual = _containerServices.IsSorted(containerInput);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given_ContainersInASortedDescendingOrder_When_CheckingIsSorted_Returns_False()
        {
            var containerInput = "BBBBCCCCAAAA".ToCharArray();
            var expected = false;

            var actual = _containerServices.IsSorted(containerInput);

            Assert.AreEqual(expected, actual);
        }
    }
}
