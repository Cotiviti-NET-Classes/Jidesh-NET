namespace day3;



//access modifier==> public ,protected, internal
public class Person
{
    public int age;
    internal string name;
    //internal is accessed within the project
    private string phone;

    internal string SetName(string n)
    {
        if(n != "")
        {
            name=n;
        }
    }
}

class A
{
    Person p;
    void Test() {
        p.name="Jidesh";
        Console.Write(p.name);
    }
}
