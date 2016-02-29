namespace RefactorMoveResourceFileDisaster
{
    using System;
    using First.Library;
    using SecondLib;
    using Third.One;

    class Program
    {
        static void Main(string[] args)
        {
            var class001 = new SomeClass001();
            class001.SomeMethod();
            var class002 = new SomeClass002();
            class002.SomeMethod();
            var class003 = new SomeClass003();
            class003.SomeMethod();

            Console.ReadKey();
        }
    }
}
