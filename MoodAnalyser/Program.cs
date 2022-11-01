using System;
namespace MoodAnalyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser Program");
            Console.WriteLine("Enter your Mood:");
            string message = Console.ReadLine();
            MoodAnalyser1 moodAnalyser1 = new MoodAnalyser1(message);
            moodAnalyser1.Analyser();
        }
    }
}