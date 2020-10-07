using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_14_class
{
    class Program
    {
        //Class is used to define Reference Type. 
        //Field
        private string name;
        private int age;

        //event
        public event EventHandler NameChanged;

        //constructor
        public Program()
        {
            name = string.Empty;
            age = -1;
        }

        //property
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    if (NameChanged != null)
                    {
                        NameChanged(this, EventArgs.Empty);
                    }
                }
            }
        }

        public int Age
        {
            get 
            { 
                return this.age; 
            }
            set 
            { 
                this.age = value; 
            }
        }

        //method
        public string GetCustomerData()
        {
            string data = string.Format("Name: {0} (Age: {1})", this.Name, this.Age);
            return data;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Name = "LEE";
            p.Age = 20;
        }
    }
}
