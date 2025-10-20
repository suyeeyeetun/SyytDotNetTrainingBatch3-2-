

List<Product> products = new List<Product>
{
    new Product("Laptop", 1200m, 1),
    new Product("Mouse", 25m, 2),
    new Product("Keyboard", 75m, 1),
    new Product("Monitor", 300m, 1),
    new Product("Headphones", 150m, 1)
};

var expensiveProducts = products.Where(p => p.Price > 100m); // list ကို filter လုပ်ခြင်းဖြစ်ပါတယ်။
// ရလဒ်ကို ထုတ်ကြည့်ပါမယ်။
foreach (var product in expensiveProducts)
{
    Console.WriteLine(product.Name + " - " + product.Price);
}


// Product တွေရဲ့ နာမည်တွေကိုပဲ string list အသစ်တစ်ခုအနေနဲ့ ရယူပါမယ်။
var productNames = products.Select(p => p.Name);

// ရလဒ်ကို ထုတ်ကြည့်ပါမယ်။
foreach (var name in productNames)
{
    Console.WriteLine(name);
}


// Product တွေကို ဈေးအနည်းဆုံးကနေ အများဆုံးထိ စီပါမယ်။
var sortedByPriceAsc = products.OrderBy(p => p.Price);

// Product တွေကို ဈေးအများဆုံးကနေ အနည်းဆုံးထိ စီပါမယ်။
var sortedByPriceDesc = products.OrderByDescending(p => p.Price);

Console.WriteLine("--- ဈေးအနည်းမှအများ ---");
foreach (var product in sortedByPriceAsc)
{
    Console.WriteLine(product.Name + " - " + product.Price);
}


// နာမည်မှာ "Keyboard" ဖြစ်တဲ့ product ကို ရှာပါမယ်။
var keyboard = products.FirstOrDefault(p => p.Name == "Keyboard");

if (keyboard != null)
{
    Console.WriteLine("Found: " + keyboard.Name);
}


// Product အားလုံးရဲ့ စုစုပေါင်းတန်ဖိုး (Price * Quantity) ကို တွက်ချက်ပါမယ်။
decimal totalValue = products.Sum(p => p.Price * p.Quantity);
Console.WriteLine("Total Value of all products: " + totalValue);

// Product တွေရဲ့ ပျမ်းမျှဈေးနှုန်းကို တွက်ချက်ပါမယ်။
decimal averagePrice = products.Average(p => p.Price);
Console.WriteLine("Average Price: " + averagePrice);
