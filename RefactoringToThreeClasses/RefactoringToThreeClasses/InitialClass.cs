namespace RefactoringToThreeClasses
{
    public class InitialClass
    {
        public void SomeMethod01ToStayHere(string param1)
        {

        }

        public void SomeMethod02ToStayHere(int param1)
        {

        }

        public void SomeMethod03ToBeExtracted(long param1)
        {

        }

        public void SomeMethod04ToBeExtracted(string[] param1)
        {

        }

        public void SomeMethod05ToBeExtracted(long param1)
        {
            SomeMethod01ToStayHere(string.Empty);
            SomeMethod03ToBeExtracted(1);
        }

        public void SomeMethod06ToBeExtracted(string[] param1)
        {
            SomeMethod02ToStayHere(1);
            SomeMethod04ToBeExtracted(new []{ "" });
        }
    }
}
