
namespace task;
class Assignment
{

    int sum(int []arr)
    {
        int add=0;
        for( int i=0;i<arr.Length;i++)
        {
            add +=arr[i];
        }
        return add;
    }
    int average(int []arr)
    {
        int add1=0,avg;
        for( int i=0;i<arr.Length;i++)
        {
         add1 +=arr[i];
        }
        avg = adds/arr.Length;
        return avg;
    }
}