// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("Введите число, а я его разложу на четные");
string strNum1 = Console.ReadLine();
int num1 = Convert.ToInt32(strNum1);
int count = 1;
while (count < num1 + 1){
    if (count%2 == 0){
        Console.Write($"{count}, ");
    }
    count+=1;
}