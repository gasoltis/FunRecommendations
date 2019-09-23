using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunRecommendations
{
    class Program
    {
        static void Main(string[] args)
        {
            string Activity = "";
            string TravelMethod = ""; 
            {
                Console.WriteLine("Hello. What kind of fun are you up for? Here are your options: Action, Chilling, Danger, Good Food.");
                string Mood = Console.ReadLine();

                if (Mood == "Action")
                {
                    Activity = "Stock Car Racing";
                }

                else if (Mood == "Chilling")
                {
                    Activity = "Hiking";
                }

                else if (Mood == "Danger")
                {
                    Activity = "Skydiving";
                }

                else if (Mood == "Good Food")
                {
                    Activity = "TacoBell";
                }

                else
                {
                    Activity = "I do not understand your input";
                }

                 Console.WriteLine("How many people will be joining you?");
                int numPeople = Convert.ToInt32(Console.ReadLine());


                if (numPeople == 0)
                {
                    TravelMethod = "Sneakers";
                }

                else if (numPeople > 0 && numPeople < 5)
                {
                    TravelMethod = "Sedan";
                }

                else if (numPeople > 4 && numPeople < 11)
                {
                    TravelMethod = "Volkswagen Bus";
                }

                else if (numPeople >= 11)
                {
                    TravelMethod = "Airplane";
                }

                Console.WriteLine("Okay, if you're in the mood for " + Mood + " then you should go " + Activity + " and travel by " + TravelMethod);

                Console.WriteLine("Goodbye!");

                Console.ReadLine();

            }
        }

    }
}
