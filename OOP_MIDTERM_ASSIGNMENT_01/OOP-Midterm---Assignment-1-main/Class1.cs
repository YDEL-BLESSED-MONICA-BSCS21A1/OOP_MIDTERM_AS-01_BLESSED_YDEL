using System.Collections.Generic;
using static WinFormsApp1.Form1;

namespace WinFormsApp1
{
    public class Class1
    {
        public List<Person> People { get; set; }


        public Class1()
        {
            People = new List<Person>
            {
                new Person { ID = 1, Name = "Blessed Monica" },
                new Person { ID = 2, Name = "Raven" }
            };
        }
    }
}
