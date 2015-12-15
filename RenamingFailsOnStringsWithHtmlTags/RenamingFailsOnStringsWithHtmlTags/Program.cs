/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 26/08/2015
 * Time: 07:25 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace RenamingFailsOnStringsWithHtmlTags
{
    using System;
    
    class Program
    {
        public static void Main(string[] args)
        {
            var oneMoreTypeInstance = new OneMoreType();
            Console.WriteLine(oneMoreTypeInstance.StructProperty.Value03.ToString());
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}