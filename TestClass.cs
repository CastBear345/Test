using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    internal class TestClass
    {
        private int age;
        private string name;
        private string lastName;

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    lastName = value;
                }
            }
        }
    }
}
