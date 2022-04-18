using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckMyCV
{
    class Qualification
    {
        public Qualification(int weightOfRequirements, string requirements)
        {
            WeightOfRequirements = weightOfRequirements;
            Requirements = requirements;
        }
        public int WeightOfRequirements { get; set; }
        public string Requirements { get; set; }
        


    }
}
