namespace RenamingOfOverrides
{
    public class SomeType
    {
        public string SomeCaseOfUsage()
        {
            return getMyData(1);
        }

        string getMyData(int param1)
        {
            return getMyData(param1, "param2");
        }

        string getMyData(int param1, params string[] param2)
        {
            return param1.ToString() + param2;
        } 
    }
}