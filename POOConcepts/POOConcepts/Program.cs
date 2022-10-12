// See https://aka.ms/new-console-template for more information


using POOConcepts;

Console.WriteLine("Conceptos POO");
Console.WriteLine("================");
//try
//{
//    Console.WriteLine(new Date(2022, 10, 8));
//    Console.WriteLine(new Date(2012, 1, 8));
//    Console.WriteLine(new Date(2001, 14, 19));
//}
//catch (Exception error)
//{
//    Console.WriteLine(error.Message);
//}


Employee employee1 = new SalaryEmployee
{
    Id = 1,
    FirstName = "Cesar",
    LastName = "Pineda",
    BirthDate = new Date(2001, 9, 4),
    HiringDate = new Date(2021, 8, 16),
    Active = true,
    Salary = 21500.05M
};

Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee
{
    Id = 2,
    FirstName = "Isaac",
    LastName = "Veras",
    BirthDate = new Date(2005, 10, 4),
    HiringDate = new Date(2022, 3, 13),
    Active = true,
    CommissionPorcentaje = 0.05F,
    Sales = 5245232M,

};

Console.WriteLine(employee2);

Employee employee3 = new HourlyEmployee
{
    Id = 3,
    FirstName = "Marcos",
    LastName = "Antonio",
    BirthDate = new Date(2005, 10, 4),
    HiringDate = new Date(2022, 3, 13),
    Active = true,
    Hours = 120,
    HoursValue = 2500M

};

Console.WriteLine(employee3);