using System;

public class Product {
    private string productName;
    private double price;
    private double weight;

    public string ProductName {
        get { return productName; }
        set { productName = value; }
    }

    public double Price {
        get { return price; }
        set { price = value; }
    }

    public double Weight {
        get { return weight; }
        set { weight = value; }
    }
}

public class Buy : Product {
    private int quantity;
    private double totalPrice;
    private double totalWeight;

    public int Quantity {
        get { return quantity; }
        set { quantity = value; }
    }

    public double TotalPrice {
        get { return totalPrice; }
        set { totalPrice = value; }
    }

    public double TotalWeight {
        get { return totalWeight; }
        set { totalWeight = value; }
    }
}

public class Check : Buy {
    public void PrintReceipt() {
        Console.WriteLine("Product name: " + ProductName);
        Console.WriteLine("Quantity: " + Quantity);
        Console.WriteLine("Total price: " + TotalPrice);
    }
}


class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
        Buy purchase = new Buy();
        purchase.ProductName = "iPhone 13 Pro Max";
        purchase.Quantity = 2;
        purchase.Price = 1299.00;
        purchase.TotalPrice = purchase.Price * purchase.Quantity;
        purchase.Weight = 0.24;
        purchase.TotalWeight = purchase.Weight * purchase.Quantity;

        Check receipt = new Check();
        receipt.ProductName = purchase.ProductName;
        receipt.Quantity = purchase.Quantity;
        receipt.TotalPrice = purchase.TotalPrice;
        receipt.PrintReceipt();
  }
}
