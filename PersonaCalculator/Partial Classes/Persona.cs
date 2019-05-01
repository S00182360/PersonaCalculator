using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaCalculator
{
    public partial class Persona
    {
        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}", Arcana, Name, Level);
        }
    }
}
