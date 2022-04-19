namespace day3;
public class Person
{
    public int age;
    internal string name;
    //internal is accessed within the project
    private string phone;

}

class A
{
    Person p;
    void Test() {
        p.name="Jidesh";
        Console.Write(p.name);
    }
}
