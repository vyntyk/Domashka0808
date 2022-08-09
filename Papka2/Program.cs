/*Задача 13: Напишите программу, которая выводит 
третью цифру заданного числа или сообщает,
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Please enter your number: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
int position = 3;

if (anyNumber < 100)
{
    Console.WriteLine($"{anyNumber} -> третьей цифры нет");
}
else
{
    Console.WriteLine($"{position} цифра: " + FindNumber(anyNumber, position));
}

int FindNumber(int anyNumber, int position)
{
    int digitCount = (int)Math.Log10(anyNumber) + 1;

    var pow = (int)Math.Pow(10, digitCount - position);
    return (anyNumber / pow) % 10;
}