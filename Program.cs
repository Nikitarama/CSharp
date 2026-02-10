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

using System;
using System.Net.Http.Headers;
using System.Xml;

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

// string permission = "Admin";
// int level = 50;

// if (permission.Contains("Admin"))
// {
//     Console.WriteLine((level >= 55) ? "Welcome, Super Admin user." : "Welcome, Admin user.");
// }
// else if (permission.Contains("Manager"))
// {
//     Console.WriteLine((level >= 20) ? "Contact an Admin for access." : "You do not have sufficient privileges.");
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }

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

// FOR LOOP::
// int jo = 2;
// for (int i = 1; i < 500000; i++) {
//     jo += i;
//     Console.WriteLine(i);
// }


// path when flag = true
// int value;
// value = 10;
// Console.WriteLine($"Inside the code block: {value}");
// Console.WriteLine($"Outside the code block: {value}");

// Code sample 1

// bool flag = true;
// int value;

// the value var has red underline because outside of the code block, it has no value

// if (flag)
// {
//     value = 10;
//     Console.WriteLine($"Inside the code block: {value}");
// }

// Console.WriteLine($"Outside the code block: {value}");


//OPTION.1  - removing curly braces

// bool flag = true;
// if (flag)
//     Console.WriteLine(flag);

//OPTION.2 

// bool flag = true;
// if (flag) Console.WriteLine(flag);





// string name = "bob";
// if (name == "bob") Console.WriteLine("Found Bob");
// else if (name == "steve") Console.WriteLine("Found Steve");
// else Console.WriteLine("Found Chuck");


//INSTEAD OF:

// string name = "steve";

// if (name == "bob")
//     Console.WriteLine("Found Bob");
// else if (name == "steve") 
//     Console.WriteLine("Found Steve");
// else
//     Console.WriteLine("Found Chuck");





//FROM THIS:  

// int[] numbers = { 4, 8, 15, 16, 23, 42 };

// foreach (int number in numbers)
// {
//     int total;

//     total += number;

//     if (number == 42)
//     {
//        bool found = true;

//     }

// }

// if (found) 
// {
//     Console.WriteLine("Set contains 42");

// }

// Console.WriteLine($"Total: {total}");



//TO THIS: 

// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;

// foreach (int number in numbers)
// {
//     total += number;
//     if (number == 42)
//         Console.WriteLine("Set contains 42");
//         Console.WriteLine($"Total: {total}");
// }

//QUIZ::
// int value = 1;

// if (0 < value)
// {
//     int value2 = 8;
//     value += value2;
// }

// Console.WriteLine(value);

//match/switch expression is "fruit"  -  Case patterns are constructed using the keyword case followed by a value

// string fruit = "";

// switch (fruit)
// {
//     case "apple":
//         Console.WriteLine($"App will display information for apple.");
//         break;

//     case "banana":
//         Console.WriteLine($"App will display information for banana.");
//         break;

//     case "cherry":
//         Console.WriteLine($"App will display information for cherry.");
//         break;
// }




// int employeeLevel = 100;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"Hi Mr {employeeName},you are a/an {title}");

//////////////////////////////////FROM THIS//////////////////////////////////

// if (product[0] == "01")
// {
//     type = "Sweat shirt";
// }
// else if (product[0] == "02")
// {
//     type = "T-Shirt";
// }
// else if (product[0] == "03")
// {
//     type = "Sweat pants";
// }
// else
// {
//     type = "Other";
// }

// if (product[1] == "BL")
// {
//     color = "Black";
// } else if (product[1] == "MN")
// {
//     color = "Maroon";
// } else
// {
//     color = "White";
// }

// if (product[2] == "S")
// {
//     size = "Small";
// }
// else if (product[2] == "M")
// {
//     size = "Medium";
// }
// else if (product[2] == "L")
// {
//     size = "Large";
// }
// else
// {
//     size = "One Size Fits All";
// }

////////////////////////TO THIS/////////////////////////////

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>

// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0])
// {
//     case "01":
//     type = "Sweat shirt";
//         break;

//     case "02":
//     type = "T-Shirt";
//     break;

//     case "03":
//     type = "Sweat pants";
//         break;

//     default:
//         type = "Other";
//         break;
// }

// switch (product[1])
// {   
//     case "BL":
//         color = "Black";
//         break;

//     case "MN":
//         color = "Maroon";
//         break;

//     default:
//         color = "White";
//         break;
// }


// switch (product[2])
// {
//     case "S":
//         size = "Small";
//         break;

//     case "M":
//         size = "Medium";
//         break;

