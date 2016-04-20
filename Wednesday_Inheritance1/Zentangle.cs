using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday_Inheritance1
{
    class Zentangle:Service
    {
        //I want to make random patterns but not random phrases
        //so I am not using the iRandomPhrase Interface
        //Though I guess I could if I didn't mind my patterns being called phrases
        public Random rnd { get; set; } = new Random();

        public List<string> Patterns { get; set; } = new List<string>();

        public override string Name { get; set; } = "Zentangle";

        public override void Work()
        {
            base.Work();
            Console.Write("Here is the pattern you should concentrate on drawing:");
            this.Result = GetPattern() + ", " + GetPattern() + ", " + GetPattern() + ", and " + GetPattern();
            Console.WriteLine("\nDraw these within a Zentangle tile for great success!\n");
        }
        public string GetPattern()
        {
            //local var
            int randomNumber = rnd.Next(Patterns.Count);
            return Patterns.ElementAt(randomNumber);
        }
        public void CreatePatterns()
        {
            Patterns.Add("ipso");
            Patterns.Add("twisted rope");
            Patterns.Add("flutter tile");
            Patterns.Add("sunflower");
            Patterns.Add("lacy");
            Patterns.Add("stacks");
            Patterns.Add("me three");
            Patterns.Add("chainlea");
            Patterns.Add("woven");
            Patterns.Add("flying geese");
            Patterns.Add("ambler");
            Patterns.Add("cross stitch");
            Patterns.Add("jawz");
            Patterns.Add("lazy eights");
            Patterns.Add("xyp");
            Patterns.Add("pots n pans");
            Patterns.Add("starbars");
            Patterns.Add("euca");
            Patterns.Add("snail");
            Patterns.Add("jasmin");
            Patterns.Add("sparkool");
            Patterns.Add("spokes");
            Patterns.Add("pop-cloud");
            Patterns.Add("brayd");
            Patterns.Add("dutch hourglass");
            Patterns.Add("pina");
        }
        public void Zen_tangle()
        {
            Console.WriteLine("Let's draw a few patterns together!");
        }
        public Zentangle()
        {
            this.Price = 25.00M;
            this.PercentEffective = 100;
            Program.AvailableServices.Add((Service)this);//casting this into Service

            CreatePatterns();
        }
    }
}
