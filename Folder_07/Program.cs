//Удалить вторую цифру трёхзначного числа
int n = int.Parse(Console.ReadLine());
if(n >= 100 && n < 1000)
{
    int last = n % 10;
    int first = n/100;
    int result = first * 10 + last;
    Console.WriteLine("Number with deleted second digit: " + result);
}
else 
Console.WriteLine("This is not 3 digit number");
