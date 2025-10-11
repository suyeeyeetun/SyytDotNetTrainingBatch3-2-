using System;
//class Product
//{
//    public string Name;
//    public decimal Price;
//    public int Quantity;
//    public Product(string name, decimal price, int quantity)
//    {
//        Name = name;
//        Price = price;
//        Quantity = quantity;
//    }
//    public decimal GetTotalPrice()
//    {
//        return Price * Quantity;
//    }
//    static void Main(string[] args)
//    {
//        Product product1 = new Product("Laptop", 500m, 2);
//        Console.WriteLine($"Product: {product1.Name}, Total Price: {product1.GetTotalPrice()}");
//        Console.WriteLine("--------------------------");
//        Console.ReadLine();
//    }
//}

//class SaleItem
//{
//    public string Name {  get;private set; }
//    private int _quantity;
//    public int Quantity
//    {
//        get { return _quantity; }
//        set
//        {
//            if (value >= 0) { _quantity = value; }
//            else { Console.WriteLine("Error: Quantity cannot be negative."); }
//        }

//    }

//    public decimal Price { get; set; }
//    public SaleItem(string name, decimal price, int quantity)
//    {
//        Name = name; 
//        Price = price;
//        Quantity= quantity;
//    }
//    public decimal CalculateTotalPrice()
//    {
//        return Price * Quantity;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        SaleItem item1 = new SaleItem("Keyboard", 45.5m, 3);
//        Console.WriteLine($"Item: {item1.Name}, Quantity: {item1.Quantity}, Price: {item1.Price}, Total: {item1.CalculateTotalPrice()}");

//        // Try setting a negative quantity to test validation
//        item1.Quantity = -2; // should show error message


//        Console.ReadLine();
//    }
//}




//class Vehicle
//{
//    public string brand = "Ford";  // Vehicle field
//    public void honk()             // Vehicle method 
//    {
//        Console.WriteLine("Tuut, tuut!");
//    }
//}

//class Car : Vehicle
//{
//    public string modelName = "Mustang";
//}
//class Program
//{
//    static void Main (string[] args)
//    {
//        Car car = new Car();
//        car.honk();
//        Console.WriteLine(car.brand + " " + car.modelName);
//    }
//}


//class Animal
//{
//    public virtual void  animalSound()
//    {
//        Console.WriteLine("The animal makes a sound");
//    }
//}
//class Cat : Animal
//{
//    public override void animalSound()
//    {
//        Console.WriteLine("Cat say meow");
//    }
//}
//class Program
//{
//    static void Main (string[] args)
//    {
//        Animal animal = new Animal();
//        Animal cat = new Cat();
//        cat.animalSound();
//    }
//}

abstract class Perfume
{
    public abstract void smell();
    public void quantityML()
    {
        Console.WriteLine("10ml");
    }
}
class Prada : Perfume
{
    public override void smell()
    {
        Console.WriteLine("It smells floral");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Prada prada = new Prada();
        prada.quantityML();
        prada.smell();
    }
}
