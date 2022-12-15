//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//
//6 -> да
//7 -> да
//1 -> нет
Console.Write("Введи цифру дня недели: ");
int Num = Convert.ToInt32(Console.ReadLine());

void check (int Num) {
  if (Num == 6 || Num == 7) {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (Num < 1 || Num > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}

check(Num);