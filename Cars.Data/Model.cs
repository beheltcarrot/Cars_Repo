using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Data
{
    class Model
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Car> Cars { get; set; }
    }
}
