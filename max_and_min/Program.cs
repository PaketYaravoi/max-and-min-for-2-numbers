// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


/* "Написать приложение в которое можно ввести 3 числа, программа их сравнит и скажет какое из них больше"

1) приглошение ко вводу
2) ввод переменных
3) помещение чисел в строки 
4) условие, сравнение
5) вывод ответа
*/


Console.Clear();

Console.WriteLine("Введите 3 числа и я скажу, какое из них больше");

Console.WriteLine("Введите первое число:");

string input = Console.ReadLine();  
int number1 = int.Parse(input);
Console.Clear();
Console.WriteLine($"Число: {number1}");


Console.WriteLine("Введите второе число:");
string input2 = Console.ReadLine();  
int number2 = int.Parse(input2);
Console.WriteLine($"Число: {number2}");

Console.WriteLine("Введите третье число:");
string input3 = Console.ReadLine();  
int number3 = int.Parse(input3);
Console.WriteLine($"Число: {number3}");

int max = number1;

if(max < number2)
{
    max = number2;
}
if(max < number3)
{
    max = number3;
}
Console.WriteLine($"Наибольшее число: {max}");