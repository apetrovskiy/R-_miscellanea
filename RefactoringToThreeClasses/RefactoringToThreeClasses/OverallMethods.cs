namespace RefactoringToThreeClasses
{
    public class OverallMethods
    {
        private FirstMethods _firstMethods;

        public OverallMethods(FirstMethods firstMethods)
        {
            _firstMethods = firstMethods;
        }

        public void SomeMethod05ToBeExtracted(long param1)
        {
            _firstMethods.SomeMethod01ToStayHere(string.Empty);
            _firstMethods._secondMethods.SomeMethod03ToBeExtracted(1);
        }

        public void SomeMethod06ToBeExtracted(string[] param1)
        {
            _firstMethods.SomeMethod02ToStayHere(1);
            _firstMethods._secondMethods.SomeMethod04ToBeExtracted(new []{ "" });
        }
    }
}