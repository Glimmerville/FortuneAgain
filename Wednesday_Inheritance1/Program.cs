using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday_Inheritance1
{
    class Program
    {
        public static List<Service> AvailableServices { get; set; } = new List<Service>();
        //static means 'you can use it without instantiating an object' they are added when they are instantiated
        static void Main(string[] args)
        {
            FortuneTeller fortuneTeller = new FortuneTeller();//these are objects
            CrystalBall crystalBall = new CrystalBall();//child of magical, child of services
            Tea tea = new Tea(); 
            Palmistry palmistry = new Palmistry();
            Zentangle zentangle = new Zentangle(); //not yet implemented
            FortuneTeller.Greet(); //say hi
            do
            {
                fortuneTeller.ListServices();
                int selection = int.Parse(Console.ReadLine());
                //get service at the index of the num -1
                Service selectedService = (Service)AvailableServices[0];//casting into a parent, instantiating 'new object of type magic called selectedservice'
                try//setting up 0 as default selection
                {
                    selectedService = (Service)AvailableServices[selection - 1];//to get number on list, from index (0) but we will ask them 1
                }
                catch (Exception e)
                {
                    //console.WriteLine(e.Message);
                    Console.WriteLine("I didn't catch that so I will do {0}", selectedService);
                }
                fortuneTeller.StartService(selectedService);
                selectedService.Work();//now this one list will run whatever the slection was instead of crystalball.Work(), tea.Work(), etc.
                selectedService.Show();
                selectedService.StateEffectiveness();
                fortuneTeller.PlayAgain();//Ok I guess I need to add PlayAgain();
            } while (Console.ReadLine().ToUpper() == "Y");
            fortuneTeller.Farewell();
        }
    }
}        

