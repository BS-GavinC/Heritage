using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    public class Animal
    {

        public string Nom { get; set; }

        public int Age { get; set; }

        public virtual void FaitBruit()
        {
            Console.WriteLine("Pas de bruit.");
        }
    }
}
