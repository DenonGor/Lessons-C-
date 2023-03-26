// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Введите Первое число");
string strNum1 = Console.ReadLine();
int num1 = Convert.ToInt32(strNum1);
Console.WriteLine("Введите Второе число");
string strNum2 = Console.ReadLine();
int num2 = Convert.ToInt32(strNum2);
Console.WriteLine("Введите Третье число");
string strNum3 = Console.ReadLine();
int num3 = Convert.ToInt32(strNum3);
int max = 0;
if (num1 >= num2 && num1 >= num3)
                max = num1;
            else if (num2 >= num1 && num2 >=num3 )
                max = num2;
            else if (num3 >= num1 && num3 >= num2)
                max = num3;
Console.WriteLine($"Максимальное число: {max}");