using System;
using System.Collections.Generic;

namespace Resumes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Job instances with new data
            Job job1 = new Job();
            job1._jobTitle = "Telemarketer";
            job1._company = "XYZ Corp";
            job1._startYear = 2023;
            job1._endYear = 2025;

            Job job2 = new Job();
            job2._jobTitle = "CSR";
            job2._company = "ABC Ltd";
            job2._startYear = 2020;
            job2._endYear = 2023;

            // Create Resume instance with a name
            Resume myResume = new Resume();
            myResume._name = "North Coltrin";

            // Add the jobs to the resume
            myResume.AddJob(job1);
            myResume.AddJob(job2);

            // Display the resume information
            myResume.Display();
        }
    }

    class Job
    {
        // Member variables
        public string _jobTitle;
        public string _company;
        public int _startYear;
        public int _endYear;

        // Display job details
        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }

    class Resume
    {
        // Member variables
        public string _name;
        public List<Job> _jobs = new List<Job>();

        // Add a job to the list
        public void AddJob(Job job)
        {
            _jobs.Add(job);
        }

        // Display resume details
        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");
            foreach (Job job in _jobs)
            {
                job.Display();  // Call the Display method of each Job
            }
        }
    }
}
