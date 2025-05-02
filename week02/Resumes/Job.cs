using System;

public class Job
{
    // Member variables
    private string _jobTitle;
    private string _company;
    private int _startYear;
    private int _endYear;

    // Constructor to initialize the job details
    public Job(string jobTitle, string company, int startYear, int endYear)
    {
        _jobTitle = jobTitle;
        _company = company;
        _startYear = startYear;
        _endYear = endYear;
    }

    // Method to display the job details
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

    // Getter methods for accessing the job details, if needed later
    public string JobTitle => _jobTitle;
    public string Company => _company;
    public int StartYear => _startYear;
    public int EndYear => _endYear;
}
