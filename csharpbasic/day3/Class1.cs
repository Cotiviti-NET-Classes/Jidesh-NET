using System;




//access modifier==> public ,protected, internal(with in the project), private(with in the class)
public class Person
{
    public Person()
    {
        IsLivingBeing3 = true;

    }

    //read only property
    public string Name { get; }
    public int age;
    private string _name;
    internal string name
    {
        get
        {
            return _name;
        }
        set
        {
            if (value != null || value != "")
            {
                _name = value;
            }
        }
    }
    //internal is accessed within the project
    private string phone;
    public char Gender { get; set; } = 'M';

    // internal string SetName(string n)
    // {
    //     if (n != "")
    //     {
    //         name = n;
    //     }
    // }

    //Constants
    //value that remains constant towards the program
    //const keyword should be used
    // It better to access constant with class itslef instead of object
    public const bool IsLivingBeing = true;

    public static bool IsLivingBeing2 = true;

    public readonly bool IsLivingBeing3 = true;


    void PrintName()
    {
        Console.WriteLine(this.Name);
    }

    void SayHello()
    {
        Console.Write("Hello");
    }

}

class A
{
    Person p;
    void Test()
    {
        p.name = "Jidesh";
        Console.Write(p.name);
    }
}


class X
{
    public virtual void Greet(string name) => Console.WriteLine($"Hi, {name}");
}

class Y : X
{

    public override void Greet(string name)
    {
        base.Greet(name);
        Console.WriteLine($"Hi, {name}");

    }
}