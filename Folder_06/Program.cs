﻿//Показать последнюю цифру трёхзначного числа
int number = new Random().Next(100, 1000);
int a = number % 10;
Console.WriteLine("Число: " + number);
Console.WriteLine("Единицы: " + a);
int b = (number % 100 - number % 10) / 10;   