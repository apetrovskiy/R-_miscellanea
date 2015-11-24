namespace Lib01
{
    public interface MyInterface
    {
        string GetStringData();
        int GetIntData();
        void SetStringData(string stringData);
        string StringData { get; set; }
    }
}