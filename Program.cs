Console.WriteLine("Enter the no of entries: ");
var n = Convert.ToInt32(Console.ReadLine());

decimal[] fare = new decimal[n];
string[] destination = new string[n];

for (int i = 0;i < n; i++)
{
    Console.WriteLine($"Enter the destination number {i + 1}: ");
    destination[i] = Console.ReadLine();
    Console.WriteLine($"Enter the fare for reaching {destination[i]}: ");
    fare[i] = Convert.ToDecimal(Console.ReadLine());
}
Console.WriteLine($"Enter a number between 1 and {n}");
var num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The fare for reaching {destination[num - 1]} is {fare[num - 1]}.");