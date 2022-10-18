/* напишите программу, котора выводит cлучанйное число из отрезка (10, 99) показывает наибольшую цифру числа.*/
//метод нахождения наибольшей цифры числа
//получение радномного числа от minValue до maxValue

internal class Program
{
    private static void Main(string[] args)
    {
        int GetNumber(int minValue, int maxValue)
        {
            Random rdn = new Random();
            int result = rdn.Next(minValue, maxValue);
            return result;

            Console.WriteLine();
        }

//метод нахождения наибольшей цифры числа
        int GetMaxDigitOfNumber(int number)
        {
            int firstDigit = number / 10;
            int secondDigit = number % 10;

            if (firstDigit > secondDigit)
                return firstDigit;
            else
                return secondDigit;
        }

        int number = GetNumber(10, 100);
        int maxDigit = GetMaxDigitOfNumber(number);

        Console.WriteLine($"Максмальное число: {number} Максимальная цифра:{maxDigit}");
    }
}