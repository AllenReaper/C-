using System.ComponentModel.DataAnnotations;

public class Resume
{
    public string _name;
    public string _job;
    
    public string _company;

    public string _startyear, _endYear;

    public void display()
    {
        Console.WriteLine($"Name:{_name}");
        Console.Write($"Job Tital:{_job}, Company:({_company}), Start to End: {_startyear} - {_endYear}.");
    }

    


}