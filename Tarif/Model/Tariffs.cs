using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarif
{
    class Tariffs
    {
       

        public double Price { get; private set; }

        public string Name { get; private set; }

        public int Minutes { get; private set; }

        public int Gygabytes { get; private set; }

        public int Messages { get; private set; }


        public Tariffs(string name, int minutes, int gygabytes, int messages)
        {
            Price = (minutes/1.34 + gygabytes*2 + messages*2) ;
            Name = name;
            Minutes = minutes;
            Gygabytes = gygabytes;
            Messages = messages;
        }
    }
}
