public class Job
{
    public string _company;

    public string _jobtitle;
    public string _startyear, _endYear;
    public void display()
    {
        Console.WriteLine($"Job Title:{_jobtitle} Company:({_company}) Start to End Year:{_startyear} - {_endYear}");
    }
    
}