// See https://aka.ms/new-console-template for more information
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
