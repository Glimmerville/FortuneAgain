using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday_Inheritance1
{
    class Palmistry:Magic, IRandomPhrases
    //make sure return type, name, params, and visibility match the interface
    {
        public Random rnd { get; set; } = new Random();
        
        //properties
        public List<string> Phrases { get; set; } = new List<string>();

        public override string Name { get; set; } = "Palm Reading";

        public override Enum Difficulty { get; set; } = DifficultyOptions.medium;
        public override void Work()
        {
            base.Work();
            this.Result = GetPhrase();
        }
        public void CreatePhrases()
        {
            Phrases.Add("\"What is this? this is very unusual. Your life line goes on and on.\"");
            Phrases.Add("\"The path of your life will be fraught with many hardships.\"");
            Phrases.Add("\"Are you in love? Ah? Well you soon will be.\"");
            Phrases.Add("\"You should not get too comfortable, I see a great change ahead.\"");
        }
        public void CreatePhrases(string phrase)
        {
            Phrases.Add(phrase);
        }
        public string GetPhrase()
        {
            //local var
            int randomNumber = rnd.Next(Phrases.Count);
            return Phrases.ElementAt(randomNumber);
        }
        public void PalmReading()
        {
            Console.WriteLine("Give me your palm. No, no need to be so timid! Relax.");
        }
        public Palmistry()
        {
            this.Price = 65.00M;
            this.PercentEffective = 72;
            this.BlackMagic = false;
            Program.AvailableServices.Add((Service)this);//casting this into Service
            //I want to call my initializer for phrases
            CreatePhrases();
        }
    }
}
