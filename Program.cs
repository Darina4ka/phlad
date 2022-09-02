try
{
Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите третье число");
int thirdNumber = Convert.ToInt32 (Console.ReadLine ());
int max = 0;
if (firstNumber >= secondNumber)
{
max = firstNumber;
}
else if (secondNumber >= firstNumber)
{
max = secondNumber;
}
if (thirdNumber >= max)
{
max = thirdNumber;
Console.WriteLine ("максимальное число: " + max);
}
else if (thirdNumber <= max)
{
Console.WriteLine ("максимальное число: " + max);
}
}
catch
{
Console.WriteLine ("error");
}