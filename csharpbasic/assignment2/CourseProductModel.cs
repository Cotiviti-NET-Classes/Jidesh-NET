namespace assignment2;

public class CourseProductModel: IProductModel
{
    public string Title { get; set; }
    public bool HasOrderBeenCompleted { get; set; }
    public void ShipItem(CustomerModel customer)  
    {
        if(HasOrderBeenCompleted == false)
        {
            Console.WriteLine($"Added the {Title} course to {customer.name}'s account." );
        }
    }           
}