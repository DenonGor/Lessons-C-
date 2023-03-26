// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.WriteLine("Введите число, а мы проверим четное или нет");
string strNum1 = Console.ReadLine();
int num1 = Convert.ToInt32(strNum1);
num1=num1 % 2;
if (num1 == 0){
    Console.WriteLine("да");
    }
    else
    {Console.WriteLine("нет");
    };