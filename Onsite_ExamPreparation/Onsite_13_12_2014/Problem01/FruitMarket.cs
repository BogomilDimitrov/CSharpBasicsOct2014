using System;
using System.Collections.Generic;

class FruitMarket
{
    static void Main()
    {
        string dayOfWeek = Console.ReadLine();
        double quantFirstProd = double.Parse(Console.ReadLine());
        string firstProd = Console.ReadLine();
        double quantSecondProd = double.Parse(Console.ReadLine());
        string secondProd = Console.ReadLine();
        double quantThirdProd = double.Parse(Console.ReadLine());
        string thirdProd = Console.ReadLine();

        Dictionary<string, double> products = new Dictionary<string, double>();

        products.Add("banana", 1.8);
        products.Add("cucumber", 2.75);
        products.Add("tomato", 3.2);
        products.Add("orange", 1.6);
        products.Add("apple", 0.86);

        switch (dayOfWeek)
        {
            case "Friday":
                {
                    products["banana"] -= 10.0 / 100 * products["banana"];
                    products["cucumber"] -= 10.0 / 100 * products["cucumber"];
                    products["orange"] -= 10.0 / 100 * products["orange"];
                    products["tomato"] -= 10.0 / 100 * products["tomato"];
                    products["apple"] -= 10.0 / 100 * products["apple"];
                    break;
                }
            case "Sunday":
                {
                    products["banana"] -= 5.0 / 100 * products["banana"];
                    products["cucumber"] -= 5.0 / 100 * products["cucumber"];
                    products["orange"] -= 5.0 / 100 * products["orange"];
                    products["tomato"] -= 5.0 / 100 * products["tomato"];
                    products["apple"] -= 5.0 / 100 * products["apple"];
                    break;
                }
            case "Tuesday":
                {
                    products["banana"] -= 20.0 / 100 * products["banana"];
                    products["orange"] -= 20.0 / 100 * products["orange"];
                    products["apple"] -= 20.0 / 100 * products["apple"];
                    break;
                }
            case "Wednesday":
                {
                    products["cucumber"] -= 10.0 / 100 * products["cucumber"];
                    products["tomato"] -= 10.0 / 100 * products["tomato"];
                    break;
                }
            case "Thursday":
                {
                    products["banana"] -= 30.0 / 100 * products["banana"];
                    break;
                }
        }


        double sum = quantFirstProd*products[firstProd] + quantSecondProd*products[secondProd] + quantThirdProd*products[thirdProd];

        Console.WriteLine("{0:F2}",sum);
    }
}
