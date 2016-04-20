using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wednesday_Inheritance1
{
    internal enum DifficultyOptions { easy, medium, hard }; 

    abstract class Service
    {
        //properties

        public virtual string Name { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string Result { get; set; }
        public virtual int PercentEffective { get; set; }
        public override string ToString()//override the method toString to write the thing I want!
        {
            return this.Name;
        }
        public virtual void Work()
        {
            Console.WriteLine("Let me pull out my {0}.", this.Name);
            Thread.Sleep(2000);

        }
        public virtual Enum Difficulty { get; set; } = DifficultyOptions.medium; public virtual void Show()
        {
            Console.WriteLine("\nOh, my. The mystical {0} told me!\n", this.Name);
            Console.WriteLine(this.Result);
        }
        public virtual void StateEffectiveness()
        {
            Console.WriteLine("In case you're wondering, this method is {2} percent accurate", this.Name, this.Result, this.PercentEffective);
        }
    }

}
