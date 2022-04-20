//Task parallel library
namespace day3;


using System.Threading.Tasks;
public class TPL
{
    string[] names= {"Bishnu","Nabin","Ganesh","Lalit","hari"};
    public void Do()
    {
        System.Console.WriteLine("Sequential loop");
        foreach(var name in names)
        {
            System.Threading.Thread.Sleep(1000);
            System.Console.WriteLine($"{name} has {name.Length} charaters ");
        }
        System.Console.WriteLine("Parallel loop");
        Parallel.ForEach(names,
        (name)=> System.Console.WriteLine($"{name} has {name.Length} charaters ")
        );
    }

}