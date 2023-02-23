// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел
int a,b,c;
string s;
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