using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Makerting Mananger";
        job1._company = "Spokie and Daughter";
        job1._startYear = 2015;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "Fabric seller";
        job2._company = "Rubics fabrics";
        job2._startYear = 2012;
        job2._endYear = 2016;

        Resume myResume = new Resume();
        myResume._name = "Noluthando Zilimbola-Mothata";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}