//Найти максимальное из трех чисел
int a = new Random().Next(1,100);
Console.WriteLine(a);
int b = new Random().Next(1,100);
Console.WriteLine(b);
int c = new Random().Next(1,100);
Console.WriteLine(c);
if(a>b && a>c)
{
Console.WriteLine("a");
}
 if(b>c && b>a)
 {
Console.WriteLine("b");
 }
 if(c>b && c>a)
 {
Console.WriteLine("c");
 }
