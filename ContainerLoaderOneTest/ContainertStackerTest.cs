using ContainerLoaderOne.Services;
using NUnit.Framework;

namespace ContainerLoaderOneTest
{
    public class ContainertStackerTest
    {
        private ContainerStacker _containerStacker;

        [SetUp]
        public void Setup()
        {
            _containerStacker = new ContainerStacker(new ContainerServices());
        }

        [Test]
        public void Given_ContainersLetters_When_CountingNumberOfStacks_Returns_Three()
        {
            var containerInput = "CBACBACBACBACBA";
            var expected = 3;

            var actual = _containerStacker.GetNumberOfContainerStacks(containerInput);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given_ContainersLetters_When_CountingNumberOfStacks_Returns_Four()
        {
            var containerInput = "ACMICPC";
            var expected = 4;

            var actual = _containerStacker.GetNumberOfContainerStacks(containerInput);

            Assert.AreEqual(expected, actual);
        }
    }
}
