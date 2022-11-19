Console.Write("Введите цифру дня недели ");
int dayNumber = int.Parce(Console.ReadLine());
void ChkProcedure (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("Этот день выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Это не день недели");
  }
  else Console.WriteLine("Этот день не выходной");
}
ChkProcedure(dayNumber);
