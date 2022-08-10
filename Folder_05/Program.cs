//Показать числа от -N до N
Console.WriteLine("Введите ограничение выводимых чисел");
int n= int.Parse(Console.ReadLine ( ));
int a= -n;
while(a <= n)
{
    Console.Write( a + " ") ;
    a ++;
}