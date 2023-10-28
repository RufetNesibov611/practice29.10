using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice29._10
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
