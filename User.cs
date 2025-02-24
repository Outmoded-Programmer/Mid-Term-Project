using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Term_Project
{
    abstract class User
    {

        public string Name { get; set; }
        public string Role { get; protected set; }
        public abstract void DisplayInfo();

    }
}
