using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday_Inheritance1
{
    interface IRandomPhrases//an interface is a template 
    {
        Random rnd { get; set; } //declare a property w/o initializing it
        List<string>  Phrases { get; set; }
        void CreatePhrases(); //a method with no body or params, returns void
        string GetPhrase();//returns a string
    }
}
