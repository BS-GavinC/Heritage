using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    public class Chat : Animal
    {

        public int TailleGriffe { get; set; }

        public override void FaitBruit()
        {
            Console.WriteLine("Miaouw");
        }
    }
}
