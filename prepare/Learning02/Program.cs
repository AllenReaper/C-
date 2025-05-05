using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        

        Job job1 = new Job();
        job1._jobtitle = "janitor";
        job1._company = "big little bois";
        job1._company = "happy time";
        job1._startyear = "2017";
        job1._endYear = "2020";

        job1.display();

        Resume resume1 = new Resume();
        resume1._name = "Jaxson McCammon";
        resume1._job = "IT Intern for School";
        resume1._company = "Printerlogic";
        resume1._startyear = "2017";
        resume1._endYear = "2018";

        resume1.display();

    }
    
}