//     case "L":
//         size = "Large";
//         break;

//     default:
//         size = "One Size Fits All";
//         break;
// }

// Console.WriteLine($"Product: {type} {color} {size} ");

///////////////////////////////////////////////////////////////////

// use the "if-else" as a conditional (e.g. only display msg at a certain time OR give for half price if first purchase)
// display the msg if its a certain time else display nothing - would be difficult to use switch-case for this scenario
// switch-case is best used for inevitables like products and employee roles (which will always be there)

/////////////////////////////////////FOR LOOPS////////////////////////////////////////////////////////////////////


//the iteration's pre-condition, completion condition, its iteration pattern 

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }

// for (int i = 10; i >= 0; i--)
// {
//     Console.WriteLine(i);
// }

// for (int i = 0; i < 10; i += 2)
// {
//     Console.WriteLine(i);
// }


// if you need the iteration to stop at a certain point::

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }

// iterate through each name backward::

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)                 ---backward
// for (int i = 0; i < names.Length; i++)                      ---forward 
// {
//     Console.WriteLine(names[i]);
// }

///////SIMPLIFIED//////////////////////////////////////////
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = 0; i < names.Length; i++)
//     if (names[i] == "David") names[i] = "Sammy";

// foreach (var name in names) Console.WriteLine(name);

/////////BROKEN DOWN//////////////////////////////////////
// string[] names = { "Alex", "Eddie", "David", "Michael" };

// for (int i = 0; i < names.Length; i++)
// {
//     if (names[i] == "David")
//     {
//         names[i] = "Sammy";
//     }
// }

// foreach (var name in names)
// {
//     Console.WriteLine(name);
// }

////////MY CODE:::////////////////////////////////////////

// int a = 3;
// int b = 5;

// for (int i = 1; i < 101; i++)
// {
//     Console.Write($"\n{i}");

//     if ((0 == i % a) && (0 == i % b))
//         Console.Write($" - FizzBuzz");

//     else if (0 == i % a)
//         Console.Write($" - Fizz");

//     else if (0 == i % b)
//         Console.Write($" - Buzz");

// }

///////////Response://///////////////////////////////////
// 90 - FizzBuzz
// 91
// 92
// 93 - Fizz
// 94
// 95 - Buzz
// 96 - Fizz
// 97
// 98
// 99 - Fizz
// 100 - Buzz

// && - and (execute if both conditions are true)
// || - or (execute if either are true)

///////////////////DO WHILE LOOPS/////////////////////////

// Random random = new Random();
// int current = 0;

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);

// int current = random.Next(1, 11);

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");

// A code block that influences the exit criteria 
// is a primary reason to select a do-while or while statements
// rather than one of the other iteration statements.

// the "do{}" will execute iterations until the boolean stops it (goes and then stops)
// the "while()" will only execute iterations once the boolean is met (waits then goes)-> (acts as a "gate")
// while loops execute until the boolean returns a False - the code block can sometimes never execute if the first # is > 3
// do-while iterates at least once

// do
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;
//     Console.WriteLine(current);

// } while (current != 7);

//  a value of current that is greater than or equal to 8 will never be written to the output window
// So, the loop will continue to iterate as long as the value of current is not equal to 7.
// a break terminates out if the condition is met but continue goes to the end of the code block

// int hero = 10;
// int monster = 10;

// Random roll = new Random();

// int attack = roll.Next(1, 11);

// do
// {

//     attack = roll.Next(1, 11);
//     Console.WriteLine($"Hero attacks with a: {attack}");

//     monster -= attack;

//     Console.WriteLine($"Monster's health is now: {monster}");

//     if (monster > 0)
//       {
//         attack = roll.Next(1, 11);
//         hero -= attack;

//         Console.WriteLine($"Monster attacks with a: {attack}");
//         Console.WriteLine($"Hero's health is now: {hero}");
//       }


// }
//  while (hero > 0 && monster > 0);

//      if (monster < 0)
//     {
//         Console.WriteLine("You win");
//     }
//     else  
//     {
//         Console.WriteLine("You lose");   
//     }

//OR:::
// } while (hero > 0 && monster > 0);
// Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

/////RESPONSE:::////////////////

// Hero attacks with a: 3
// Monster's health is now: 7
// Monster attacks with a: 10
// Hero's health is now: 0
// You lose

////////////////////////////////NIC"S CODE//////////////////////////////////////////


// Console.WriteLine("Enter an integer value between 5 and 10");
//     string? inputStr;

//     inputStr = Console.ReadLine();

