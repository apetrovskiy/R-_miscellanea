namespace RefactoringOfSettingsFile
{
    using System;
    using MyLib;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyConstants.Setting01);
            Console.WriteLine(MyConstants.Setting02);
            Console.WriteLine(MyConstants.Setting03);

            Console.Read();
        }
    }
}
