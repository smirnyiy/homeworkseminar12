//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

/*

Console.Write("Введите трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine($"вторая цифра числа {threeDigitNumber} -> "+stringNumber[1]);


*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6
/*

Console.Write("Введи число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);
if (NumberText.Length > 2){
  Console.WriteLine($"третья цифра числа {Number} -> " + NumberText[2]);
}
else {
  Console.WriteLine($"В числе {Number} третьей цифры нет");
}

*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет
/*
Console.Write("Введите число, обозначающее день недели от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int num)
 {
  if (num == 6 || num == 7) {
  Console.WriteLine($"этот день выходной -> да");
  }
  else if (num < 1 || num > 7) {
    Console.WriteLine($"это не день недели");
  }
  else Console.WriteLine($"этот день не выходной -> нет");
}

CheckingTheDayOfTheWeek(num);
*/


