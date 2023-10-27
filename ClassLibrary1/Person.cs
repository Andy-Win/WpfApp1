using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Person
    { //Constructore
        public Person()
        {
            this.Name = "Andy";
            this.Age = 26;
        }
        //properties
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
