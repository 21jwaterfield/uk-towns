using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    internal class Program
    {
        struct towns
        {
            public int population;
            public int bathrooms;
            public string town;
            public string street;
            public bool detatched;
        }

        static void Main(string[] args)
        {
            house h;
            h.bedrooms = 4;
            h.bathrooms = 4;
            h.town = "scholes";
            h.street = "new road east";
            h.detatched = true;

        }
    }
}
