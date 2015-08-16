using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPivot
{
    public class Model
    {
        public Model(string prop)
        {
            Prop = prop;
        }

        public string Prop { get; set; }
    }
}
