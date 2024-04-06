using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class BaseClass
{
    public virtual string VirtualProperty { get; set; }

    public BaseClass(params object[] parameters)
    {
        foreach (object param in parameters)
        {
            Console.WriteLine("Parameter: " + param.ToString());
        }
    }

    public virtual void VirtualMethod()
    {
        Console.WriteLine("BaseClass: Virtual Method");
    }
}

public class DerivedClass1 : BaseClass
{
    public int AdditionalParameter { get; }

    public override string VirtualProperty
    {
        get => base.VirtualProperty;
        set => base.VirtualProperty = value;
    }

    public DerivedClass1(int additionalParameter, params object[] parameters)
        : base(parameters)
    {
        AdditionalParameter = additionalParameter;
    }

    public override void VirtualMethod()
    {
        Console.WriteLine("DerivedClass1: Virtual Method");
    }
}

public class DerivedClass2 : DerivedClass1
{
    public double AnotherAdditionalParameter { get; }

    public override string VirtualProperty
    {
        get => base.VirtualProperty;
        set => base.VirtualProperty = value;
    }

    public DerivedClass2(double anotherAdditionalParameter, int additionalParameter, params object[] parameters)
        : base(additionalParameter, parameters)
    {
        AnotherAdditionalParameter = anotherAdditionalParameter;
    }

    public override void VirtualMethod()
    {
        Console.WriteLine("DerivedClass2: Virtual Method");
    }
}

