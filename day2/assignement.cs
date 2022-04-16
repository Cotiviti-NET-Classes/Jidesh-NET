
namespace Task;
class Assignment
{

    public string sumandavg(int []arr)
    {
        int add=0;
        float avg;
        for( int i=0;i<arr.Length;i++)
        {
            add +=arr[i];
        }
        avg=add/arr.Length;
        return $"the sum of array is {add} and average is {avg}";
        
    }
}