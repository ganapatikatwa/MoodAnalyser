using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyser1
    {
        public string message;

        public MoodAnalyser1(string message)
        {
            this.message = message;
        }

        public string Analyser()
        {
            if (message.ToLower().Contains("happy"))
            {
                Console.WriteLine("Happy");
                return "happy";
            }
            else
            {
                Console.WriteLine("Sad");
                return "sad";
            }
        }
    }
}
