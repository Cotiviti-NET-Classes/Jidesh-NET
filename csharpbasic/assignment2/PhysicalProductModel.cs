
namespace assignment2;

public class PhysicalProductModel: IProductModel
{
    public string Title {get; set;}

    public bool HasOrderBeenCompleted {get; private set;}

    public void ShipItem(CustomerModel customer)
    {
        if(HasOrderBeenCompleted == false)
        {
            Console.WriteLine($"Simulating Shipping {Title} to {customer.name} in {customer.city}");
            HasOrderBeenCompleted=true;
        }
    }

}
