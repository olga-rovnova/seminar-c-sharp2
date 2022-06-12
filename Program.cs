//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("введите целое число N: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

int count = number;

if (number > 0)
{
    while (count > 1)
    {
        int div = number % 2;
        if (div == 0)
        {
            Console.Write(number);
        }
        else
        {
            Console.Write(" ");
        }
        number = number - 1;
        count = count - 1;
    }
}
if (number <= 0)
{
    while (count < 1)
    {
        int div = number % 2;
        if (div == 0)
        {
            Console.Write(number);
        }
        else
        {
            Console.Write(" ");
        }
        number = number + 1;
        count = count + 1;
    }
}
