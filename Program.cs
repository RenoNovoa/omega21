using System;

namespace omega21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    ^..^  Welcome to a magic first C# traveling Experience!  ^..^");

            Console.WriteLine();

            string vacationType = "";
            Console.WriteLine("    What kind of trip would you like to go on , musical, tropical, or adventurous ?");

            Console.WriteLine("    Please Enter Your Choice:  ");

            vacationType = Console.ReadLine();

            int groupSize = 0;
            Console.WriteLine("    How many are in your group?");
            groupSize = int.Parse(Console.ReadLine());



            string travelSuggestion = "";

            if (groupSize == 1 || groupSize == 2)
            {
                travelSuggestion = (" First Class");
            }
            else if (groupSize >= 3 && groupSize <= 5)
            {
                travelSuggestion = (" Helicopter");
            }
            else
            {
                travelSuggestion = ("Charter Flight");
            }


            string destination = "";

            if (vacationType == " musical")
            { destination = " New Orleans"; }
            else if (vacationType == "tropical")
            { destination = (" Beach Vacation in Mexico. "); }
            else { destination = (" Whitewater Rafting the Grand Canyon."); }


            string result = "";
            result = " Since your group of " + groupSize + " going on a " + vacationType + " vacation , You should  take a " + travelSuggestion + " to" + destination;

            Console.WriteLine(result);
            Console.ReadLine();

            Console.WriteLine(" Thanks for Traveling with Grand ^_~ Circus Agency! ");
            // tropical, or adventurous
            // string destination = vacationType + 
        }
    }
}
