using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables
    private string _name;
    private List<Job> _jobs;

    // Constructor to initialize the resume
    public Resume(string name)
    {
        _name = name;
        _jobs = new List<Job>();
    }

    // Method to add a job to the resume
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    // Method to display the resume and the list of jobs
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (var job in _jobs)
        {
            job.Display(); // Calling the Display method of the Job class
        }
    }
}
