Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());
string numberchk = Convert.ToString(number);
if (numberchk.Length > 2 && numberchk.Length < 11 ){
  Console.WriteLine("Третья цифра в числе - " + numberchk[2]);
}
else {
  Console.WriteLine("Третьей цифры в числе нет или возникла перегрузка");
}
