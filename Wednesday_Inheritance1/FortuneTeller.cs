using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday_Inheritance1
{
    class FortuneTeller
    {
        //Properties
        public virtual string Name { get; set; } = "Esmerelda"; //bonus content: should be able to make more than one teller.
        public string ExperienceLevel { get; set; }
        //Methods

        public static void Greet()
        {
            Console.WriteLine("Hello! Welcome to my humble shop.");
            Console.WriteLine("Finest prices! Highest accuracy!");
            Console.WriteLine("But don't expect a guarantee - this is only for fun.");
            Console.WriteLine("\n");
            Console.WriteLine("Can I interest you in my services? (Y/N)");
            string yorn = Console.ReadLine();//it always continues anyway. We won't accept NO for an answer!
        }
        public void StartService(Service service)
        {
            Console.WriteLine("Ah yes of course! And what is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("I should have known! You look just like a {0}.\nBut I digress.", userName);
        }
        internal void ListServices()
        {
            //throw new notimplemented exception();
            int counter = 1;
            Console.WriteLine("Choose from any available magic services (enter the number):");
            foreach (Service AvailableService in Program.AvailableServices)
            {
                Console.WriteLine("{0} - {1}", counter++, AvailableService);
            }
        }
        public void PlayAgain()
        {
            Console.WriteLine("Would you Like to play again? Y/N");
        }

        public void Farewell()
        {
            Console.WriteLine("Thank you for your patronage! Have a mystical day!");
        }
        /// <summary>
        /// Create a new fortune teller, giving it a name and experience level.
        /// </summary>
        /// <param name="name">The fortune teller's name.</param>
        /// <param name="experienceLevel">A string value (beginner, intermediate, advanced) for this fortune teller.</param>

        //Constructors
        public FortuneTeller(string name, string experienceLevel)
        {
            this.Name = name;
            this.ExperienceLevel = experienceLevel;//set up by Mel, not really implemented
        }

        public FortuneTeller()//default constructor
        {

        }

    }

}
