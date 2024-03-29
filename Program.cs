﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// new operator creates a new instance of the array
// string[] fraudulentOrderIDs = new string[3];
//         // First set of square brankets [] declares the variable as an array
//         // Second set of square brackets [] specifies the number of elements in the array
//     fraudulentOrderIDs[0] = "A123";
//     fraudulentOrderIDs[1] = "B456";
//     fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000"; // Intentional error
// Assign Order ID values to your array

// Initialize an array { } with values
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

// Access the elements in the array
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// Reassign the value of an array
fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Use the Length property of an array
// When the length of the array is unknown, use the Length property to determine the number of elements in the array
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// Implement the foreach statement
string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name); // will execute once for each element of the names array.
}

// Create and initialize an array of int
int[] inventory = { 200, 450, 700, 175, 250 };
// Add a variable to sum the value of each element in the array
int sum = 0;
int bin = 0;
// Add a foreach statement to iterate through the array
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
    // Bin 1 = 200 items (Running total: 200)
    // Bin 2 = 450 items (Running total: 650)
    // Bin 3 = 700 items (Running total: 1350)
    // Bin 4 = 175 items (Running total: 1525)
    // Bin 5 = 250 items (Running total: 1775)
}
// Display the sum of the array
Console.WriteLine($"We have {sum} items in inventory.");
// We have 1775 items in inventory.

// Nested iteration and selection statements
// Declare an array and initialise it to contain the following elements
string[] OrderIDs = {
    "B123",
    "C234",
    "A345",
    "C15",
    "B177",
    "G3003",
    "C235",
    "B179"
};
// Create a foreach statement to iterate through the array
foreach (string orderID in OrderIDs)
{
    if (orderID.StartsWith("B"))

        Console.WriteLine(orderID);
}

/*
    The following code creates five random OrderIDs
    to test the fraud detection process. OrderIDs
    consist of a letter from A to E, and a three digit
    number. Ex. A123.
*/
Random random = new Random();
string[] orderIDs = new string[5];
for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");
    orderIDs[i] = prefix + suffix;
}
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

/*
    Convert the message into a char array and then reverse the chars.
    Count the number of o's in the message.
    Convert it back to a string and print it out.
*/

string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();

Array.Reverse(charMessage);

int x = 0;
foreach (char i in charMessage)
{
    if (i == 'o')
    { x++; }
}
string new_message = new string(charMessage);

Console.WriteLine(new_message); // .god yzal eht revo spmuj xof nworb kciuq ehT
Console.WriteLine($"'0' appears {x} times."); // '0' appears 4 times.