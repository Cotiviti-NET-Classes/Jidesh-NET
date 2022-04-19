namespace assignment2final;

public interface ICustomerModel
{
    int cid { get; set; }
    string? name { get; set; }
    string? email { get; set; }
    string? city { get; set; }
    string? phone { get; set; }
}