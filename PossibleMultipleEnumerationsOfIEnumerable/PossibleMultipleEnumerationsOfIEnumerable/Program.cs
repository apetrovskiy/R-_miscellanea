namespace PossibleMultipleEnumerationsOfIEnumerable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            var loader = new Loader();
            IEnumerable<Loader> loaders = new List<Loader>();
            var flag = new Random().Next(1, 4);

            if (!loaders.Any())
                loaders = FirstWay(flag);

            if (!loaders.Any())
                loaders = SecondWay(flag);

            if (!loaders.Any())
                loaders = ThirdWay(flag);

            Console.WriteLine(flag);
            loaders.ToList().ForEach(ldr => Console.WriteLine(ldr.StringProperty));
            Console.ReadKey();
        }

        static IEnumerable<Loader> FirstWay(int flag)
        {
            return 1 == flag ?  new List<Loader> { new Loader {StringProperty = "aaa"}, new Loader { StringProperty = "bbb"}} : new List<Loader>();
        }

        static IEnumerable<Loader> SecondWay(int flag)
        {
            return 2 == flag ? new List<Loader>(new Loader[] {new Loader {StringProperty = "ccc"}}) : new List<Loader>();
        }

        static IEnumerable<Loader> ThirdWay(int flag)
        {
            return 3 == flag
                ? new List<Loader>
                {
                    new Loader {StringProperty = "ddd"},
                    new Loader {StringProperty = "eee"},
                    new Loader {StringProperty = "fff"}
                }
                : new List<Loader>();
        }
    }

    internal class Loader
    {
        internal string StringProperty { get; set; }
    }
}
