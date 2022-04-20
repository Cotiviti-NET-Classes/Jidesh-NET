using System;

namespace assignment2final;

class FeatureProducts: IProductModel
{
    public int pid { get; set; }
    public string? pname { get; set; }
    public int prate { get; set; }
    public int pqty { get; set; }

    public void totalamount(ProductModel pro)
    {
        Console.WriteLine($"total amount is {pro.pqty*pro.prate}");
    }   
}