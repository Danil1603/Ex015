/* Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру, обозначающая день недели: ");
string userNumber = Console.ReadLine();
int dayNumber = int.Parse(userNumber);

if(dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("Да, является выходным");
}

if(dayNumber <= 5)
{
    Console.WriteLine("Нет, не является выходным");
}

else
{
    Console.WriteLine("Введенная цифра не соответствует дню недели");
}
