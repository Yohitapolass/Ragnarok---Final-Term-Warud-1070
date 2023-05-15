using System;
/*
        struct City
        {
            public int CityNumber;
            public string CityName;
            public int LevelCovid;
            public City(string CityNumber, string CityName, string LevelCovid) {
            this.CityNumber = CityNumber;
            this.CityName = CityName;
            this.LevelCovid = LevelCovid;

        }
    }
class Ragnarok{

    //static void Main(string []args){

     //   int AmoutCity = int.Parse(Console.ReadLine());
     //   string NameCity = string(Console.ReadLine());
     //   string [ , ] City = new int[AmoutCity,NameCity];

     //   }

         static void Main(string[] args){

            int AmoutCity = int.Parse(Console.ReadLine());
            string [] City = new string[AmoutCity];
           
            for (int i = 0; i < AmoutCity ; i++) {
                Console.Write("CityNumber {0}: ", i + 1);
                string CityNumber = Console.ReadLine();
                Console.Write("CityName {0}: ", i + 1);
                string CityName = Console.ReadLine();
                Console.Write("LevelCovid {0}: ", i + 1);
                string LevelCovid = Console.ReadLine();

            City city = new City(CityNumber,CityName,LevelCovid);
            city[i] = city;
        }

         for (int i = -1; i < AmoutCity; i++) {
             Console.WriteLine("------------------------------------");
             Console.WriteLine("CityNumber: {0}", i + 1);
             Console.WriteLine("CityName: {0}", city[i].CityName); 
             Console.WriteLine("LevelCovid: {0}", city[i].CityName); 
             Console.WriteLine("------------------------------------");
             Console.WriteLine();
        }
    }
}
*/
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

        // Prompt the user to enter a number
        Console.Write("Enter a number (0-9): ");
        int userInput;

        if (int.TryParse(Console.ReadLine(), out userInput) && userInput >= 0 && userInput <= 9)
        {
            bool isValidCity = false;
            City selectedCity = new City();

            // Find the city with the matching city number
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
                    // Handle Spread message if needed
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