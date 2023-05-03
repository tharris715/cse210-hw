using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "UT MD Anderson";
        job1._jobTitle = "Research assistant";
        job1._startYear = "2021";
        job1._endYear = "Current";

        //job1.Display();

        Job job2 = new Job();
        job2._company = "UC Riverside";
        job2._jobTitle = "Graduate Student Researcher";
        job2._startYear = "2018";
        job2._endYear = "2021";

        //job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Tim Harris";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}