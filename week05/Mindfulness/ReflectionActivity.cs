using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : MindfulnessActivity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone.",
        "Think of a time when you did something really difficult and really struggled.",
        "Think of a time when you helped someone.",
        "Think of a time when you did something truly heroic."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you start?",
        "How did you feel when you did it?",
        "What made this time different than other times?",
        "What is your favorite thing about it?",
        "What did you learn about yourself?",
        "How can you keep this reflection in the future?"
    };

    public ReflectionActivity() 
        : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength.")
    { }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now think on each of the following questions as they relate to this experience.");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.Write($"> {question} ");
            ShowSpinner(5);
            Console.WriteLine("\n");
        }

        DisplayEndingMessage();
    }
}
