namespace ContainerLoaderOne.Interfaces
{
    public interface IContainerServices
    {
        int GetLetterCount(char[] letterArray, char containerLetter);
        bool IsSorted(char[] arrayOfLetters);
    }
}
