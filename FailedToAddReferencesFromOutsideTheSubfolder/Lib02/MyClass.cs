namespace FailedToAddReferencesFromOutsideTheSubfolder.Lib02
{
    using Lib01;
    public class MyClass : MyInterface
    {
        public string GetStringData()
        {
            return StringData;
        }

        public int GetIntData()
        {
            return 1;
        }

        public void SetStringData(string stringData)
        {
            StringData = stringData;
        }

        public string StringData { get; set; }
    }
}