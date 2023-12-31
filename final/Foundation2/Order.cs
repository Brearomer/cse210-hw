using System.Net.Http.Headers;
using System.Reflection;

public class Order 
{
   private Customer _customers;
   private List<Product> _products;

   public Order(Customer customers)
   {
      this._customers = customers;
      this._products = new List<Product>();
   } 

   public void AddProduct(Product product)
   {
     _products.Add(product);
   } 

   public double TotalCostOfOrder()
   {
      double totalCost = 0;
      foreach (var product in _products)
      {
         totalCost += product._price * product._quantityOfProduct;
      } 

      totalCost += _customers.UsaOrNot() ? 5.0: 35.0;
      return totalCost;
   }

   public string PackingLabel()
   {
      string packingLabel = "";
      foreach(var product in _products)
      {
        packingLabel += $"{product._name} - Product ID: {product._productID}";
      } 
      return packingLabel;
   }

   public string ShippingLabel()
   {
      return $"Customer: {_customers._name} \n{_customers._address.FullAddress}";
   }
   
}