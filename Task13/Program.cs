//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.
// 645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Write("Введи число: ");
int Num = Convert.ToInt32(Console.ReadLine());
string Text = Convert.ToString(Num);
if (Text.Length > 2){
  Console.WriteLine("третья цифра -> " + Text[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}