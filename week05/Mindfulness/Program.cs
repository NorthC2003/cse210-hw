using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the options: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breath = new BreathingActivity();
                breath.Run();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflect = new ReflectionActivity();
                reflect.Run();
            }
            else if (choice == "3")
            {
                ListingActivity list = new ListingActivity();
                list.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye Friend!");
                break;
            }
        }
    }
}
