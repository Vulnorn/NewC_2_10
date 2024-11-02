namespace NewC_2_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int minNumberRandom = 0;
            int maxNumberRandom = 100;
            int specifiedNumber = 2;
            int degreeNumber = 0;
            int numberInDegree = 1;

            int randomNumber = random.Next(minNumberRandom, maxNumberRandom);

            for (int i = 0;numberInDegree<=randomNumber;i++)
            {
                numberInDegree = numberInDegree * specifiedNumber;
                degreeNumber++;
            }

            Console.WriteLine($"Число - {randomNumber} минимальная степень числа {specifiedNumber} - {degreeNumber} превосходящее заданное число ({numberInDegree})");
        }
    }
}