// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";

/* Response:
True
False
False
True */

// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Console.WriteLine(myValue == "a");

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

/*False
True
True
False*/

// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

// /* False
// True
// True
// True */

// Contains()
// StartsWith()
// EndsWith()

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

// True
// False

// unary negation operator !

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));

// False
// True

// inequality operator !=
// returns true if its operands arent equal
// the expression x != y produces the same result as the expression !(x == y) (an example of logical negation).

// conditional operator ?:
// <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

using System.Net.Http.Headers;

// Random saleAmount = new Random();
// int saleAmount1 = saleAmount.Next(0, 5000);
// int discount = saleAmount1 > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {discount}");
// Console.WriteLine($"SaleAmount: {saleAmount1}");

// Random coinFlip = new Random();
// int flip = coinFlip.Next(0, 3);
// int result = flip > 1 ? 100 : 50;

// Console.WriteLine($"Discount: {result}");
// Console.WriteLine($"Flip: {result}");

// Random coinFlip = new Random();
// int flip = coinFlip.Next(0, 3);

// if (flip > 1)
// {
//     Console.WriteLine("heads");
// }
// else
// {
//     Console.WriteLine("tails");
// }

// SOLUTION:::

// Random coin = new Random();
// int flip = coin.Next(0, 2);
// Console.WriteLine((flip == 0) ? "heads" : "tails");

// the limits are 0 and 1 - the flip will either be 0 or 1 - if its 0 = heads - if its anything else = tails

// OR

// Random coin = new Random();
// Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");

//////////////////////////////////MY CODE://///////////////////////////////////////////////
string permission = "Admin";
int level = 50;

if (permission.Contains("Admin"))
{
    Console.WriteLine((level >= 55) ? "Welcome, Super Admin user." : "Welcome, Admin user.");
}
else if (permission.Contains("Manager"))
{
    Console.WriteLine((level >= 20) ? "Contact an Admin for access." : "You do not have sufficient privileges.");
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

//////////////////////////////////THE BROKEN DOWN VERSION///////////////////////////////////
//     if (permission.Contains("Admin"))
//      if (level >= 55)
// {
//     Console.WriteLine("Welcome, Super Admin user.");
// }
// else if (permission.Contains("Admin"))
//     if ( level <= 55 )
// {
//     Console.WriteLine("Welcome, Admin user.");
// }
// else if (permission.Contains("Manager"))
//     if ( level >= 20 )
// {
//     Console.WriteLine("Contact an Admin for access.");
// }
// else if (permission.Contains("Manager"))
//     if ( level <= 20 )
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }
// else 
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }



