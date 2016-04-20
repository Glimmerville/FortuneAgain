using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Wednesday_Inheritance1
{
    class Magic:Service
    {
        public override decimal Price { get; set; }
        public override string Result { get; set; }
        public virtual bool BlackMagic { get; set; }
        
        public override string Name { get; set; }
        internal enum DifficultyOptions { easy, medium, hard };
        

        
    }
}
