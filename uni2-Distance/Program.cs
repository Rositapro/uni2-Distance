
using uni2_Distance;

Console.WriteLine("enter the speed:");
double sleep = double.Parse(Console.ReadLine());
Console.WriteLine("enter the time:");
double time = double.Parse(Console.ReadLine());
Distance distance = new Distance(sleep, time);
Console.WriteLine(distance.ToString());