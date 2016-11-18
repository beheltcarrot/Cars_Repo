using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Data
{
    class Manufactures
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public List<Model> Models { get; set; }
    }
}
