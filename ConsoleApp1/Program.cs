
int age = 18;
string adult;
adult = age >= 18 ? "an adult" : "a teenager";
Console.WriteLine(adult);
Console.WriteLine("----------------------------");
Console.ReadLine();

string paymentMethod = "CreditCard";
switch (paymentMethod)
{
    case "Cash":
        Console.WriteLine("Cash payment received");
        break;
    case "CreditCard":
        Console.WriteLine("Card payment received");
        break;
    default:
        Console.WriteLine("Unknown payment received");
        break;
}
Console.WriteLine("----------------------------");
Console.ReadLine();

PaymentMethod paymentMethod1 = PaymentMethod.Cash;
switch (paymentMethod1)
{
    case PaymentMethod.Cash:
        Console.WriteLine("Cash payment received");
        break;
    case PaymentMethod.CreditCard:
        Console.WriteLine("Card payment received");
        break;
    case PaymentMethod.PayPal:
        Console.WriteLine("PayPal payment received");
        break;
    default:
        Console.WriteLine("Unknown payment received");
        break;
}
Console.WriteLine("----------------------------");
Console.ReadLine();

EnumBank enumBank = EnumBank.CB;
switch (enumBank)
{
    case EnumBank.KBZ:
        Console.WriteLine("Pay with KBZ");
        break;
    case EnumBank.AYA:
        Console.WriteLine("Pay with AYA");
        break;
    case EnumBank.CB:
        Console.WriteLine("Pay with CB");
        break;
    case EnumBank.MAB:
        Console.WriteLine("Pay with MAB");
        break;
    case EnumBank.YOMA:
        Console.WriteLine("Pay with YOMA");
        break;
    case EnumBank.UAB:
        Console.WriteLine("Pay with UAB");
        break;
    default:
        Console.WriteLine("Unknown bank");
        break;
}
Console.WriteLine("--------------------------");
Console.ReadLine();

string[] shoppingCart = {"cleanser", "toner", "serum", "sunscreen" };
foreach(string item in shoppingCart)
{
    Console.WriteLine(item);
}
Console.WriteLine("--------------------------");
Console.ReadLine();

for(int i = 0; i < shoppingCart.Length; i++)
{
    Console.WriteLine("Item " + (i+1) + " : " + shoppingCart[i]);
}
Console.WriteLine("--------------------------");
Console.ReadLine();


enum PaymentMethod
{
    Cash,
    CreditCard,
    PayPal
}

enum EnumBank
{
    None = 0,
    KBZ = 1,
    AYA = 2,
    CB = 3,
    MAB = 4,
    YOMA = 5,
    UAB = 6
}