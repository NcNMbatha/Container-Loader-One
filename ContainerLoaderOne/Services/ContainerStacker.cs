using ContainerLoaderOne.Interfaces;

namespace ContainerLoaderOne.Services
{
    public class ContainerStacker : IContainerStacker
    {
        private IContainerServices _containerServices;

        public ContainerStacker(IContainerServices containerServices)
        {
            _containerServices = containerServices;
        }

        public int GetNumberOfContainerStacks(string containerArrival)
        {
            int letterCount = 0;
            int countStact = 0;
            string countedContainerStack = "";
            var containerArray = containerArrival.ToCharArray();

            for (int letterIndex = 1; letterIndex < containerArrival.Length; letterIndex++)
            {
                if (!countedContainerStack.Contains(containerArray[letterIndex - 1]))
                {
                    if (containerArray[letterIndex - 1] > containerArray[letterIndex])
                    {
                        letterCount = _containerServices.GetLetterCount(containerArray, containerArray[letterIndex - 1]);

                        if (letterCount > 1)
                        {
                            countStact++;
                            countedContainerStack += containerArray[letterIndex - 1];
                        }
                        else
                        {
                            letterCount = _containerServices.GetLetterCount(containerArray, containerArray[letterIndex]);

                            if (letterCount == 1)
                            {
                                countStact++;
                                countedContainerStack += containerArray[letterIndex - 1];
                                countedContainerStack += containerArray[letterIndex];
                            }
                            else
                            {
                                countStact++;
                                countedContainerStack += containerArray[letterIndex];
                            }
                        }

                    }

                    if (containerArray[letterIndex - 1] < containerArray[letterIndex])
                    {
                        countStact++;
                        countedContainerStack += containerArray[letterIndex - 1];
                    }
                }
            }

            return countStact;
        }
    }
}
