using ContainerLoaderOne.Interfaces;
using System.Text;

namespace ContainerLoaderOne.Services
{
    public class ContainerLoader
    {
        private IContainerStacker _containerStacker;
        private IContainerServices _containerServices;

        public ContainerLoader(IContainerServices containerServices, IContainerStacker containerStacker)
        {
            _containerStacker = containerStacker;
            _containerServices = containerServices;
        }

        public int GetNumberOfStacks(string containerArrival)
        {
            if (string.IsNullOrEmpty(containerArrival))
            {
                return 0;
            }

            if (_containerServices.IsSorted(containerArrival.ToCharArray()))
            {
                return 1;
            }

            return _containerStacker.GetNumberOfContainerStacks(containerArrival);
        }


    }
}
