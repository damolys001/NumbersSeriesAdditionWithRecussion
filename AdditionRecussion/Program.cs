// See https://aka.ms/new-console-template for more information
Console.WriteLine("Add series of numbe with recusion...");


Console.WriteLine(AddNumbers(10));

Console.ReadLine();
 int AddNumbers(int number)
{ 
    if (number <= 0)
        return 0;

    return number + AddNumbers(number - 1);
}
