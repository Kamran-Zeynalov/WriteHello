using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContryLanuages
{
    internal class FrenchPerson : IPerson
    {
        public void Speak()
        {
            Console.WriteLine("Bonjour");
        }
    }
}
