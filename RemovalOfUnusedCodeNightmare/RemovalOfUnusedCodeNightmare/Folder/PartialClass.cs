/*
 * Created by SharpDevelop.
 * User: alexa_000
 * Date: 11/02/2016
 * Time: 09:27 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace RemovalOfUnusedCodeNightmare.Folder
{
    using Folder.Folder02;

    /// <summary>
    /// Description of PartialClass.
    /// </summary>
    public partial class PartialClass
    {
        partial void Method01();

        public PartialClass()
        {
            var someClassInstance = new SomeClass();
            var someClass02Instance = new SomeClass02();
        }
    }
}