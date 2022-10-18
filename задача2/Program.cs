/* Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98 */

void AnswerToAsk(){

int number = (new Random()).Next(100, 1000);
Console.WriteLine($"рандомное число: {number}");
string numericAsString = number.ToString();
int result = int.Parse(numericAsString[0].ToString()+numericAsString[].ToString());
Console.WriteLine($"рандомное число без 2ой цифры: {number}");
}

AnswerToAsk();