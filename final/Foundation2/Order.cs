using System.Data;

public class Order
{

    private List<Product> _products;
    private Customer _customer;
    private double shippingCostUS = 5.0;
    private double shippingCostNotUS = 35.0;
    private double shippingCost;


    public Order(Customer customer){

        _customer = customer;

        _products = new List<Product>();


        if(_customer.LiveInUSA()){

            shippingCost = shippingCostUS;
        }
        else {

            shippingCost = shippingCostNotUS;
        }
    }



    public double CalculateTotalCost()
    {
        double total = shippingCost;
        foreach(Product product in _products){

            total += product.CalculateTotalCost();

        }
        return total;
    }

    public string CreatePackingLabel()
    {
        string packingLabel = "";

        foreach(Product product in _products){

             packingLabel += $"{product.GetName()} - {product.GetProductID()}\n";

        }

        return packingLabel;
    }

    public string CreateShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetCustomerAddress()}";
    }

    public void AddProduct(Product product){

        _products.Add(product);

    }

    public Customer GetCustomer(){

        return _customer;
    }

}