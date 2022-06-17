using ContainerLoaderOne.Interfaces;

namespace ContainerLoaderOne.Services
{
    public class ContainerServices : IContainerServices
    {
        public int GetLetterCount(char[] letterArray, char containerLetter)
        {
            int count = 0;

            foreach (var letter in letterArray)
            {
                if (containerLetter.Equals(letter))
                {
                    count++;
                }
            }

            return count;
        }

        public bool IsSorted(char[] arrayOfLetters)
        {
            for (int letterIndex = 1; letterIndex < arrayOfLetters.Length; letterIndex++)
            {
                if (arrayOfLetters[letterIndex - 1] < arrayOfLetters[letterIndex])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
