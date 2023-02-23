//С клавиатуры вводятся два числа a и b. Найти максимальное из них. 
int a,b;
string s;
System.Console.WriteLine("Введите a:");
s=Console.ReadLine();
a=Convert.ToInt32(s);
System.Console.WriteLine("Введите b:");
s=Console.ReadLine();
b=Convert.ToInt32(s);
if (a>b)
    System.Console.WriteLine("a - максимальное");
else 
    System.Console.WriteLine("b - максимальное"); 