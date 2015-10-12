namespace ImplementationOfMissingMembers002
{
    using System.Collections.Generic;

    public interface IInterface
    {
        Dictionary<string, string> Settings { get; set; }
        void Do();
    }
}