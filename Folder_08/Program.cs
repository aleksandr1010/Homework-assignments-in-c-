// Выяснить, кратно ли число заданному, если нет, вывести остаток.
int a, b, c;
 Console.WriteLine("Кратно ли число?");
Console.WriteLine("Кратность какому числу проверяем?");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
b = int.Parse(Console.ReadLine());
if ( b % a == 0)
 {
     Console.WriteLine("Число " + b + " - кратно " + a );
 }
    else
 {
    Console.WriteLine("Число " + b + " - не кратно " + a );
 }