using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {

       Job job1 = new Job();

       job1._jobTitle = "Software engineer";

       job1._company = "Tencent";

       job1._startYear = 2013;

       job1._endYear = 2015;

       Job job2 = new Job();

       job2._jobTitle = "Team leader";

       job2._company = "Riot Games";
       job2._startYear = 2015;
       job2._endYear = 2020;

       Resume myResume = new Resume();

       myResume._name = "Isaiah Ramos";

       myResume._jobs.Add(job1);
       myResume._jobs.Add(job2);

       myResume.Display(); 
        

        
    }
}