// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Функция должна на вход принимать число, а выдавать сумму его цифр

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int A = Prompt($"Введите число    ");

  int SumNumber(int numberA)
  {
    
    int counter = Convert.ToString(numberA).Length;
    int result = 0;
    int sum = 0;

    for (int i = 0; i < counter; i++){
      result = numberA - numberA % 10;
      sum = sum + (numberA - result);
      numberA = numberA / 10;
    }
   return sum;
  }
Console.WriteLine("Сумма цифр в числе: " + SumNumber(A));