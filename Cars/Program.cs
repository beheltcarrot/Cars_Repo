using Cars.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            List<Manufactures> manufactures = context.Manuf.ToList();

        }
    }
}
