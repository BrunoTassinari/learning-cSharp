namespace ByteBank;

public class Stock
{
    public string ProductName { get; set; } = "";
    public string Company { get; set; } = "";
    public string ProductCode { get; set; } = "";
    public double UnitPrice { get; set; } = 0.0;
    public int QuantityStock { get; set; } = 0;
}