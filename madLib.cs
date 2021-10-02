using System;

namespace MadlibPractice
{
    class madLib
    {
        static void Main(string[] args)
        {
            //Init Variables
            string systemName, yourName, enemyName, save, fight;
            string[] job = new string[4];

            //Get Input From User
            Console.WriteLine("Hello user.");
            Console.WriteLine("Let me tell you a story.");
            Console.WriteLine("What is your name user?");
            yourName = Console.ReadLine();
            Console.WriteLine("And where are you right now?");
            systemName = Console.ReadLine();
            Console.WriteLine("Who is your greatest enemy?");
            enemyName = Console.ReadLine();
            Console.WriteLine("What careers do you consider integral to society?");
            job[0] = Console.ReadLine();
            job[1] = Console.ReadLine();
            job[2] = Console.ReadLine();
            job[3] = Console.ReadLine();
            Console.WriteLine("If they were in danger what would you do for them?");
            save = Console.ReadLine();
            Console.WriteLine("And how do you believe they will act in return?");
            fight = Console.ReadLine();
            
            //Init Story
            string madlibStory =
                $"{systemName} is a system, {yourName}. That system is our {enemyName}. " +
                $"But when you're inside, you look around, what do you see? " +
                $"{job[0]}, {job[1]}, {job[2]}, {job[3]}. The very minds " +
                $"of the people we are trying to {save}. But until we do, " +
                $"these pepole are still a part of that {systemName} and that makes " +
                $"them our {enemyName}. You have to understand, most of them are so inured, " +
                $"so hopelessly dependent on the {systemName}, that they will {fight} to protect it.";

            //Print Story
            Console.WriteLine("Here is your story");
            Console.WriteLine(madlibStory);
        }
    }
}
