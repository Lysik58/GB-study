
Console.WriteLine("Введите число A");
int a = int.Parse (Console.ReadLine());
Console.WriteLine("Введите число B");
int b = int.Parse (Console.ReadLine());
Console.Write("A = ");
Console.WriteLine(a);
Console.Write("B = ");
Console.WriteLine(b);
if (a>b)
{
Console.WriteLine ($"Большее число A - {a}");

}
else{
    Console.WriteLine ($"Большее число B - {b}");
}
