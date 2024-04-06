
class MyMain
{
    static void Main(string[] args)
    {
        BaseClass baseObj = new BaseClass(1, "test", true);
        DerivedClass1 derived1Obj = new DerivedClass1(10, "example", false);
        DerivedClass2 derived2Obj = new DerivedClass2(3.14, 20, "sample", true);

        baseObj.VirtualMethod();
        derived1Obj.VirtualMethod();
        derived2Obj.VirtualMethod();
    }
}
