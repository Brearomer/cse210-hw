using System;

class Program
{
    static void Main(string[] args)
    {
        Activity runningActivity = new RunningActivity(new DateTime(2022, 11, 3), 30, 3.0);
        Activity cyclingActivity = new CyclingActivity(new DateTime(2022, 11, 3) ,30, 15.0);
        Activity swimmingActivity = new SwimmingActivity(new DateTime(2022,11,3), 30,10);

        // Put activities in a list
        List<Activity> activities = new List<Activity>
        {
           runningActivity,
           cyclingActivity,
           swimmingActivity
        };
       
        foreach (Activity activity in activities)
        {
           Console.WriteLine(activity.GetSummary());
        }
    }
}