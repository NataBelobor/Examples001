//Задача 4: 

int a, b, c; 
Console.WriteLine("Введите первое число: ");
Console.WriteLine("Введите второе число: ");
Console.WriteLine("Введите третье число: ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a<b)
{
   max = b;
}
if (max<c)
{
   max = c;
}
    Console.Write("max =  ");
    Console.WriteLine(max);


