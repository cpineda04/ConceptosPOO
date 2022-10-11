// See https://aka.ms/new-console-template for more information


using POOConcepts;

Console.WriteLine("Conceptos POO");
Console.WriteLine("================");
try
{
    Console.WriteLine(new Date(2022, 10, 8));
    Console.WriteLine(new Date(2012, 1, 8));
    Console.WriteLine(new Date(2001, 14, 19));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}