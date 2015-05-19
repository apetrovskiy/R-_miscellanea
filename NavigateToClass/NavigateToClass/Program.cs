using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NavigateToClass
{
    using Place01;
    using Place01.Place02;

    class Program
    {
        static void Main(string[] args)
        {
            var class01 = new Class01();
            var class02 = new Class02();
            var place02 = new NavigateToClass.Place01.Place02();
        }
    }
}
