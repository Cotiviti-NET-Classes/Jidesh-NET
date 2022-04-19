namespace assignment2final;


public interface IProductModel
{
    int pid { get; set; }
    string? pname { get; set; }
    int prate { get; set; }
    int pqty { get; set; }

    void totalamount(ProductModel pro);
}