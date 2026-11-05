// Example usage of CollectionHelper class
int[] numbers = { 1, 2, 3, 4, 5 };

Console.WriteLine("=== PrintReverse ===");
CollectionHelper.PrintReverse(numbers);

Console.WriteLine("\n=== GetFirstElement ===");
Console.WriteLine($"First element: {CollectionHelper.GetFirstElement(numbers)}");

Console.WriteLine("\n=== GetLastElement ===");
Console.WriteLine($"Last element: {CollectionHelper.GetLastElement(numbers)}");

Console.WriteLine("\n=== ContainsElement ===");
Console.WriteLine($"Contains 3: {CollectionHelper.ContainsElement(numbers, 3)}");
Console.WriteLine($"Contains 10: {CollectionHelper.ContainsElement(numbers, 10)}");

Console.WriteLine("\n=== CountElements ===");
Console.WriteLine($"Element count: {CollectionHelper.CountElements(numbers)}");

Console.WriteLine("\n=== FindIndex ===");
Console.WriteLine($"Index of 3: {CollectionHelper.FindIndex(numbers, 3)}");
Console.WriteLine($"Index of 10: {CollectionHelper.FindIndex(numbers, 10)}");

// Example with strings
string[] fruits = { "Apple", "Banana", "Cherry", "Date" };

Console.WriteLine("\n=== String Collection Example ===");
Console.WriteLine("Fruits in reverse:");
CollectionHelper.PrintReverse(fruits);
Console.WriteLine($"First fruit: {CollectionHelper.GetFirstElement(fruits)}");
Console.WriteLine($"Last fruit: {CollectionHelper.GetLastElement(fruits)}");
