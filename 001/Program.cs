// 1.  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (и в нулевую степень). 
//Использовать свои функции, не использовать Math.Pow

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int A = Prompt($"Введите число A   ");
int B = Prompt($"Введите число B   ");

int result = 1;
for (int i = 1; i <= B; i++)
{
    result = result * A;
}

Console.WriteLine($"{result}");
