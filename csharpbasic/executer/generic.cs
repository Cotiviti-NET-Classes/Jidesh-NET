//generic allow us to design classes and method decoupled from the data types
//sending type as a parameter ===> generics


// Generic class are extensively used by collection classes available in
// system.Collections.Generic namespace


// problem of using System.object type are
// * Areequal() method is not type safe
// Performance degradation due to boxing and unboxing
class Generic
{
    // public void sum<T>(T a, T b)
    // {
    //     Console.WriteLine(a.ToString());
    // }
    public static bool Areequal(object value1,object value2)
    {
        return value1==value2;
    }
}