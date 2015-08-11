namespace RefactoringToThreeClasses
{
    public class FirstMethods
    {
        private readonly SecondMethods _secondMethods = new SecondMethods();
        private readonly OverallMethods _overallMethods;

        public FirstMethods()
        {
            _overallMethods = new OverallMethods(this);
        }

        public void SomeMethod01ToStayHere(string param1)
        {

        }

        public void SomeMethod02ToStayHere(int param1)
        {

        }
    }
}
