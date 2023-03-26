// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите Первое число");
string strNum1 = Console.ReadLine();
int num1 = Convert.ToInt32(strNum1);
Console.WriteLine("Введите Второе число");
string strNum2 = Console.ReadLine();
int num2 = Convert.ToInt32(strNum2);
if (num1 > num2){
    Console.WriteLine($"Максимальное число {num1}");
    }
    else if (num1 < num2)
    {Console.WriteLine($"Максимальное число {num2}");
    }
    else
    {Console.WriteLine("Числа равны");
    };

 
