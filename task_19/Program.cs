// Задача 19

// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет,
//  является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int index = 0;
int count = 0;
int size = number;

if(number >=10000 && number < 100000)
{
    while(index < 5 )
    {
        int numberA = number % 10;
        number = number / 10;
        count = (count + numberA) * 10;
        index++;
    }
    count = count / 10;

    if(count == size)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
      
}
else
{
    Console.WriteLine("число не пятизначное");
}