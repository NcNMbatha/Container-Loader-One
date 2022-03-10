using ContainerLoaderOne.Services;
using NUnit.Framework;

namespace ContainerLoaderOneTest.IntegrationTest
{
    public class ContainerLoaderTest
    {
        private ContainerLoader _containerLoader;

        [SetUp]
        public void Setup()
        {
            _containerLoader = new ContainerLoader(new ContainerServices(), new ContainerStacker(new ContainerServices()));
        }

        [Test]
        public void Given_ContainerLettersInSortedDescendingOrder_When_CountingNumberOfStacks_Return_One()
        {
            var containerInput = "CCCCBBBBAAAA";
            var expected = 1;
           
            var actual = _containerLoader.GetNumberOfStacks(containerInput);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given_ContainersLetters_When_CountingNumberOfStacks_Returns_Three()
        {
            var containerInput = "CBACBACBACBACBA";
            var expected = 3;

            var actual = _containerLoader.GetNumberOfStacks(containerInput);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given_OneContainer_When_CountingNumberOfStacks_Returns_One()
        {
            var containerInput = "A";
            var expected = 1;
        
            var actual = _containerLoader.GetNumberOfStacks(containerInput);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given_ContainerLetters_When_CountingNumberOfStacks_Returns_Four()
        {
            var containerInput = "ACMICPC";
            var expected = 4;
           
            var actual = _containerLoader.GetNumberOfStacks(containerInput);

            Assert.AreEqual(expected, actual);
        }
    }
}
