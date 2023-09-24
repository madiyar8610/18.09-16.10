// Напишите программу, которая на вход принимает два числаи проверяет, 
//являетсяли первое число квадратом второго
// a=25, b=5 -> Первое число является кваждратом второго
// a=2, b=10 -> Первое число не является кваждратом второго

Console.WriteLine("Введите первое число");
int namber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int namber2 = Convert.ToInt32(Console.ReadLine());

if (namber2 * namber2 == namber1)
{
    Console.WriteLine("Первое число является кваждратом второго");
}
else
{
    Console.WriteLine("Первое число не является кваждратом второго");
}