//     Int32.TryParse(inputStr, out int input);


// while (!(input > 5 && input < 10 ))
// {

//     if (input > 5 && input < 10 )
//         Console.WriteLine($"Your input value {input} has been accepted");

//     else if (inputStr == input.ToString())
//         Console.WriteLine($"You have entered an invalid number");
//     else
//         Console.WriteLine($"You have entered a type");


//     Console.WriteLine("Enter an integer value between 5 and 10");
//     inputStr = Console.ReadLine();
//     Int32.TryParse(inputStr, out input);

// }

///////////////////////////////////MY CODE/////////////////////////////////////////////////


//     int input;
//     string? inputStr;
//     bool entry = false;

//     Console.WriteLine("Enter an integer value between 5 and 10");

// do
// {
//     inputStr = Console.ReadLine();
//     entry = int.TryParse(inputStr, out input);

//     if (inputStr != null)
//     {

//         if (input > 5 && input < 10)
//         {
//             Console.WriteLine($"Your input value ({input}) has been accepted");
//             entry = true;
//         }
//         else if (input < 5 || input > 10)
//         {
//             Console.WriteLine($"You have entered {input}. Enter a number between 5 and 10");
//             entry = false;
//         }
//         else if (!(int.TryParse(inputStr, out input)))                //if its not an int then spit out the msg
//         {
//             Console.WriteLine("Sorry, you have entered an invalid number, please try again");
//             entry = false;
//         }
//     }  
//     else
//     {
//         Console.WriteLine("Sorry, you have entered an invalid number, please try again");
//     }
// }
// while (!entry);
////////////////////////////////////////MY CODE/////////////////////////////////////////////////////

// -  the ? character defines a nullable type variable

// string[] roles = ["Administrator", "Manager", "User"];
// bool validated = false;
// string? role;


// Console.WriteLine("Enter your role name (Administrator, Manager, User)");


// do

// {
//     role = Console.ReadLine();

//     if (role != null)
//     {

//         if (role.ToLower().Trim() ==  roles[0].ToLower().Trim())
//         {
//             Console.WriteLine($"Your input value ({role.Trim()}) has been accepted.");
//             validated = true;
//         }
//         else if (role.ToLower().Trim() == roles[1].ToLower().Trim())
//         {
//             Console.WriteLine($"Your input value ({role.Trim()}) has been accepted.");
//             validated = true;
//         }
//         else if (role.ToLower().Trim() == roles[2].ToLower().Trim()) 
//         {
//             Console.WriteLine($"Your input value ({role.Trim()}) has been accepted.");
//             validated = true;
//         }
//         else
//         {
//             Console.WriteLine($"The role name that you entered," + '"' + role.Trim() + '"' + " is not valid. Enter your role name (Administrator, Manager, or User)");
//         }
//     }
// }
// while(!validated);

////////////////////////////////////AFTER LOOKING AT THE SOLUTION:::::://////////////////////////////////////////

// - zero length string ""

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation = 0;
string myString = "";
int stringLength = myStrings.Length;

for (int i = 0; i < stringLength; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");              
    
    string trimString;

    while (periodLocation != -1)
    {
        
    trimString = myString.Remove(periodLocation);                                    
    myString = myString.TrimStart();
    myString = myString.Substring(periodLocation + 2);  //2 and not 1 because then it starts by the whitespace before I

    periodLocation = myString.IndexOf(".");             //// update the comma location and increment the counter (Don't really understand)
    
    Console.WriteLine(trimString);
    }

    trimString = myString.Trim();
    Console.WriteLine(trimString);
}

// - because we want to iterate through each individual letter in the array, we choose a for loop
//   instead of a foreach.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


Console.WriteLine("The current time is " + DateTime.Now);

 string? addInfo;

            do
            {
                Console.WriteLine("Do you want to add information for another pet? (y/n)");
                readResult = Console.ReadLine();
                addInfo = readResult;
                bool validEntry = false;

                if (addInfo != null)
                {
                    addInfo = addInfo.ToLower();

                    if (addInfo == "y")
                    {
                        for (int i = 0; i < maxPets; i++)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                Console.WriteLine(ourAnimals[i, j]);
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("Which pet would you like to add information for? Provide the ID:");
                        addInfo = Console.ReadLine();

                        if (addInfo != null)
                        {
                            animalID = animalID.ToLower();

                        if (animalID == animalID)
                            {
                                {
                                    animalNickname = addInfo;
                                }
                            }
                        
                        }


                    }
                }
            } while (addInfo == "");



            readResult = Console.ReadLine();