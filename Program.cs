namespace HomeTask18_Enum_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a currency(USD, TRY, RUB, EUR): ");
            string userCurrencyInput = Console.ReadLine();
            Console.WriteLine("Please, enter amount of money: ");
            double userInput = double.Parse(Console.ReadLine());

            ConvertCurr(userInput, userCurrencyInput);

        }

        public static void ConvertCurr(double curr, string currency)
        {
            switch (currency)
            {
                case "USD":
                    Money money = new Money(curr, CurrencyEnum.USD);
                    double convertedAmount = money.Value * 0.59;
                     
                    Console.WriteLine($"\n{curr} AZN -> {convertedAmount} {CurrencyEnum.USD}");
                    break;
                case "TRY":
                    Money money2 = new Money(curr, CurrencyEnum.TRY);
                    double convertedAmount2 = money2.Value * 16.48;

                    Console.WriteLine($"\n{curr} AZN -> {convertedAmount2} {CurrencyEnum.TRY}");
                    break;
                case "RUB":
                    Money money3 = new Money(curr, CurrencyEnum.RUB);
                    double convertedAmount3 = money3.Value * 57.71;

                    Console.WriteLine($"\n{curr} AZN -> {convertedAmount3} {CurrencyEnum.RUB}");
                    break;
                case "EUR":
                    Money money4 = new Money(curr, CurrencyEnum.EUR);
                    double convertedAmount4 = money4.Value * 0.56;

                    Console.WriteLine($"\n{curr} AZN -> {convertedAmount4} {CurrencyEnum.EUR}");
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again!");
                    break;
            }
        }
    }
}
