using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Wednesday_Inheritance1
{
    class CrystalBall:Magic,IRandomPhrases
    {

        public Random rnd { get; set; } = new Random();

        //properties
        public List<string> Phrases { get; set; } = new List<string>(); 

        public override string Name { get; set; } = "Crystal Ball";

        public override Enum Difficulty { get; set; } = DifficultyOptions.easy;
    
        public override void Work()
        {
            base.Work();
            //now we will call a result method
            this.Result = GetPhrase();
        }
        public void CreatePhrases()
        {
            Phrases.Add("\"Night time is a dark place for you. Be careful of your choices.\"");
            Phrases.Add("\"Joy shines upon you with the coming of the dawn.\"");
            Phrases.Add("\"Stop and wait. Realign your energies. You are in conflict.\"");
            Phrases.Add("\"Now is the time to act! You must make your move immediately!\"");
            Phrases.Add("\"I see shiny objects in your near future.\"");
            Phrases.Add("\"The decorating around you is terrible Feng Shui.\"");
            Phrases.Add("\"Mars is in high sanction - don't start any business ventures.\"");
            Phrases.Add("\"If you always face the light, you will never see shadow.\"");
            Phrases.Add("\"The moon is full.. beware your tomorrows.");
            Phrases.Add("\"Never take your safety for granted. Death watches and paces restlessly.\"");
            Phrases.Add("\"The beautiful emerald resonates with your soul. Your aura will protect you.\"");
        }
        //overloaded method
        public void CreatePhrases(string phrase)
        {
            Phrases.Add(phrase);//this is an overload - the default() version is in the interface!
        }
        public string GetPhrase()
        {
            //local var
            int randomNumber = rnd.Next(Phrases.Count);
            return Phrases.ElementAt(randomNumber);
        }
        public CrystalBall()
        {
            this.Price = 45.00M;
            this.PercentEffective = 65;
            this.BlackMagic = false;
            Program.AvailableServices.Add(this);//casting this crystal ball object into Service
            //I want to call my initializer for phrases
            CreatePhrases();
        }
    
        

        
    }
}
