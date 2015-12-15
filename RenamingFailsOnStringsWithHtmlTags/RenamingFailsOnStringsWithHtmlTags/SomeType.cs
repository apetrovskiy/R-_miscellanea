/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 26/08/2015
 * Time: 07:26 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace RenamingFailsOnStringsWithHtmlTags
{
    using System;
    
    /// <summary>
    /// Description of SomeType.
    /// </summary>
    public class SomeType
    {
        public void DoSomething()
        {
            var someValue03 =
                @"<style type=""text/css"">" + "\r\n" +
                @".value03          { " + "\r\n" +
                @"                      color: gray;" + "\r\n" +
                @"                     }" + "\r\n" +
                @"</style>" + "\r\n";
            var someMoreValue03 = @"<p class=""data value03"">";
        }

        public void DoMore()
        {
            var someVar = @"some data";
            someVar += SomeEnumValues.Value03.ToString();
        }

        // public 
    }
}
