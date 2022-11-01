using System;
namespace MoodAnalyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MoodAnalyser1 moodAnalyser1 = new MoodAnalyser1("I am in Sad Mood");
            moodAnalyser1.Analyser();
        }
    }
}