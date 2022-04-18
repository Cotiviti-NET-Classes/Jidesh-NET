
namespace Task;
class Assignment
{


//takes array as parameter and returns sum and average
    public string sumandavg(int[] arr)
    {
        int add=0;
        float avg;
        for( int i=0;i<arr.Length;i++)
        {
            add +=arr[i];
        }
        Console.Write(arr.Length);
        avg=add/arr.Length;
        return $"the sum of array = {add} and average = {avg}";
        
    }

    //takes multiple parameter and returns sum and average
    // public (int sum,float avg) sumavgmultipara(params int[] datas)
    // {
    //     int sum=0;
    //     float avg;
    //     foreach(int data in datas)
    //     {
    //         sum+=data;
    //     }
    //     avg=sum/datas.Length;
    //     return (sum,avg);

    // }

}