//функция возведения в квадрат
// int Power(int x)
// {

// return x*x;
// }

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Power(num));


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num* -1;
while(num2 <= num)
{
    Console.WriteLine(num2 +",");
    num2 = num2+1;
} 