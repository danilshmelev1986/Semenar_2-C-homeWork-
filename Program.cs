// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine ("give me *** number");
// int  num = Convert.ToInt32 (Console.ReadLine());

// if ((num/100>1)&& (num/100<10))
// {
// int num1 = num/100;
// int num2 = num%10;
// int result =  (num - (num1*100) -num2)/10;

// Console.WriteLine (result);
// }

// else
// {
//     Console.WriteLine ("wrong number");
// }



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine ("give me a number");
int  num = Convert.ToInt32 (Console.ReadLine());

if (num>=100)
{
while (num >=1000)
{
    num = num/10;
}

int result = num%10;

Console.WriteLine (result);
}

else
{
Console.WriteLine ("there's no third digit");
}



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


// Console.WriteLine ("give me a number");
// int  num = Convert.ToInt32 (Console.ReadLine());

// if ((num>0)&&(num<8))
// {
// if ((num==6) || (num==7))
// {
//     Console.WriteLine ("Day off");
// }

// else
// {
// Console.WriteLine ("go to work");
// }
// }

// else 
// {
//    Console.WriteLine ("wrong number"); 
// }