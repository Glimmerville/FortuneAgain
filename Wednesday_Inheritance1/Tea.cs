using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday_Inheritance1
{
    class Tea:Magic,IRandomPhrases
    {
        //here let's make a field.
        //private Random random = new Random(); //I can't use this field if I am using an Interface IRandomPhrases
        public Random rnd { get; set; } = new Random();
        //Tasseography
        public override string Name { get; set; } = "Tea";
        public override Enum Difficulty { get; set; } = DifficultyOptions.easy;

        public void TeaReading()
        {
            Console.WriteLine("Let me pour you a cup of fine, green tea.");
        }

        public override void Work()
        {
            base.Work();
            this.Result = GetPhrase();
        }

        public List<string> Phrases { get; set; } = new List<string>();

        public void CreatePhrases() //make sure return type, name, params, and visibility match the interface
        {
            Phrases.Add("\"The leaves form a bat. Are you into superheroes?\"");
            Phrases.Add("\"The leaves kind of look like a round globby mess.\"");
            Phrases.Add("\" Very interesting. The sign of the sun means you will go on vacation!\"");
            Phrases.Add("\"Is that a tree? It looks like uh, you will have Christmas?\"");
            Phrases.Add("\"I see a great shaggy dog... THE GRIM!\"");
            Phrases.Add("\"I see a bright sunny afternoon with a very tiny cloud on the horizon...\"");

        }

        public string GetPhrase()
        {
            //local var
            int randomNumb = rnd.Next(Phrases.Count);
            return Phrases.ElementAt(randomNumb);
        }
        public Tea() //this calls "CreateTeaPhrases"
        {
            this.Price = 25.00M;
            this.PercentEffective = 25;
            this.BlackMagic = false;
            Program.AvailableServices.Add((Service)this);
            CreatePhrases();
        }
    }
}

