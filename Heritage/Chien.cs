using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    public class Chien : Animal
    {

        public string Pedigree { get; set; }

        public override void FaitBruit()
        {
            Console.WriteLine("Wouf");
        }
    }
}
