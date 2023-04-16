// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


/* "Написать приложение в которое можно ввести 3 числа, программа их сравнит и скажет какое из них больше"

1) приглошение ко вводу
2) ввод переменных
3) помещение чисел в строки 
4) объявление переменных для хранения max и min
5) условие, сравнение
6) вывод ответа
*/


Console.Clear();

Console.WriteLine("Введите 2 числа, а я скажу какое из них больше а какое меньше");

Console.Write("Введите первое число: ");

string input = Console.ReadLine();  
int number1 = int.Parse(input);

Console.WriteLine($"Число: {number1}");


Console.Write("Введите второе число: ");
string input2 = Console.ReadLine();  
int number2 = int.Parse(input2);
Console.WriteLine($"Число: {number2}");


int max = number1;
int min = number2;

if(max < number2)
{
    max = number2;
    min = number1;
}
Console.Write("Ответ: ");
Console.Write($"max = {max}; ");
Console.WriteLine($"min = {min}.");

