using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{

    namespace Company
    {

        public class Company
        {
            public Company(string name)
            {
                Name = name;
            }

            private string Name { get; set; }
        }
    }
}