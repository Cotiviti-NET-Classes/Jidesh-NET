namespace assignment2final;

class Order: IProductModel,ICustomerModel
{
    public int cid { get; set; }
    public string? name { get; set; }
    public string? email { get; set; }
    public string? city { get; set; }
    public string? phone { get; set; }
    public int pid { get; set; }
    public string? pname { get; set; }
    public int prate { get; set; }
    public int pqty { get; set; }
    public void totalamount(ProductModel pro)
    {
        Console.WriteLine($"total amount is {pro.pqty*pro.prate}");
    }   

}