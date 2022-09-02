try
{
Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32 (Console.ReadLine ());
int max = 0;
int min = 0;
if (firstNumber > secondNumber)
{
max = firstNumber;
min = secondNumber;
Console.WriteLine ("большее число: " + max + " меньшее число: " + min);
}
else if (secondNumber > firstNumber)
{
max = secondNumber;
min = firstNumber;
Console.WriteLine ("большее число: " + max + " меньшее число: " + min);
}
else Console.WriteLine ("Числа равны");
}
catch
{
Console.WriteLine ("error");
}