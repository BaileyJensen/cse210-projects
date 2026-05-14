using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software engineer";
        job1._startDate = 1995;
        job1._endDate = 2015;

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Software engineer";
        job2._startDate = 2015;
        job2._endDate = 2026;
        
        Resume myResume = new Resume();
        myResume._name = "Alisson Tran";


        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);



      myResume.Display();
     
    
    }
}