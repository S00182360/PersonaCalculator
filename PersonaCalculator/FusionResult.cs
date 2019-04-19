using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaCalculator
{
    class FusionResult
    {
        public Arcana Parent1 { get; set; }
        public Arcana Parent2 { get; set; }
        public Arcana Result { get; set; }

        public FusionResult(Arcana parent1, Arcana parent2)
        {
            Parent1 = parent1;
            Parent2 = parent2;
        }

        public Arcana CheckResult1(Arcana p1, Arcana p2)
        {
            if(p1.ArcanaName.Equals("Fool"))
            {

            }
        }
    }
}
