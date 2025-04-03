using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace departamentWithExeptionTask
{
    internal interface IPerson
    {
        public string Name { get; set; }
        public byte Age { get; set; }

        
        public string ShowInfo();
        

    }
}
