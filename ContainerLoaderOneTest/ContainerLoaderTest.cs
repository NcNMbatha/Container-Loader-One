using ContainerLoaderOne.Interfaces;
using ContainerLoaderOne.Services;
using NSubstitute;
using NUnit.Framework;

namespace ContainerLoaderOneTest
{
    public class ContainerLoaderTest
    {
        private ContainerLoader _loader;
        private IContainerServices _containerServicesMock;
        private IContainerStacker _containerStackerMock;

        [SetUp]
        public void Setup()
        {
            _containerServicesMock = Substitute.For<IContainerServices>();
            _containerStackerMock = Substitute.For<IContainerStacker>();
            
            _loader = new ContainerLoader(_containerServicesMock, _containerStackerMock);    
        }

        [Test]
        public void Given_ContainerLettersInSortedDescendingOrder_When_CountingNumberOfStacks_Return_One()
        {
            var containerInput = "CCCCBBBBAAAA";
            var expected = 1;
            var containerServiceInput = containerInput.ToCharArray();
            var containerServiceMockData = true;
            var containerStackerMockData = 1;

            _containerStackerMock.GetNumberOfContainerStacks(containerInput).Returns(containerStackerMockData);
            _containerServicesMock.IsSorted(containerServiceInput).Returns(containerServiceMockData);
            var actual = _loader.GetNumberOfStacks(containerInput);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given_ContainersLetters_When_CountingNumberOfStacks_Returns_Three()
        {
            var containerInput = "CBACBACBACBACBA";
            var expected = 3;
            var containerServiceInput = containerInput.ToCharArray();
            var containerServiceMockData = false;
            var containerStackerMockData = 3;

            _containerStackerMock.GetNumberOfContainerStacks(containerInput).Returns(containerStackerMockData);
            _containerServicesMock.IsSorted(containerServiceInput).Returns(containerServiceMockData);

            var actual = _loader.GetNumberOfStacks(containerInput);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given_OneContainer_When_CountingNumberOfStacks_Returns_One()
        {
            var containerInput = "A";
            var expected = 1;
            var containerServiceInput = containerInput.ToCharArray();
            var containerServiceMockData = true;
            var containerStackerMockData = 1;

            _containerStackerMock.GetNumberOfContainerStacks(containerInput).Returns(containerStackerMockData);
            _containerServicesMock.IsSorted(containerServiceInput).Returns(containerServiceMockData);
            var actual = _loader.GetNumberOfStacks(containerInput);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given_ContainersLetters_When_CountingNumberOfStacks_Returns_Four()
        {
            var containerInput = "ACMICPC";
            var expected = 4;
            var containerServiceInput = containerInput.ToCharArray();
            var containerServiceMockData = false;
            var containerStackerMockData = 4;

            _containerStackerMock.GetNumberOfContainerStacks(containerInput).Returns(containerStackerMockData);
            _containerServicesMock.IsSorted(containerServiceInput).Returns(containerServiceMockData);
            var actual = _loader.GetNumberOfStacks(containerInput);

            Assert.AreEqual(expected, actual);
        }

       
    }
}
