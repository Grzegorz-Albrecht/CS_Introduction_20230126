// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел
int a,b,c;
string s;
<<<<<<< HEAD
Console.Write("Введите a: ");
s=Console.ReadLine();
a=Convert.ToInt32(s);
Console.Write("Введите b: ");
s=Console.ReadLine();
b=Convert.ToInt32(s);
Console.Write("Введите c: ");
s=Console.ReadLine();
c=Convert.ToInt32(s);
int Max=a;
if (b>Max)
Max=b;
if (c>Max)
Max=c;
    Console.Write("Max= ");
    Console.WriteLine(Max);

=======
System.Console.Write("Введите a: ");
s=Console.ReadLine();
a=Convert.ToInt32(s);
System.Console.Write("Введите b: ");
s=Console.ReadLine();
b=Convert.ToInt32(s);
System.Console.Write("Введите c: ");
s=Console.ReadLine();
c=Convert.ToInt32(s);
if (a>b)
    System.Console.WriteLine("a - максимальное");
if (b>c)    
    System.Console.WriteLine("b - максимальное"); 
else
    System.Console.WriteLine("c - максимальное"); 
>>>>>>> a78746ff77b6a0e4bfd8c1f35fc2f1db5520a049
