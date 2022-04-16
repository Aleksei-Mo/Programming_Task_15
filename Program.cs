//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("This programm determenies weekend by the entered number.");
Console.Write("Please enter a day number: ");
int dayNumber=Convert.ToInt32(Console.ReadLine());
DayOffCheck(dayNumber);




void DayOffCheck (int dayNumber)
{
if (dayNumber==6 ^ dayNumber==7)
{
    Console.WriteLine("This day is a day off.");
}
else if (dayNumber>0 & dayNumber<6)
{
    Console.WriteLine("This is a work day.");
}
else
{
    Console.WriteLine("ERROR! Check entered number. It should be from 1 to 7.");
}
}