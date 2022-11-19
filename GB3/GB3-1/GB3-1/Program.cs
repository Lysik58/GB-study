Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] && number[1]==number[3])
  {
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

string numberStr =  (number);
if (number.Length < 5 || number.Length > 5 ) Console.WriteLine("Ошибка");
else
    CheckingNumber(number);
