

class Collections
{
    List<string> a= new();


//stack --last in first out
    Stack<string> b=new();

    //queue --first in first out
    Queue<double> c = new();

    Dictionary<string,int> d=new();

    //has set does not allow dublicate

    HashSet<Person> p=new();
    
    void Learn()
    {
        a.Add("ssdf");
        a.Remove("ssdf");
        b.Push("jidesh");
        b.Pop();


        c.Enqueue(45.6);
        c.Dequeue();
        

        d.Add("a",4);
        d["a"]=45;
    }

}