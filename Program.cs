using System;

struct City
{
    public int CityNumber;
    public string CityName;
    public int LevelCovid;

    public City(int CityNumber, string CityName, int LevelCovid)
    {
        this.CityNumber = CityNumber;
        this.CityName = CityName;
        this.LevelCovid = LevelCovid;
    }
}

class Ragnarok
{
    static void Main(string[] args)
    {
        int AmountCity = int.Parse(Console.ReadLine());
        City[] cities = new City[AmountCity];

        for (int i = 0; i < AmountCity; i++)
        {
            Console.Write("CityNumber {0}: ", i + 1);
            int CityNumber = int.Parse(Console.ReadLine());
            Console.Write("CityName {0}: ", i + 1);
            string CityName = Console.ReadLine();
            Console.Write("LevelCovid {0}: ", i + 1);
            int LevelCovid = int.Parse(Console.ReadLine());

            City city = new City(CityNumber, CityName, LevelCovid);
            cities[i] = city;
        }

        for (int i = 0; i < AmountCity; i++)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("CityNumber: {0}", cities[i].CityNumber);
            Console.WriteLine("CityName: {0}", cities[i].CityName);
            Console.WriteLine("LevelCovid: {0}", cities[i].LevelCovid);
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
        }
    }
}
/*
struct City
{
    public int CityNumber;
    public string CityName;
    public int LevelCovid;
}

class Program
{
    static void Main(string[] args)
    {
        int cities = int.Parse(Console.ReadLine());
            string [] City = new string[cities];
           
            for (int i = 0; i < cities ; i++) {
                Console.Write("CityNumber {0}: ", i + 1);
                string CityNumber = Console.ReadLine();
                Console.Write("CityName {0}: ", i + 1);
                string CityName = Console.ReadLine();
                Console.Write("LevelCovid {0}: ", i + 1);
                string LevelCovid = Console.ReadLine();

       
        Console.Write("Enter a number (0-9): ");
        int userInput;

        if (int.TryParse(Console.ReadLine(), out userInput) && userInput >= 0 && userInput <= 9)
        {
            bool isValidCity = false;
            City selectedCity = new City();

            
            foreach (City city in cities)
            {
                if (city.CityNumber == userInput)
                {
                    isValidCity = true;
                    selectedCity = city;
                    break;
                }
            }

            if (isValidCity)
            {
                Console.WriteLine("City Number: {0}", selectedCity.CityNumber);
                Console.WriteLine("City Name: {0}", selectedCity.CityName);
                Console.WriteLine("Covid Level: {0}", selectedCity.CovidLevel);

                Console.WriteLine("\nEnter your message:");
                string message = Console.ReadLine();

                if (message.Contains("Outbreak"))
                {
                    selectedCity.CovidLevel += 2;
                    if (selectedCity.CovidLevel > 3)
                        selectedCity.CovidLevel = 3;
                }
                else if (message.Contains("Vaccinate"))
                {
                    selectedCity.CovidLevel = 0;
                }
                else if (message.Contains("Lockdown"))
                {
                    selectedCity.CovidLevel -= 1;
                    if (selectedCity.CovidLevel < 0)
                        selectedCity.CovidLevel = 0;
                }
                else if (message.Contains("Spread"))
                {
                   
                }
                else if (message.Contains("Exit"))
                {
                    Console.WriteLine("Exiting the program...");
                }
                else
                {
                    Console.WriteLine("Invalid message.");
                }

                Console.WriteLine("\nUpdated Covid Level: {0}", selectedCity.CovidLevel);
            }
            else
            {
                Console.WriteLine("Invalid city number!");
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }

        Console.ReadLine();
    }
}
}
*/

