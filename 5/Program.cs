﻿//Напишите программу, которая на вход принимает одно число (N), 
// 4
//-4
//а на выходе показывает все целые числа в промежутке от -N до N.
Console.Clear();
Console.Write("n:");
int n = int.Parse(Console.ReadLine());
for (int i = -n; i < n + 1;i++){
     Console.Write($"{i} ");
}