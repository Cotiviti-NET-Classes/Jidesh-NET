//language Integrated Query
using System.Linq;

class Person
{
    public string Name { get; set; }
    public int age { get; set; }
    public char gender{get;set;}
}
class LINQ
{

    int[] numbers={1,2,3,4,5,6,7,34,234,6433,234,534534};
    string[] names={"Bishnu","Jidesh","Nabin","dipesh","Hitesh","manisha"};

    public void Learnlinq()
    {
        //we used to do imperative way before i.e. manually
        //decralative way
        var hasNameStartWithJ=names.Any(x=>x.StartsWith("j"));
        var evenNumbers=numbers.Where(x=>x%2==0);

        var evenNumbers2= from x in numbers
                    where x%2==0
                    select x;

        var namesHasIinit = names.All(x=>x.Contains("i"));

        //from 5th number
        // var items = numbers.Skip(5).Take(4);
        // foreach(var num in items)
        // Console.WriteLine(num);

        //average
        var av=numbers.Average();
        Console.WriteLine(av);

        //order
        // var or= numbers.OrderBy(x=>x);
        // foreach( var ord in or)
        // Console.WriteLine(ord);

        // List<Person> people = new()
        // {
        //     new Person {name="Jidesh",age=32,gender="m"}
        // };

        // void Check(string name)=>name.StartsWith("a");
        // var square = numbers.Select(x=>x*x);
        // //where, select , any all are methods
        // foreach(var n in square)
        //     Console.WriteLine(n);
    }
}