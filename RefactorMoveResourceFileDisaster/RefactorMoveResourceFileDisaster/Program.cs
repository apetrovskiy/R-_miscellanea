namespace RefactorMoveResourceFileDisaster
{
    using System;
    using First.Library;
    using SecondLib;

    class Program
    {
        static void Main(string[] args)
        {
            var class001 = new SomeClass001();
            class001.SomeMethod();
            var class002 = new SomeClass002();
            class002.SomeMethod();

            Console.ReadKey();
        }
    }
}
