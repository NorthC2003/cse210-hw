using System;
using System.Threading;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() 
        : base("Breathing Activity", "This activity will help you relax by helping you breath in and out slowly. Clear your mind and focus on your breathing.")
    { }

    public void Run()
    {
        DisplayStartingMessage();
        int time = 0;

        while (time < _duration)
        {
            Console.Write("Breathe in... ");
            Countdown(4);
            time += 4;

            Console.Write("\nBreathe out... ");
            Countdown(4);
            time += 4;

            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}
