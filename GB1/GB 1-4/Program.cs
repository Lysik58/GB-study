Console.WriteLine ("Введите число");
int N = int.Parse (Console.ReadLine());
int i = 2;
while (i<=N)
{
    Console.Write (i);
    Console.Write (",");
    i=i+2;
}