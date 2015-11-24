namespace Lib03
{
    using Lib01;

    public class MyClass02
    {
        public virtual bool BooleanData { get; set; }
        public virtual MyInterface Obj { get; set; }

        public virtual void SetObject(MyInterface obj)
        {
            Obj = obj;
        }
    }
}