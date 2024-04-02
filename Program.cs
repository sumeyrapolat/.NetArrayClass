// See https://aka.ms/new-console-template for more information


int[] numbers = { 12, 14, 20, 11, 36, 24, 89, 1, 7 };


Console.WriteLine("Unsorted Array: ");
foreach (var number in numbers)
{
    Console.Write(number + ", ");

}
Console.WriteLine();


//sort()
Console.WriteLine("Sorted Array: ");
Array.Sort(numbers);
foreach (var number in numbers)
{
    Console.Write(number + ", ");
}
Console.WriteLine();


//reverse()
Console.WriteLine("Reversed Array: ");
Array.Sort(numbers);
Array.Reverse(numbers);
foreach (var number in numbers)
{
    Console.Write(number + ", ");
}
Console.WriteLine();

//Clear()
Console.WriteLine("Clear Array: ");
Array.Clear(numbers,1,numbers.Length-2);
foreach (var number in numbers)
{
    Console.Write(number + ", ");
}
Console.WriteLine() ;

//IndexOf
Console.WriteLine("IndexOf Array: ");
Array.IndexOf(numbers,14);







