
namespace task;
class Assignment()
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
        int add;
        for( int i=0;i<arr.Length;i++)
        {
            add +=arr[i];
        }
        average = add/arr.Length;
        return average;
    }
}